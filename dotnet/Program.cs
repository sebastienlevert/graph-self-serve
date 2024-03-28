using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using CustomGraph.Client;
using CustomGraph.Client.Models;
using Microsoft.Graph.Core.Requests;
using CustomGraph.Client.Models.ODataErrors;

// The auth provider will only authorize requests to
// the allowed hosts, in this case Microsoft Graph
var allowedHosts = new [] { "graph.microsoft.com" };
var graphScopes = new [] { "User.Read", "Tasks.ReadWrite", "Mail.Read", "Files.ReadWrite.All", "Calendars.Read" };

var options = new DeviceCodeCredentialOptions
{
    ClientId = "6c319353-2730-46c4-83c7-15d41437ac43",
    DeviceCodeCallback = (code, cancellation) =>
    {
        Console.WriteLine(code.Message);
        return Task.FromResult(0);
    },
};

var credential = new DeviceCodeCredential(options);

var authProvider = new AzureIdentityAuthenticationProvider(credential, allowedHosts, scopes: graphScopes);
var adapter = new HttpClientRequestAdapter(authProvider);
var customClient = new CustomClient(adapter);

var messages = await customClient.Me.Messages
    .GetAsync(requestConfiguration =>
    {
        requestConfiguration.QueryParameters.Top = 10;
        requestConfiguration.QueryParameters.Select =
            ["sender", "subject", "body"];
        requestConfiguration.Headers.Add(
            "Prefer", "outlook.body-content-type=\"text\"");
    });

if (messages == null)
{
    return;
}

var pageIterator = PageIterator<Message, MessageCollectionResponse>
    .CreatePageIterator(
        adapter,
        messages,
        // Callback executed for each item in
        // the collection
        (msg) =>
        {
            Console.WriteLine(msg.Subject);
            return true;
        },
        // Used to configure subsequent page
        // requests
        (req) =>
        {
            // Re-add the header to subsequent requests
            req.Headers.Add("Prefer", "outlook.body-content-type=\"text\"");
            return req;
        });

await pageIterator.IterateAsync();

// Use the request builder to generate a regular
// request to /me
var userRequest = customClient.Me.ToGetRequestInformation();

var today = DateTime.Now.Date;

// Use the request builder to generate a regular
// request to /me/calendarview?startDateTime="start"&endDateTime="end"
var eventsRequest = customClient.Me.CalendarView
    .ToGetRequestInformation(requestConfiguration =>
        {
            requestConfiguration.QueryParameters.StartDateTime =
                today.ToString("yyyy-MM-ddTHH:mm:ssK");
            requestConfiguration.QueryParameters.EndDateTime =
                today.AddDays(1).ToString("yyyy-MM-ddTHH:mm:ssK");
        });

// Build the batch
var batchRequestContent = new BatchRequestContentCollection(adapter);

// Using AddBatchRequestStepAsync adds each request as a step
// with no specified order of execution
var userRequestId = await batchRequestContent
    .AddBatchRequestStepAsync(userRequest);
var eventsRequestId = await batchRequestContent
    .AddBatchRequestStepAsync(eventsRequest);

var batchRequestBuilder = new BatchRequestBuilder(adapter);
var returnedResponse = await batchRequestBuilder.PostAsync(batchRequestContent);

// De-serialize response based on known return type
try
{
    var user = await returnedResponse
        .GetResponseByIdAsync<User>(userRequestId);
    Console.WriteLine($"Hello {user.DisplayName}!");
}
catch (Exception ex)
{
    Console.WriteLine($"Get user failed: {ex.Message}");
}

// For collections, must use the *CollectionResponse class to deserialize
// The .Value property will contain the *CollectionPage type that the Graph client
// returns from GetAsync().
try
{
    var events = await returnedResponse
        .GetResponseByIdAsync<EventCollectionResponse>(eventsRequestId);
    Console.WriteLine(
        $"You have {events.Value?.Count} events on your calendar today.");
}
catch (Exception ex)
{
    Console.WriteLine($"Get calendar view failed: {ex.Message}");
}

var filePath = "./README.md";
using var fileStream = File.OpenRead(filePath);

// Use properties to specify the conflict behavior
var uploadSessionRequestBody = new CustomGraph.Client.Drives.Item.Items.Item.CreateUploadSession.CreateUploadSessionPostRequestBody
{
    Item = new DriveItemUploadableProperties
    {
        AdditionalData = new Dictionary<string, object>
        {
            { "@microsoft.graph.conflictBehavior", "replace" },
        },
    },
};

// Create the upload session
// itemPath does not need to be a path to an existing item
var myDrive = await customClient.Me.Drive.GetAsync();
var uploadSession = await customClient.Drives[myDrive?.Id]
    .Items["root:/README.md:"]
    .CreateUploadSession
    .PostAsync(uploadSessionRequestBody);

// Max slice size must be a multiple of 320 KiB
int maxSliceSize = 320 * 1024;
var fileUploadTask = new LargeFileUploadTask<DriveItem>(
    uploadSession, fileStream, maxSliceSize, adapter);

var totalLength = fileStream.Length;
// Create a callback that is invoked after each slice is uploaded
IProgress<long> progress = new Progress<long>(prog =>
{
    Console.WriteLine($"Uploaded {prog} bytes of {totalLength} bytes");
});

try
{
    // Upload the file
    var uploadResult = await fileUploadTask.UploadAsync(progress);

    Console.WriteLine(uploadResult.UploadSucceeded ?
        $"Upload complete, item ID: {uploadResult.ItemResponse.Id}" :
        "Upload failed");
}
catch (ODataError ex)
{
    Console.WriteLine($"Error uploading: {ex.Error?.Message}");
}
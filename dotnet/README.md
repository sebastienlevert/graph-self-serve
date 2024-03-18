To get a client, use the following kiota command: 

```bash
kiota generate --openapi https://aka.ms/graph/v1.0/openapi.yaml --include-path /me/messages --include-path /me --include-path /me/calendarView --include-path /me/drive --include-path /drives/{drive-id}/items/{driveItem-id} --include-path /drives/{drive-id}/items/{driveItem-id}/createUploadSession --language CSharp --class-name CustomClient --namespace-name CustomGraph.Client --output ./generated
```

This command will generate a client that can be used to interact with the Microsoft Graph API. The client will be generated in the `./generated` directory and will be named `CustomClient.cs`. The client will contain methods for interacting with the `/me/messages`, `/me`, `/me/calendarView`, `/me/drive`, and `/drives/{drive-id}` endpoints. The client will be written in C# and will be placed in the `CustomGraph.Client` namespace.
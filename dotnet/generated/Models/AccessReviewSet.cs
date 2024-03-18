// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class AccessReviewSet : Entity, IParsable {
        /// <summary>Represents the template and scheduling for an access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewScheduleDefinition>? Definitions { get; set; }
#nullable restore
#else
        public List<AccessReviewScheduleDefinition> Definitions { get; set; }
#endif
        /// <summary>Represents a collection of access review history data and the scopes used to collect that data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewHistoryDefinition>? HistoryDefinitions { get; set; }
#nullable restore
#else
        public List<AccessReviewHistoryDefinition> HistoryDefinitions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccessReviewSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definitions", n => { Definitions = n.GetCollectionOfObjectValues<AccessReviewScheduleDefinition>(AccessReviewScheduleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"historyDefinitions", n => { HistoryDefinitions = n.GetCollectionOfObjectValues<AccessReviewHistoryDefinition>(AccessReviewHistoryDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewScheduleDefinition>("definitions", Definitions);
            writer.WriteCollectionOfObjectValues<AccessReviewHistoryDefinition>("historyDefinitions", HistoryDefinitions);
        }
    }
}
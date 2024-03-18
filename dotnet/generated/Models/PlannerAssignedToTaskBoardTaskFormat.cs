// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class PlannerAssignedToTaskBoardTaskFormat : Entity, IParsable {
        /// <summary>Dictionary of hints used to order tasks on the AssignedTo view of the Task Board. The key of each entry is one of the users the task is assigned to and the value is the order hint. The format of each value is defined as outlined here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerOrderHintsByAssignee? OrderHintsByAssignee { get; set; }
#nullable restore
#else
        public PlannerOrderHintsByAssignee OrderHintsByAssignee { get; set; }
#endif
        /// <summary>Hint value used to order the task on the AssignedTo view of the Task Board when the task isn&apos;t assigned to anyone, or if the orderHintsByAssignee dictionary doesn&apos;t provide an order hint for the user the task is assigned to. The format is defined as outlined here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnassignedOrderHint { get; set; }
#nullable restore
#else
        public string UnassignedOrderHint { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlannerAssignedToTaskBoardTaskFormat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerAssignedToTaskBoardTaskFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerAssignedToTaskBoardTaskFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"orderHintsByAssignee", n => { OrderHintsByAssignee = n.GetObjectValue<PlannerOrderHintsByAssignee>(PlannerOrderHintsByAssignee.CreateFromDiscriminatorValue); } },
                {"unassignedOrderHint", n => { UnassignedOrderHint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerOrderHintsByAssignee>("orderHintsByAssignee", OrderHintsByAssignee);
            writer.WriteStringValue("unassignedOrderHint", UnassignedOrderHint);
        }
    }
}
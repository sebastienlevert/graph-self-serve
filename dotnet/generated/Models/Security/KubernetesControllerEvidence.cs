// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models.Security {
    public class KubernetesControllerEvidence : AlertEvidence, IParsable {
        /// <summary>The labels for the Kubernetes pod.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels { get; set; }
#nullable restore
#else
        public Dictionary Labels { get; set; }
#endif
        /// <summary>The controller name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The service account namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesNamespaceEvidence? Namespace { get; set; }
#nullable restore
#else
        public KubernetesNamespaceEvidence Namespace { get; set; }
#endif
        /// <summary>The controller type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KubernetesControllerEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesControllerEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesControllerEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KubernetesControllerEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesControllerEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesControllerEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"namespace", n => { Namespace = n.GetObjectValue<KubernetesNamespaceEvidence>(KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteStringValue("type", Type);
        }
    }
}
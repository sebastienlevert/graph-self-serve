// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    /// <summary>
    /// Apple device features configuration profile.
    /// </summary>
    public class AppleDeviceFeaturesConfigurationBase : DeviceConfiguration, IParsable {
        /// <summary>
        /// Instantiates a new <see cref="AppleDeviceFeaturesConfigurationBase"/> and sets the default values.
        /// </summary>
        public AppleDeviceFeaturesConfigurationBase() : base() {
            OdataType = "#microsoft.graph.appleDeviceFeaturesConfigurationBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AppleDeviceFeaturesConfigurationBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppleDeviceFeaturesConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosDeviceFeaturesConfiguration" => new IosDeviceFeaturesConfiguration(),
                "#microsoft.graph.macOSDeviceFeaturesConfiguration" => new MacOSDeviceFeaturesConfiguration(),
                _ => new AppleDeviceFeaturesConfigurationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
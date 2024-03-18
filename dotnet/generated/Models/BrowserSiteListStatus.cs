// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace CustomGraph.Client.Models {
    public enum BrowserSiteListStatus {
        /// <summary>A site list that has not yet been published</summary>
        [EnumMember(Value = "draft")]
        Draft,
        /// <summary>A site list that has been published with no pending changes.</summary>
        [EnumMember(Value = "published")]
        Published,
        /// <summary>A site that has pending changes</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shoudn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
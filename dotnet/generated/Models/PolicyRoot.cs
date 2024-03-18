// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class PolicyRoot : Entity, IParsable {
        /// <summary>The policy that controls the idle time out for web sessions for applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ActivityBasedTimeoutPolicy>? ActivityBasedTimeoutPolicies { get; set; }
#nullable restore
#else
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies { get; set; }
#endif
        /// <summary>The policy by which consent requests are created and managed for the entire tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.AdminConsentRequestPolicy? AdminConsentRequestPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
#endif
        /// <summary>The policies that enforce app management restrictions for specific applications and service principals, overriding the defaultAppManagementPolicy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppManagementPolicy>? AppManagementPolicies { get; set; }
#nullable restore
#else
        public List<AppManagementPolicy> AppManagementPolicies { get; set; }
#endif
        /// <summary>The policy configuration of the self-service sign-up experience of external users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.AuthenticationFlowsPolicy? AuthenticationFlowsPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
#endif
        /// <summary>The authentication methods and the users that are allowed to use them to sign in and perform multifactor authentication (MFA) in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.AuthenticationMethodsPolicy? AuthenticationMethodsPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
#endif
        /// <summary>The authentication method combinations that are to be used in scenarios defined by Microsoft Entra Conditional Access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationStrengthPolicy>? AuthenticationStrengthPolicies { get; set; }
#nullable restore
#else
        public List<AuthenticationStrengthPolicy> AuthenticationStrengthPolicies { get; set; }
#endif
        /// <summary>The policy that controls Microsoft Entra authorization settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.AuthorizationPolicy? AuthorizationPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.AuthorizationPolicy AuthorizationPolicy { get; set; }
#endif
        /// <summary>The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClaimsMappingPolicy>? ClaimsMappingPolicies { get; set; }
#nullable restore
#else
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
#endif
        /// <summary>The custom rules that define an access scenario.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessPolicy>? ConditionalAccessPolicies { get; set; }
#nullable restore
#else
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
#endif
        /// <summary>The custom rules that define an access scenario when interacting with external Microsoft Entra tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.CrossTenantAccessPolicy? CrossTenantAccessPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.CrossTenantAccessPolicy CrossTenantAccessPolicy { get; set; }
#endif
        /// <summary>The tenant-wide policy that enforces app management restrictions for all applications and service principals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TenantAppManagementPolicy? DefaultAppManagementPolicy { get; set; }
#nullable restore
#else
        public TenantAppManagementPolicy DefaultAppManagementPolicy { get; set; }
#endif
        /// <summary>The deviceRegistrationPolicy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.DeviceRegistrationPolicy? DeviceRegistrationPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.DeviceRegistrationPolicy DeviceRegistrationPolicy { get; set; }
#endif
        /// <summary>The feature rollout policy associated with a directory object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FeatureRolloutPolicy>? FeatureRolloutPolicies { get; set; }
#nullable restore
#else
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
#endif
        /// <summary>The policy to control Microsoft Entra authentication behavior for federated users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HomeRealmDiscoveryPolicy>? HomeRealmDiscoveryPolicies { get; set; }
#nullable restore
#else
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
#endif
        /// <summary>The policy that represents the security defaults that protect against common attacks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.IdentitySecurityDefaultsEnforcementPolicy? IdentitySecurityDefaultsEnforcementPolicy { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
#endif
        /// <summary>The policy that specifies the conditions under which consent can be granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionGrantPolicy>? PermissionGrantPolicies { get; set; }
#nullable restore
#else
        public List<PermissionGrantPolicy> PermissionGrantPolicies { get; set; }
#endif
        /// <summary>Specifies the various policies associated with scopes and roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicy>? RoleManagementPolicies { get; set; }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicy> RoleManagementPolicies { get; set; }
#endif
        /// <summary>The assignment of a role management policy to a role definition object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementPolicyAssignment>? RoleManagementPolicyAssignments { get; set; }
#nullable restore
#else
        public List<UnifiedRoleManagementPolicyAssignment> RoleManagementPolicyAssignments { get; set; }
#endif
        /// <summary>The policy that specifies the characteristics of SAML tokens issued by Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TokenIssuancePolicy>? TokenIssuancePolicies { get; set; }
#nullable restore
#else
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
#endif
        /// <summary>The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TokenLifetimePolicy>? TokenLifetimePolicies { get; set; }
#nullable restore
#else
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PolicyRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityBasedTimeoutPolicies", n => { ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>(ActivityBasedTimeoutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"adminConsentRequestPolicy", n => { AdminConsentRequestPolicy = n.GetObjectValue<CustomGraph.Client.Models.AdminConsentRequestPolicy>(CustomGraph.Client.Models.AdminConsentRequestPolicy.CreateFromDiscriminatorValue); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationFlowsPolicy", n => { AuthenticationFlowsPolicy = n.GetObjectValue<CustomGraph.Client.Models.AuthenticationFlowsPolicy>(CustomGraph.Client.Models.AuthenticationFlowsPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationMethodsPolicy", n => { AuthenticationMethodsPolicy = n.GetObjectValue<CustomGraph.Client.Models.AuthenticationMethodsPolicy>(CustomGraph.Client.Models.AuthenticationMethodsPolicy.CreateFromDiscriminatorValue); } },
                {"authenticationStrengthPolicies", n => { AuthenticationStrengthPolicies = n.GetCollectionOfObjectValues<AuthenticationStrengthPolicy>(AuthenticationStrengthPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authorizationPolicy", n => { AuthorizationPolicy = n.GetObjectValue<CustomGraph.Client.Models.AuthorizationPolicy>(CustomGraph.Client.Models.AuthorizationPolicy.CreateFromDiscriminatorValue); } },
                {"claimsMappingPolicies", n => { ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>(ClaimsMappingPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessPolicies", n => { ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"crossTenantAccessPolicy", n => { CrossTenantAccessPolicy = n.GetObjectValue<CustomGraph.Client.Models.CrossTenantAccessPolicy>(CustomGraph.Client.Models.CrossTenantAccessPolicy.CreateFromDiscriminatorValue); } },
                {"defaultAppManagementPolicy", n => { DefaultAppManagementPolicy = n.GetObjectValue<TenantAppManagementPolicy>(TenantAppManagementPolicy.CreateFromDiscriminatorValue); } },
                {"deviceRegistrationPolicy", n => { DeviceRegistrationPolicy = n.GetObjectValue<CustomGraph.Client.Models.DeviceRegistrationPolicy>(CustomGraph.Client.Models.DeviceRegistrationPolicy.CreateFromDiscriminatorValue); } },
                {"featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>(FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", n => { IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<CustomGraph.Client.Models.IdentitySecurityDefaultsEnforcementPolicy>(CustomGraph.Client.Models.IdentitySecurityDefaultsEnforcementPolicy.CreateFromDiscriminatorValue); } },
                {"permissionGrantPolicies", n => { PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>(PermissionGrantPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleManagementPolicies", n => { RoleManagementPolicies = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicy>(UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleManagementPolicyAssignments", n => { RoleManagementPolicyAssignments = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>(UnifiedRoleManagementPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActivityBasedTimeoutPolicy>("activityBasedTimeoutPolicies", ActivityBasedTimeoutPolicies);
            writer.WriteObjectValue<CustomGraph.Client.Models.AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteObjectValue<CustomGraph.Client.Models.AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<CustomGraph.Client.Models.AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteCollectionOfObjectValues<AuthenticationStrengthPolicy>("authenticationStrengthPolicies", AuthenticationStrengthPolicies);
            writer.WriteObjectValue<CustomGraph.Client.Models.AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteObjectValue<CustomGraph.Client.Models.CrossTenantAccessPolicy>("crossTenantAccessPolicy", CrossTenantAccessPolicy);
            writer.WriteObjectValue<TenantAppManagementPolicy>("defaultAppManagementPolicy", DefaultAppManagementPolicy);
            writer.WriteObjectValue<CustomGraph.Client.Models.DeviceRegistrationPolicy>("deviceRegistrationPolicy", DeviceRegistrationPolicy);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<CustomGraph.Client.Models.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicy>("roleManagementPolicies", RoleManagementPolicies);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyAssignment>("roleManagementPolicyAssignments", RoleManagementPolicyAssignments);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
        }
    }
}
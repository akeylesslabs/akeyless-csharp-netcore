/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 3.0
 * Contact: support@akeyless.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// AzureADAccessRules contains access rules specific to Azure Active Directory authentication.
    /// </summary>
    [DataContract(Name = "AzureADAccessRules")]
    public partial class AzureADAccessRules : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureADAccessRules" /> class.
        /// </summary>
        /// <param name="adEndpoint">The audience in the JWT..</param>
        /// <param name="boundGroupIds">The list of group ids that login is restricted to..</param>
        /// <param name="boundResourceGroups">The list of resource groups that login is restricted to..</param>
        /// <param name="boundResourceIds">The list of full resource ids that the login is restricted to..</param>
        /// <param name="boundResourceNames">The list of resource names that the login is restricted to (e.g, a virtual machine name, scale set name, etc)..</param>
        /// <param name="boundResourceProviders">The list of resource providers that login is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc)..</param>
        /// <param name="boundResourceTypes">The list of resource types that login is restricted to  (e.g, virtualMachines, userAssignedIdentities, etc)..</param>
        /// <param name="boundServicePrincipalIds">The list of service principal IDs that login is restricted to..</param>
        /// <param name="boundSubscriptionIds">The list of subscription IDs that login is restricted to..</param>
        /// <param name="boundTenantId">The tenants id for the Azure Active Directory organization..</param>
        /// <param name="issuer">Issuer URL.</param>
        /// <param name="jwksUri">The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server..</param>
        /// <param name="uniqueIdentifier">A unique identifier to distinguish different users.</param>
        public AzureADAccessRules(string adEndpoint = default(string), List<string> boundGroupIds = default(List<string>), List<string> boundResourceGroups = default(List<string>), List<string> boundResourceIds = default(List<string>), List<string> boundResourceNames = default(List<string>), List<string> boundResourceProviders = default(List<string>), List<string> boundResourceTypes = default(List<string>), List<string> boundServicePrincipalIds = default(List<string>), List<string> boundSubscriptionIds = default(List<string>), string boundTenantId = default(string), string issuer = default(string), string jwksUri = default(string), string uniqueIdentifier = default(string))
        {
            this.AdEndpoint = adEndpoint;
            this.BoundGroupIds = boundGroupIds;
            this.BoundResourceGroups = boundResourceGroups;
            this.BoundResourceIds = boundResourceIds;
            this.BoundResourceNames = boundResourceNames;
            this.BoundResourceProviders = boundResourceProviders;
            this.BoundResourceTypes = boundResourceTypes;
            this.BoundServicePrincipalIds = boundServicePrincipalIds;
            this.BoundSubscriptionIds = boundSubscriptionIds;
            this.BoundTenantId = boundTenantId;
            this.Issuer = issuer;
            this.JwksUri = jwksUri;
            this.UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary>
        /// The audience in the JWT.
        /// </summary>
        /// <value>The audience in the JWT.</value>
        [DataMember(Name = "ad_endpoint", EmitDefaultValue = false)]
        public string AdEndpoint { get; set; }

        /// <summary>
        /// The list of group ids that login is restricted to.
        /// </summary>
        /// <value>The list of group ids that login is restricted to.</value>
        [DataMember(Name = "bound_group_ids", EmitDefaultValue = false)]
        public List<string> BoundGroupIds { get; set; }

        /// <summary>
        /// The list of resource groups that login is restricted to.
        /// </summary>
        /// <value>The list of resource groups that login is restricted to.</value>
        [DataMember(Name = "bound_resource_groups", EmitDefaultValue = false)]
        public List<string> BoundResourceGroups { get; set; }

        /// <summary>
        /// The list of full resource ids that the login is restricted to.
        /// </summary>
        /// <value>The list of full resource ids that the login is restricted to.</value>
        [DataMember(Name = "bound_resource_ids", EmitDefaultValue = false)]
        public List<string> BoundResourceIds { get; set; }

        /// <summary>
        /// The list of resource names that the login is restricted to (e.g, a virtual machine name, scale set name, etc).
        /// </summary>
        /// <value>The list of resource names that the login is restricted to (e.g, a virtual machine name, scale set name, etc).</value>
        [DataMember(Name = "bound_resource_names", EmitDefaultValue = false)]
        public List<string> BoundResourceNames { get; set; }

        /// <summary>
        /// The list of resource providers that login is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc).
        /// </summary>
        /// <value>The list of resource providers that login is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc).</value>
        [DataMember(Name = "bound_resource_providers", EmitDefaultValue = false)]
        public List<string> BoundResourceProviders { get; set; }

        /// <summary>
        /// The list of resource types that login is restricted to  (e.g, virtualMachines, userAssignedIdentities, etc).
        /// </summary>
        /// <value>The list of resource types that login is restricted to  (e.g, virtualMachines, userAssignedIdentities, etc).</value>
        [DataMember(Name = "bound_resource_types", EmitDefaultValue = false)]
        public List<string> BoundResourceTypes { get; set; }

        /// <summary>
        /// The list of service principal IDs that login is restricted to.
        /// </summary>
        /// <value>The list of service principal IDs that login is restricted to.</value>
        [DataMember(Name = "bound_service_principal_ids", EmitDefaultValue = false)]
        public List<string> BoundServicePrincipalIds { get; set; }

        /// <summary>
        /// The list of subscription IDs that login is restricted to.
        /// </summary>
        /// <value>The list of subscription IDs that login is restricted to.</value>
        [DataMember(Name = "bound_subscription_ids", EmitDefaultValue = false)]
        public List<string> BoundSubscriptionIds { get; set; }

        /// <summary>
        /// The tenants id for the Azure Active Directory organization.
        /// </summary>
        /// <value>The tenants id for the Azure Active Directory organization.</value>
        [DataMember(Name = "bound_tenant_id", EmitDefaultValue = false)]
        public string BoundTenantId { get; set; }

        /// <summary>
        /// Issuer URL
        /// </summary>
        /// <value>Issuer URL</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.
        /// </summary>
        /// <value>The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.</value>
        [DataMember(Name = "jwks_uri", EmitDefaultValue = false)]
        public string JwksUri { get; set; }

        /// <summary>
        /// A unique identifier to distinguish different users
        /// </summary>
        /// <value>A unique identifier to distinguish different users</value>
        [DataMember(Name = "unique_identifier", EmitDefaultValue = false)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureADAccessRules {\n");
            sb.Append("  AdEndpoint: ").Append(AdEndpoint).Append("\n");
            sb.Append("  BoundGroupIds: ").Append(BoundGroupIds).Append("\n");
            sb.Append("  BoundResourceGroups: ").Append(BoundResourceGroups).Append("\n");
            sb.Append("  BoundResourceIds: ").Append(BoundResourceIds).Append("\n");
            sb.Append("  BoundResourceNames: ").Append(BoundResourceNames).Append("\n");
            sb.Append("  BoundResourceProviders: ").Append(BoundResourceProviders).Append("\n");
            sb.Append("  BoundResourceTypes: ").Append(BoundResourceTypes).Append("\n");
            sb.Append("  BoundServicePrincipalIds: ").Append(BoundServicePrincipalIds).Append("\n");
            sb.Append("  BoundSubscriptionIds: ").Append(BoundSubscriptionIds).Append("\n");
            sb.Append("  BoundTenantId: ").Append(BoundTenantId).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  JwksUri: ").Append(JwksUri).Append("\n");
            sb.Append("  UniqueIdentifier: ").Append(UniqueIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

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
    /// createAzureTarget is a command that creates a new target. [Deprecated: Use target-create-azure command]
    /// </summary>
    [DataContract(Name = "createAzureTarget")]
    public partial class CreateAzureTarget : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAzureTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAzureTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAzureTarget" /> class.
        /// </summary>
        /// <param name="clientId">Azure client/application id.</param>
        /// <param name="clientSecret">Azure client secret.</param>
        /// <param name="comment">Deprecated - use description.</param>
        /// <param name="connectionType">Type of connection [credentials/cloud-identity] (default to &quot;credentials&quot;).</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="resourceGroupName">The Resource Group name in your Azure subscription.</param>
        /// <param name="resourceName">The name of the relevant Resource.</param>
        /// <param name="subscriptionId">Azure Subscription Id.</param>
        /// <param name="tenantId">Azure tenant id.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="useGwCloudIdentity">Use the GW&#39;s Cloud IAM [Deprecated: Use connection-type&#x3D;cloud-identity].</param>
        public CreateAzureTarget(string clientId = default(string), string clientSecret = default(string), string comment = default(string), string connectionType = @"credentials", string description = default(string), bool json = false, string key = default(string), string maxVersions = default(string), string name = default(string), string resourceGroupName = default(string), string resourceName = default(string), string subscriptionId = default(string), string tenantId = default(string), string token = default(string), string uidToken = default(string), bool useGwCloudIdentity = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateAzureTarget and cannot be null");
            }
            this.Name = name;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Comment = comment;
            // use default value if no "connectionType" provided
            this.ConnectionType = connectionType ?? @"credentials";
            this.Description = description;
            this.Json = json;
            this.Key = key;
            this.MaxVersions = maxVersions;
            this.ResourceGroupName = resourceGroupName;
            this.ResourceName = resourceName;
            this.SubscriptionId = subscriptionId;
            this.TenantId = tenantId;
            this.Token = token;
            this.UidToken = uidToken;
            this.UseGwCloudIdentity = useGwCloudIdentity;
        }

        /// <summary>
        /// Azure client/application id
        /// </summary>
        /// <value>Azure client/application id</value>
        [DataMember(Name = "client-id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Azure client secret
        /// </summary>
        /// <value>Azure client secret</value>
        [DataMember(Name = "client-secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Deprecated - use description
        /// </summary>
        /// <value>Deprecated - use description</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Type of connection [credentials/cloud-identity]
        /// </summary>
        /// <value>Type of connection [credentials/cloud-identity]</value>
        [DataMember(Name = "connection-type", EmitDefaultValue = false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The Resource Group name in your Azure subscription
        /// </summary>
        /// <value>The Resource Group name in your Azure subscription</value>
        [DataMember(Name = "resource-group-name", EmitDefaultValue = false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The name of the relevant Resource
        /// </summary>
        /// <value>The name of the relevant Resource</value>
        [DataMember(Name = "resource-name", EmitDefaultValue = false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Azure Subscription Id
        /// </summary>
        /// <value>Azure Subscription Id</value>
        [DataMember(Name = "subscription-id", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Azure tenant id
        /// </summary>
        /// <value>Azure tenant id</value>
        [DataMember(Name = "tenant-id", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Use the GW&#39;s Cloud IAM [Deprecated: Use connection-type&#x3D;cloud-identity]
        /// </summary>
        /// <value>Use the GW&#39;s Cloud IAM [Deprecated: Use connection-type&#x3D;cloud-identity]</value>
        [DataMember(Name = "use-gw-cloud-identity", EmitDefaultValue = true)]
        public bool UseGwCloudIdentity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAzureTarget {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResourceGroupName: ").Append(ResourceGroupName).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UseGwCloudIdentity: ").Append(UseGwCloudIdentity).Append("\n");
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

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
    /// deleteGatewayAllowedAccessId is a command that deletes access-id
    /// </summary>
    [DataContract(Name = "deleteGatewayAllowedAccessId")]
    public partial class DeleteGatewayAllowedAccessId : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGatewayAllowedAccessId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteGatewayAllowedAccessId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGatewayAllowedAccessId" /> class.
        /// </summary>
        /// <param name="accessId">The access id to be stripped of access to gateway (required).</param>
        /// <param name="clusterName">The name of the updated cluster, e.g. acc-abcd12345678/p-123456789012/defaultCluster (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public DeleteGatewayAllowedAccessId(string accessId = default(string), string clusterName = default(string), bool json = false, string token = default(string), string uidToken = default(string))
        {
            // to ensure "accessId" is required (not null)
            if (accessId == null)
            {
                throw new ArgumentNullException("accessId is a required property for DeleteGatewayAllowedAccessId and cannot be null");
            }
            this.AccessId = accessId;
            // to ensure "clusterName" is required (not null)
            if (clusterName == null)
            {
                throw new ArgumentNullException("clusterName is a required property for DeleteGatewayAllowedAccessId and cannot be null");
            }
            this.ClusterName = clusterName;
            this.Json = json;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// The access id to be stripped of access to gateway
        /// </summary>
        /// <value>The access id to be stripped of access to gateway</value>
        [DataMember(Name = "access-id", IsRequired = true, EmitDefaultValue = true)]
        public string AccessId { get; set; }

        /// <summary>
        /// The name of the updated cluster, e.g. acc-abcd12345678/p-123456789012/defaultCluster
        /// </summary>
        /// <value>The name of the updated cluster, e.g. acc-abcd12345678/p-123456789012/defaultCluster</value>
        [DataMember(Name = "cluster-name", IsRequired = true, EmitDefaultValue = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteGatewayAllowedAccessId {\n");
            sb.Append("  AccessId: ").Append(AccessId).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
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

/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 2.0
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
    /// Responses:  default: errorResponse 200: addGatewayAllowedAccessIdResponse
    /// </summary>
    [DataContract(Name = "addGatewayAllowedAccessId")]
    public partial class AddGatewayAllowedAccessId : IEquatable<AddGatewayAllowedAccessId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddGatewayAllowedAccessId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddGatewayAllowedAccessId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddGatewayAllowedAccessId" /> class.
        /// </summary>
        /// <param name="accessId">The access id that will be able to access to gateway (required).</param>
        /// <param name="clusterName">The name of the updated cluster, e.g. acc-abcd12345678/p-123456789012/defaultCluster (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="subClaims">key/val of sub claims, e.g group&#x3D;admins,developers.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public AddGatewayAllowedAccessId(string accessId = default(string), string clusterName = default(string), bool json = false, Dictionary<string, string> subClaims = default(Dictionary<string, string>), string token = default(string), string uidToken = default(string))
        {
            // to ensure "accessId" is required (not null)
            if (accessId == null)
            {
                throw new ArgumentNullException("accessId is a required property for AddGatewayAllowedAccessId and cannot be null");
            }
            this.AccessId = accessId;
            // to ensure "clusterName" is required (not null)
            if (clusterName == null)
            {
                throw new ArgumentNullException("clusterName is a required property for AddGatewayAllowedAccessId and cannot be null");
            }
            this.ClusterName = clusterName;
            this.Json = json;
            this.SubClaims = subClaims;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// The access id that will be able to access to gateway
        /// </summary>
        /// <value>The access id that will be able to access to gateway</value>
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
        /// key/val of sub claims, e.g group&#x3D;admins,developers
        /// </summary>
        /// <value>key/val of sub claims, e.g group&#x3D;admins,developers</value>
        [DataMember(Name = "sub-claims", EmitDefaultValue = false)]
        public Dictionary<string, string> SubClaims { get; set; }

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
            sb.Append("class AddGatewayAllowedAccessId {\n");
            sb.Append("  AccessId: ").Append(AccessId).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  SubClaims: ").Append(SubClaims).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddGatewayAllowedAccessId);
        }

        /// <summary>
        /// Returns true if AddGatewayAllowedAccessId instances are equal
        /// </summary>
        /// <param name="input">Instance of AddGatewayAllowedAccessId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddGatewayAllowedAccessId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessId == input.AccessId ||
                    (this.AccessId != null &&
                    this.AccessId.Equals(input.AccessId))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.SubClaims == input.SubClaims ||
                    this.SubClaims != null &&
                    input.SubClaims != null &&
                    this.SubClaims.SequenceEqual(input.SubClaims)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccessId != null)
                {
                    hashCode = (hashCode * 59) + this.AccessId.GetHashCode();
                }
                if (this.ClusterName != null)
                {
                    hashCode = (hashCode * 59) + this.ClusterName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.SubClaims != null)
                {
                    hashCode = (hashCode * 59) + this.SubClaims.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
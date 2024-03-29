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
    /// getCloudIdentity is a command that gets Cloud Identity Token (relevant only for access-type&#x3D;azure_ad, aws_iam, gcp).
    /// </summary>
    [DataContract(Name = "getCloudIdentity")]
    public partial class GetCloudIdentity : IEquatable<GetCloudIdentity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCloudIdentity" /> class.
        /// </summary>
        /// <param name="azureAdObjectId">Azure Active Directory ObjectId (relevant only for access-type&#x3D;azure_ad).</param>
        /// <param name="debug">debug.</param>
        /// <param name="gcpAudience">GCP JWT audience.</param>
        /// <param name="json">Set output format to JSON.</param>
        /// <param name="urlSafe">Escapes the token so it can be safely placed inside a URL query.</param>
        public GetCloudIdentity(string azureAdObjectId = default(string), bool debug = default(bool), string gcpAudience = default(string), bool json = default(bool), bool urlSafe = default(bool))
        {
            this.AzureAdObjectId = azureAdObjectId;
            this.Debug = debug;
            this.GcpAudience = gcpAudience;
            this.Json = json;
            this.UrlSafe = urlSafe;
        }

        /// <summary>
        /// Azure Active Directory ObjectId (relevant only for access-type&#x3D;azure_ad)
        /// </summary>
        /// <value>Azure Active Directory ObjectId (relevant only for access-type&#x3D;azure_ad)</value>
        [DataMember(Name = "azure_ad_object_id", EmitDefaultValue = false)]
        public string AzureAdObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Debug
        /// </summary>
        [DataMember(Name = "debug", EmitDefaultValue = true)]
        public bool Debug { get; set; }

        /// <summary>
        /// GCP JWT audience
        /// </summary>
        /// <value>GCP JWT audience</value>
        [DataMember(Name = "gcp-audience", EmitDefaultValue = false)]
        public string GcpAudience { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Escapes the token so it can be safely placed inside a URL query
        /// </summary>
        /// <value>Escapes the token so it can be safely placed inside a URL query</value>
        [DataMember(Name = "url_safe", EmitDefaultValue = true)]
        public bool UrlSafe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCloudIdentity {\n");
            sb.Append("  AzureAdObjectId: ").Append(AzureAdObjectId).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  GcpAudience: ").Append(GcpAudience).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  UrlSafe: ").Append(UrlSafe).Append("\n");
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
            return this.Equals(input as GetCloudIdentity);
        }

        /// <summary>
        /// Returns true if GetCloudIdentity instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCloudIdentity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCloudIdentity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AzureAdObjectId == input.AzureAdObjectId ||
                    (this.AzureAdObjectId != null &&
                    this.AzureAdObjectId.Equals(input.AzureAdObjectId))
                ) && 
                (
                    this.Debug == input.Debug ||
                    this.Debug.Equals(input.Debug)
                ) && 
                (
                    this.GcpAudience == input.GcpAudience ||
                    (this.GcpAudience != null &&
                    this.GcpAudience.Equals(input.GcpAudience))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.UrlSafe == input.UrlSafe ||
                    this.UrlSafe.Equals(input.UrlSafe)
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
                if (this.AzureAdObjectId != null)
                    hashCode = hashCode * 59 + this.AzureAdObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Debug.GetHashCode();
                if (this.GcpAudience != null)
                    hashCode = hashCode * 59 + this.GcpAudience.GetHashCode();
                hashCode = hashCode * 59 + this.Json.GetHashCode();
                hashCode = hashCode * 59 + this.UrlSafe.GetHashCode();
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

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
    /// gwUpdateRemoteAccessSessionLogsSumologic is a command that updates session log forwarding config (sumologic target)
    /// </summary>
    [DataContract(Name = "gwUpdateRemoteAccessSessionLogsSumologic")]
    public partial class GwUpdateRemoteAccessSessionLogsSumologic : IEquatable<GwUpdateRemoteAccessSessionLogsSumologic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GwUpdateRemoteAccessSessionLogsSumologic" /> class.
        /// </summary>
        /// <param name="enable">Enable Log Forwarding [true/false] (default to &quot;true&quot;).</param>
        /// <param name="endpoint">Sumologic endpoint URL.</param>
        /// <param name="host">Sumologic host (default to &quot;use-existing&quot;).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="outputFormat">Logs format [text/json] (default to &quot;text&quot;).</param>
        /// <param name="pullInterval">Pull interval in seconds (default to &quot;10&quot;).</param>
        /// <param name="sumologicTags">A comma-separated list of Sumologic tags (default to &quot;use-existing&quot;).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public GwUpdateRemoteAccessSessionLogsSumologic(string enable = "true", string endpoint = default(string), string host = "use-existing", bool json = false, string outputFormat = "text", string pullInterval = "10", string sumologicTags = "use-existing", string token = default(string), string uidToken = default(string))
        {
            // use default value if no "enable" provided
            this.Enable = enable ?? "true";
            this.Endpoint = endpoint;
            // use default value if no "host" provided
            this.Host = host ?? "use-existing";
            this.Json = json;
            // use default value if no "outputFormat" provided
            this.OutputFormat = outputFormat ?? "text";
            // use default value if no "pullInterval" provided
            this.PullInterval = pullInterval ?? "10";
            // use default value if no "sumologicTags" provided
            this.SumologicTags = sumologicTags ?? "use-existing";
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Enable Log Forwarding [true/false]
        /// </summary>
        /// <value>Enable Log Forwarding [true/false]</value>
        [DataMember(Name = "enable", EmitDefaultValue = false)]
        public string Enable { get; set; }

        /// <summary>
        /// Sumologic endpoint URL
        /// </summary>
        /// <value>Sumologic endpoint URL</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Sumologic host
        /// </summary>
        /// <value>Sumologic host</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Logs format [text/json]
        /// </summary>
        /// <value>Logs format [text/json]</value>
        [DataMember(Name = "output-format", EmitDefaultValue = false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Pull interval in seconds
        /// </summary>
        /// <value>Pull interval in seconds</value>
        [DataMember(Name = "pull-interval", EmitDefaultValue = false)]
        public string PullInterval { get; set; }

        /// <summary>
        /// A comma-separated list of Sumologic tags
        /// </summary>
        /// <value>A comma-separated list of Sumologic tags</value>
        [DataMember(Name = "sumologic-tags", EmitDefaultValue = false)]
        public string SumologicTags { get; set; }

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
            sb.Append("class GwUpdateRemoteAccessSessionLogsSumologic {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  PullInterval: ").Append(PullInterval).Append("\n");
            sb.Append("  SumologicTags: ").Append(SumologicTags).Append("\n");
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
            return this.Equals(input as GwUpdateRemoteAccessSessionLogsSumologic);
        }

        /// <summary>
        /// Returns true if GwUpdateRemoteAccessSessionLogsSumologic instances are equal
        /// </summary>
        /// <param name="input">Instance of GwUpdateRemoteAccessSessionLogsSumologic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GwUpdateRemoteAccessSessionLogsSumologic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.OutputFormat == input.OutputFormat ||
                    (this.OutputFormat != null &&
                    this.OutputFormat.Equals(input.OutputFormat))
                ) && 
                (
                    this.PullInterval == input.PullInterval ||
                    (this.PullInterval != null &&
                    this.PullInterval.Equals(input.PullInterval))
                ) && 
                (
                    this.SumologicTags == input.SumologicTags ||
                    (this.SumologicTags != null &&
                    this.SumologicTags.Equals(input.SumologicTags))
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
                if (this.Enable != null)
                {
                    hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                }
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.OutputFormat != null)
                {
                    hashCode = (hashCode * 59) + this.OutputFormat.GetHashCode();
                }
                if (this.PullInterval != null)
                {
                    hashCode = (hashCode * 59) + this.PullInterval.GetHashCode();
                }
                if (this.SumologicTags != null)
                {
                    hashCode = (hashCode * 59) + this.SumologicTags.GetHashCode();
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
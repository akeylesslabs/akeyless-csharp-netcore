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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// DatadogForwardingConfig
    /// </summary>
    [DataContract]
    public partial class DatadogForwardingConfig :  IEquatable<DatadogForwardingConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadogForwardingConfig" /> class.
        /// </summary>
        /// <param name="datadogApiKey">datadogApiKey.</param>
        /// <param name="datadogHost">datadogHost.</param>
        /// <param name="datadogLogService">datadogLogService.</param>
        /// <param name="datadogLogSource">datadogLogSource.</param>
        /// <param name="datadogLogTags">datadogLogTags.</param>
        public DatadogForwardingConfig(string datadogApiKey = default(string), string datadogHost = default(string), string datadogLogService = default(string), string datadogLogSource = default(string), string datadogLogTags = default(string))
        {
            this.DatadogApiKey = datadogApiKey;
            this.DatadogHost = datadogHost;
            this.DatadogLogService = datadogLogService;
            this.DatadogLogSource = datadogLogSource;
            this.DatadogLogTags = datadogLogTags;
        }
        
        /// <summary>
        /// Gets or Sets DatadogApiKey
        /// </summary>
        [DataMember(Name="datadog_api_key", EmitDefaultValue=false)]
        public string DatadogApiKey { get; set; }

        /// <summary>
        /// Gets or Sets DatadogHost
        /// </summary>
        [DataMember(Name="datadog_host", EmitDefaultValue=false)]
        public string DatadogHost { get; set; }

        /// <summary>
        /// Gets or Sets DatadogLogService
        /// </summary>
        [DataMember(Name="datadog_log_service", EmitDefaultValue=false)]
        public string DatadogLogService { get; set; }

        /// <summary>
        /// Gets or Sets DatadogLogSource
        /// </summary>
        [DataMember(Name="datadog_log_source", EmitDefaultValue=false)]
        public string DatadogLogSource { get; set; }

        /// <summary>
        /// Gets or Sets DatadogLogTags
        /// </summary>
        [DataMember(Name="datadog_log_tags", EmitDefaultValue=false)]
        public string DatadogLogTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatadogForwardingConfig {\n");
            sb.Append("  DatadogApiKey: ").Append(DatadogApiKey).Append("\n");
            sb.Append("  DatadogHost: ").Append(DatadogHost).Append("\n");
            sb.Append("  DatadogLogService: ").Append(DatadogLogService).Append("\n");
            sb.Append("  DatadogLogSource: ").Append(DatadogLogSource).Append("\n");
            sb.Append("  DatadogLogTags: ").Append(DatadogLogTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatadogForwardingConfig);
        }

        /// <summary>
        /// Returns true if DatadogForwardingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadogForwardingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadogForwardingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatadogApiKey == input.DatadogApiKey ||
                    (this.DatadogApiKey != null &&
                    this.DatadogApiKey.Equals(input.DatadogApiKey))
                ) && 
                (
                    this.DatadogHost == input.DatadogHost ||
                    (this.DatadogHost != null &&
                    this.DatadogHost.Equals(input.DatadogHost))
                ) && 
                (
                    this.DatadogLogService == input.DatadogLogService ||
                    (this.DatadogLogService != null &&
                    this.DatadogLogService.Equals(input.DatadogLogService))
                ) && 
                (
                    this.DatadogLogSource == input.DatadogLogSource ||
                    (this.DatadogLogSource != null &&
                    this.DatadogLogSource.Equals(input.DatadogLogSource))
                ) && 
                (
                    this.DatadogLogTags == input.DatadogLogTags ||
                    (this.DatadogLogTags != null &&
                    this.DatadogLogTags.Equals(input.DatadogLogTags))
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
                if (this.DatadogApiKey != null)
                    hashCode = hashCode * 59 + this.DatadogApiKey.GetHashCode();
                if (this.DatadogHost != null)
                    hashCode = hashCode * 59 + this.DatadogHost.GetHashCode();
                if (this.DatadogLogService != null)
                    hashCode = hashCode * 59 + this.DatadogLogService.GetHashCode();
                if (this.DatadogLogSource != null)
                    hashCode = hashCode * 59 + this.DatadogLogSource.GetHashCode();
                if (this.DatadogLogTags != null)
                    hashCode = hashCode * 59 + this.DatadogLogTags.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
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
    /// SyslogLogForwardingConfig
    /// </summary>
    [DataContract]
    public partial class SyslogLogForwardingConfig :  IEquatable<SyslogLogForwardingConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyslogLogForwardingConfig" /> class.
        /// </summary>
        /// <param name="syslogHost">syslogHost.</param>
        /// <param name="syslogNetwork">syslogNetwork.</param>
        /// <param name="syslogTargetTag">syslogTargetTag.</param>
        public SyslogLogForwardingConfig(string syslogHost = default(string), string syslogNetwork = default(string), string syslogTargetTag = default(string))
        {
            this.SyslogHost = syslogHost;
            this.SyslogNetwork = syslogNetwork;
            this.SyslogTargetTag = syslogTargetTag;
        }
        
        /// <summary>
        /// Gets or Sets SyslogHost
        /// </summary>
        [DataMember(Name="syslog_host", EmitDefaultValue=false)]
        public string SyslogHost { get; set; }

        /// <summary>
        /// Gets or Sets SyslogNetwork
        /// </summary>
        [DataMember(Name="syslog_network", EmitDefaultValue=false)]
        public string SyslogNetwork { get; set; }

        /// <summary>
        /// Gets or Sets SyslogTargetTag
        /// </summary>
        [DataMember(Name="syslog_target_tag", EmitDefaultValue=false)]
        public string SyslogTargetTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyslogLogForwardingConfig {\n");
            sb.Append("  SyslogHost: ").Append(SyslogHost).Append("\n");
            sb.Append("  SyslogNetwork: ").Append(SyslogNetwork).Append("\n");
            sb.Append("  SyslogTargetTag: ").Append(SyslogTargetTag).Append("\n");
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
            return this.Equals(input as SyslogLogForwardingConfig);
        }

        /// <summary>
        /// Returns true if SyslogLogForwardingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of SyslogLogForwardingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyslogLogForwardingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SyslogHost == input.SyslogHost ||
                    (this.SyslogHost != null &&
                    this.SyslogHost.Equals(input.SyslogHost))
                ) && 
                (
                    this.SyslogNetwork == input.SyslogNetwork ||
                    (this.SyslogNetwork != null &&
                    this.SyslogNetwork.Equals(input.SyslogNetwork))
                ) && 
                (
                    this.SyslogTargetTag == input.SyslogTargetTag ||
                    (this.SyslogTargetTag != null &&
                    this.SyslogTargetTag.Equals(input.SyslogTargetTag))
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
                if (this.SyslogHost != null)
                    hashCode = hashCode * 59 + this.SyslogHost.GetHashCode();
                if (this.SyslogNetwork != null)
                    hashCode = hashCode * 59 + this.SyslogNetwork.GetHashCode();
                if (this.SyslogTargetTag != null)
                    hashCode = hashCode * 59 + this.SyslogTargetTag.GetHashCode();
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

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
    /// WindowsServiceAttributes
    /// </summary>
    [DataContract(Name = "WindowsServiceAttributes")]
    public partial class WindowsServiceAttributes : IEquatable<WindowsServiceAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsServiceAttributes" /> class.
        /// </summary>
        /// <param name="connectionType">connectionType.</param>
        /// <param name="port">port.</param>
        /// <param name="useTls">useTls.</param>
        public WindowsServiceAttributes(string connectionType = default(string), string port = default(string), bool useTls = default(bool))
        {
            this.ConnectionType = connectionType;
            this.Port = port;
            this.UseTls = useTls;
        }

        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        [DataMember(Name = "connection_type", EmitDefaultValue = false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public string Port { get; set; }

        /// <summary>
        /// Gets or Sets UseTls
        /// </summary>
        [DataMember(Name = "use_tls", EmitDefaultValue = true)]
        public bool UseTls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WindowsServiceAttributes {\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  UseTls: ").Append(UseTls).Append("\n");
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
            return this.Equals(input as WindowsServiceAttributes);
        }

        /// <summary>
        /// Returns true if WindowsServiceAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowsServiceAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowsServiceAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConnectionType == input.ConnectionType ||
                    (this.ConnectionType != null &&
                    this.ConnectionType.Equals(input.ConnectionType))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.UseTls == input.UseTls ||
                    this.UseTls.Equals(input.UseTls)
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
                if (this.ConnectionType != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionType.GetHashCode();
                }
                if (this.Port != null)
                {
                    hashCode = (hashCode * 59) + this.Port.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseTls.GetHashCode();
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
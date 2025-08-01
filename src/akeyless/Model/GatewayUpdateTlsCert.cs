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
    /// gatewayUpdateTlsCert is a command that updates Gateway TLS certificate
    /// </summary>
    [DataContract(Name = "GatewayUpdateTlsCert")]
    public partial class GatewayUpdateTlsCert : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayUpdateTlsCert" /> class.
        /// </summary>
        /// <param name="certData">TLS Certificate (base64 encoded).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyData">TLS Private Key (base64 encoded).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public GatewayUpdateTlsCert(string certData = default(string), bool json = false, string keyData = default(string), string token = default(string), string uidToken = default(string))
        {
            this.CertData = certData;
            this.Json = json;
            this.KeyData = keyData;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// TLS Certificate (base64 encoded)
        /// </summary>
        /// <value>TLS Certificate (base64 encoded)</value>
        [DataMember(Name = "cert-data", EmitDefaultValue = false)]
        public string CertData { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// TLS Private Key (base64 encoded)
        /// </summary>
        /// <value>TLS Private Key (base64 encoded)</value>
        [DataMember(Name = "key-data", EmitDefaultValue = false)]
        public string KeyData { get; set; }

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
            sb.Append("class GatewayUpdateTlsCert {\n");
            sb.Append("  CertData: ").Append(CertData).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyData: ").Append(KeyData).Append("\n");
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

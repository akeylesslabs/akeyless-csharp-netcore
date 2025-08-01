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
    /// SraDesktopAppConf
    /// </summary>
    [DataContract(Name = "SraDesktopAppConf")]
    public partial class SraDesktopAppConf : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SraDesktopAppConf" /> class.
        /// </summary>
        /// <param name="defaultCertIssuerId">defaultCertIssuerId.</param>
        /// <param name="secureWebAccessUrl">secureWebAccessUrl.</param>
        /// <param name="secureWebProxyUrl">secureWebProxyUrl.</param>
        public SraDesktopAppConf(long defaultCertIssuerId = default(long), string secureWebAccessUrl = default(string), string secureWebProxyUrl = default(string))
        {
            this.DefaultCertIssuerId = defaultCertIssuerId;
            this.SecureWebAccessUrl = secureWebAccessUrl;
            this.SecureWebProxyUrl = secureWebProxyUrl;
        }

        /// <summary>
        /// Gets or Sets DefaultCertIssuerId
        /// </summary>
        [DataMember(Name = "default_cert_issuer_id", EmitDefaultValue = false)]
        public long DefaultCertIssuerId { get; set; }

        /// <summary>
        /// Gets or Sets SecureWebAccessUrl
        /// </summary>
        [DataMember(Name = "secure_web_access_url", EmitDefaultValue = false)]
        public string SecureWebAccessUrl { get; set; }

        /// <summary>
        /// Gets or Sets SecureWebProxyUrl
        /// </summary>
        [DataMember(Name = "secure_web_proxy_url", EmitDefaultValue = false)]
        public string SecureWebProxyUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SraDesktopAppConf {\n");
            sb.Append("  DefaultCertIssuerId: ").Append(DefaultCertIssuerId).Append("\n");
            sb.Append("  SecureWebAccessUrl: ").Append(SecureWebAccessUrl).Append("\n");
            sb.Append("  SecureWebProxyUrl: ").Append(SecureWebProxyUrl).Append("\n");
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

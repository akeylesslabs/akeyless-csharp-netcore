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
    /// RenewCertificateOutput
    /// </summary>
    [DataContract(Name = "RenewCertificateOutput")]
    public partial class RenewCertificateOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewCertificateOutput" /> class.
        /// </summary>
        /// <param name="cert">cert.</param>
        /// <param name="certDisplayId">certDisplayId.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="parentCert">parentCert.</param>
        /// <param name="privateKey">privateKey.</param>
        /// <param name="readingToken">readingToken.</param>
        public RenewCertificateOutput(string cert = default(string), string certDisplayId = default(string), string itemId = default(string), string parentCert = default(string), string privateKey = default(string), string readingToken = default(string))
        {
            this.Cert = cert;
            this.CertDisplayId = certDisplayId;
            this.ItemId = itemId;
            this.ParentCert = parentCert;
            this.PrivateKey = privateKey;
            this.ReadingToken = readingToken;
        }

        /// <summary>
        /// Gets or Sets Cert
        /// </summary>
        [DataMember(Name = "cert", EmitDefaultValue = false)]
        public string Cert { get; set; }

        /// <summary>
        /// Gets or Sets CertDisplayId
        /// </summary>
        [DataMember(Name = "cert_display_id", EmitDefaultValue = false)]
        public string CertDisplayId { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets ParentCert
        /// </summary>
        [DataMember(Name = "parent_cert", EmitDefaultValue = false)]
        public string ParentCert { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKey
        /// </summary>
        [DataMember(Name = "private_key", EmitDefaultValue = false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Gets or Sets ReadingToken
        /// </summary>
        [DataMember(Name = "reading_token", EmitDefaultValue = false)]
        public string ReadingToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewCertificateOutput {\n");
            sb.Append("  Cert: ").Append(Cert).Append("\n");
            sb.Append("  CertDisplayId: ").Append(CertDisplayId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ParentCert: ").Append(ParentCert).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  ReadingToken: ").Append(ReadingToken).Append("\n");
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

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
    /// KubeconfigCluster
    /// </summary>
    [DataContract(Name = "KubeconfigCluster")]
    public partial class KubeconfigCluster : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubeconfigCluster" /> class.
        /// </summary>
        /// <param name="certificateAuthority">CertificateAuthority is optional and can be omitted if not used..</param>
        /// <param name="certificateAuthorityData">certificateAuthorityData.</param>
        /// <param name="server">server.</param>
        public KubeconfigCluster(string certificateAuthority = default(string), string certificateAuthorityData = default(string), string server = default(string))
        {
            this.CertificateAuthority = certificateAuthority;
            this.CertificateAuthorityData = certificateAuthorityData;
            this.Server = server;
        }

        /// <summary>
        /// CertificateAuthority is optional and can be omitted if not used.
        /// </summary>
        /// <value>CertificateAuthority is optional and can be omitted if not used.</value>
        [DataMember(Name = "certificate-authority", EmitDefaultValue = false)]
        public string CertificateAuthority { get; set; }

        /// <summary>
        /// Gets or Sets CertificateAuthorityData
        /// </summary>
        [DataMember(Name = "certificate-authority-data", EmitDefaultValue = false)]
        public string CertificateAuthorityData { get; set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name = "server", EmitDefaultValue = false)]
        public string Server { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubeconfigCluster {\n");
            sb.Append("  CertificateAuthority: ").Append(CertificateAuthority).Append("\n");
            sb.Append("  CertificateAuthorityData: ").Append(CertificateAuthorityData).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
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

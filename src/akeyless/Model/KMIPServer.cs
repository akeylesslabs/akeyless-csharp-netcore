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
    /// KMIPServer
    /// </summary>
    [DataContract(Name = "KMIPServer")]
    public partial class KMIPServer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KMIPServer" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="ca">ca.</param>
        /// <param name="certificate">certificate.</param>
        /// <param name="certificateIssueDate">certificateIssueDate.</param>
        /// <param name="certificateTtlInSeconds">certificateTtlInSeconds.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="root">root.</param>
        public KMIPServer(bool active = default(bool), List<int> ca = default(List<int>), List<int> certificate = default(List<int>), DateTime certificateIssueDate = default(DateTime), long certificateTtlInSeconds = default(long), string hostname = default(string), string root = default(string))
        {
            this.Active = active;
            this.Ca = ca;
            this.Certificate = certificate;
            this.CertificateIssueDate = certificateIssueDate;
            this.CertificateTtlInSeconds = certificateTtlInSeconds;
            this.Hostname = hostname;
            this.Root = root;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Ca
        /// </summary>
        [DataMember(Name = "ca", EmitDefaultValue = false)]
        public List<int> Ca { get; set; }

        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public List<int> Certificate { get; set; }

        /// <summary>
        /// Gets or Sets CertificateIssueDate
        /// </summary>
        [DataMember(Name = "certificate_issue_date", EmitDefaultValue = false)]
        public DateTime CertificateIssueDate { get; set; }

        /// <summary>
        /// Gets or Sets CertificateTtlInSeconds
        /// </summary>
        [DataMember(Name = "certificate_ttl_in_seconds", EmitDefaultValue = false)]
        public long CertificateTtlInSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false)]
        public string Root { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KMIPServer {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Ca: ").Append(Ca).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  CertificateIssueDate: ").Append(CertificateIssueDate).Append("\n");
            sb.Append("  CertificateTtlInSeconds: ").Append(CertificateTtlInSeconds).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
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

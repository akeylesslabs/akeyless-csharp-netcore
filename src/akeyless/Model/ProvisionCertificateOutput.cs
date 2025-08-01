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
    /// ProvisionCertificateOutput
    /// </summary>
    [DataContract(Name = "ProvisionCertificateOutput")]
    public partial class ProvisionCertificateOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionCertificateOutput" /> class.
        /// </summary>
        /// <param name="failMessage">failMessage.</param>
        /// <param name="successMessage">successMessage.</param>
        /// <param name="hostNames">hostNames.</param>
        /// <param name="provisionedAt">provisionedAt.</param>
        public ProvisionCertificateOutput(string failMessage = default(string), string successMessage = default(string), List<string> hostNames = default(List<string>), DateTime provisionedAt = default(DateTime))
        {
            this.FailMessage = failMessage;
            this.SuccessMessage = successMessage;
            this.HostNames = hostNames;
            this.ProvisionedAt = provisionedAt;
        }

        /// <summary>
        /// Gets or Sets FailMessage
        /// </summary>
        [DataMember(Name = "FailMessage", EmitDefaultValue = false)]
        public string FailMessage { get; set; }

        /// <summary>
        /// Gets or Sets SuccessMessage
        /// </summary>
        [DataMember(Name = "SuccessMessage", EmitDefaultValue = false)]
        public string SuccessMessage { get; set; }

        /// <summary>
        /// Gets or Sets HostNames
        /// </summary>
        [DataMember(Name = "host_names", EmitDefaultValue = false)]
        public List<string> HostNames { get; set; }

        /// <summary>
        /// Gets or Sets ProvisionedAt
        /// </summary>
        [DataMember(Name = "provisioned_at", EmitDefaultValue = false)]
        public DateTime ProvisionedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProvisionCertificateOutput {\n");
            sb.Append("  FailMessage: ").Append(FailMessage).Append("\n");
            sb.Append("  SuccessMessage: ").Append(SuccessMessage).Append("\n");
            sb.Append("  HostNames: ").Append(HostNames).Append("\n");
            sb.Append("  ProvisionedAt: ").Append(ProvisionedAt).Append("\n");
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

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
    /// PasswordBreachInfo
    /// </summary>
    [DataContract(Name = "PasswordBreachInfo")]
    public partial class PasswordBreachInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordBreachInfo" /> class.
        /// </summary>
        /// <param name="breachCheckDate">breachCheckDate.</param>
        /// <param name="breachCount">breachCount.</param>
        /// <param name="breachSuggestions">breachSuggestions.</param>
        /// <param name="status">status.</param>
        public PasswordBreachInfo(DateTime breachCheckDate = default(DateTime), long breachCount = default(long), List<string> breachSuggestions = default(List<string>), string status = default(string))
        {
            this.BreachCheckDate = breachCheckDate;
            this.BreachCount = breachCount;
            this.BreachSuggestions = breachSuggestions;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets BreachCheckDate
        /// </summary>
        [DataMember(Name = "breach_check_date", EmitDefaultValue = false)]
        public DateTime BreachCheckDate { get; set; }

        /// <summary>
        /// Gets or Sets BreachCount
        /// </summary>
        [DataMember(Name = "breach_count", EmitDefaultValue = false)]
        public long BreachCount { get; set; }

        /// <summary>
        /// Gets or Sets BreachSuggestions
        /// </summary>
        [DataMember(Name = "breach_suggestions", EmitDefaultValue = false)]
        public List<string> BreachSuggestions { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordBreachInfo {\n");
            sb.Append("  BreachCheckDate: ").Append(BreachCheckDate).Append("\n");
            sb.Append("  BreachCount: ").Append(BreachCount).Append("\n");
            sb.Append("  BreachSuggestions: ").Append(BreachSuggestions).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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

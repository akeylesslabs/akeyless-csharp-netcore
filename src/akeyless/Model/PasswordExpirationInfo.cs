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
    /// PasswordExpirationInfo
    /// </summary>
    [DataContract(Name = "PasswordExpirationInfo")]
    public partial class PasswordExpirationInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordExpirationInfo" /> class.
        /// </summary>
        /// <param name="daysBeforeExpire">daysBeforeExpire.</param>
        /// <param name="daysBeforeNotification">daysBeforeNotification.</param>
        /// <param name="daysUntilExpire">r/o calculated parameter.</param>
        /// <param name="enable">enable.</param>
        public PasswordExpirationInfo(long daysBeforeExpire = default(long), long daysBeforeNotification = default(long), long daysUntilExpire = default(long), bool enable = default(bool))
        {
            this.DaysBeforeExpire = daysBeforeExpire;
            this.DaysBeforeNotification = daysBeforeNotification;
            this.DaysUntilExpire = daysUntilExpire;
            this.Enable = enable;
        }

        /// <summary>
        /// Gets or Sets DaysBeforeExpire
        /// </summary>
        [DataMember(Name = "days_before_expire", EmitDefaultValue = false)]
        public long DaysBeforeExpire { get; set; }

        /// <summary>
        /// Gets or Sets DaysBeforeNotification
        /// </summary>
        [DataMember(Name = "days_before_notification", EmitDefaultValue = false)]
        public long DaysBeforeNotification { get; set; }

        /// <summary>
        /// r/o calculated parameter
        /// </summary>
        /// <value>r/o calculated parameter</value>
        [DataMember(Name = "days_until_expire", EmitDefaultValue = false)]
        public long DaysUntilExpire { get; set; }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordExpirationInfo {\n");
            sb.Append("  DaysBeforeExpire: ").Append(DaysBeforeExpire).Append("\n");
            sb.Append("  DaysBeforeNotification: ").Append(DaysBeforeNotification).Append("\n");
            sb.Append("  DaysUntilExpire: ").Append(DaysUntilExpire).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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

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
    /// AWSGatewayCloudIdentityExternalIdOpt
    /// </summary>
    [DataContract(Name = "AWSGatewayCloudIdentityExternalIdOpt")]
    public partial class AWSGatewayCloudIdentityExternalIdOpt : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AWSGatewayCloudIdentityExternalIdOpt" /> class.
        /// </summary>
        /// <param name="generatedExternalId">generatedExternalId.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="roleArn">roleArn.</param>
        public AWSGatewayCloudIdentityExternalIdOpt(string generatedExternalId = default(string), bool isEnabled = default(bool), string roleArn = default(string))
        {
            this.GeneratedExternalId = generatedExternalId;
            this.IsEnabled = isEnabled;
            this.RoleArn = roleArn;
        }

        /// <summary>
        /// Gets or Sets GeneratedExternalId
        /// </summary>
        [DataMember(Name = "generated_external_id", EmitDefaultValue = false)]
        public string GeneratedExternalId { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "is_enabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets RoleArn
        /// </summary>
        [DataMember(Name = "role_arn", EmitDefaultValue = false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AWSGatewayCloudIdentityExternalIdOpt {\n");
            sb.Append("  GeneratedExternalId: ").Append(GeneratedExternalId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
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

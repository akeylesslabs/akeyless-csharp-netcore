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
    /// GatewayDownloadCustomerFragmentsOutput
    /// </summary>
    [DataContract(Name = "gatewayDownloadCustomerFragmentsOutput")]
    public partial class GatewayDownloadCustomerFragmentsOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayDownloadCustomerFragmentsOutput" /> class.
        /// </summary>
        /// <param name="cfJson">cfJson.</param>
        public GatewayDownloadCustomerFragmentsOutput(Dictionary<string, Object> cfJson = default(Dictionary<string, Object>))
        {
            this.CfJson = cfJson;
        }

        /// <summary>
        /// Gets or Sets CfJson
        /// </summary>
        [DataMember(Name = "cf_json", EmitDefaultValue = false)]
        public Dictionary<string, Object> CfJson { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayDownloadCustomerFragmentsOutput {\n");
            sb.Append("  CfJson: ").Append(CfJson).Append("\n");
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

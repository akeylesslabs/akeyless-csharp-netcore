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
    /// BatchTokenizationRequestLine
    /// </summary>
    [DataContract(Name = "BatchTokenizationRequestLine")]
    public partial class BatchTokenizationRequestLine : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTokenizationRequestLine" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="itemId">itemId.</param>
        /// <param name="tweak">tweak.</param>
        public BatchTokenizationRequestLine(string data = default(string), long itemId = default(long), string tweak = default(string))
        {
            this.Data = data;
            this.ItemId = itemId;
            this.Tweak = tweak;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public long ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Tweak
        /// </summary>
        [DataMember(Name = "tweak", EmitDefaultValue = false)]
        public string Tweak { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchTokenizationRequestLine {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Tweak: ").Append(Tweak).Append("\n");
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

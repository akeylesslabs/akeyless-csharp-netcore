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
    /// AccessPermissionAssignment
    /// </summary>
    [DataContract(Name = "AccessPermissionAssignment")]
    public partial class AccessPermissionAssignment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionAssignment" /> class.
        /// </summary>
        /// <param name="accessId">accessId.</param>
        /// <param name="accessType">accessType.</param>
        /// <param name="subClaims">subClaims.</param>
        public AccessPermissionAssignment(string accessId = default(string), string accessType = default(string), Dictionary<string, List<string>> subClaims = default(Dictionary<string, List<string>>))
        {
            this.AccessId = accessId;
            this.AccessType = accessType;
            this.SubClaims = subClaims;
        }

        /// <summary>
        /// Gets or Sets AccessId
        /// </summary>
        [DataMember(Name = "access_id", EmitDefaultValue = false)]
        public string AccessId { get; set; }

        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name = "access_type", EmitDefaultValue = false)]
        public string AccessType { get; set; }

        /// <summary>
        /// Gets or Sets SubClaims
        /// </summary>
        [DataMember(Name = "sub_claims", EmitDefaultValue = false)]
        public Dictionary<string, List<string>> SubClaims { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessPermissionAssignment {\n");
            sb.Append("  AccessId: ").Append(AccessId).Append("\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  SubClaims: ").Append(SubClaims).Append("\n");
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

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
    /// UIDTokenDetails
    /// </summary>
    [DataContract(Name = "UIDTokenDetails")]
    public partial class UIDTokenDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UIDTokenDetails" /> class.
        /// </summary>
        /// <param name="children">children.</param>
        /// <param name="comment">comment.</param>
        /// <param name="denyInheritance">denyInheritance.</param>
        /// <param name="denyRotate">denyRotate.</param>
        /// <param name="depth">depth.</param>
        /// <param name="expiredDate">expiredDate.</param>
        /// <param name="id">id.</param>
        /// <param name="lastRotate">lastRotate.</param>
        /// <param name="revoked">revoked.</param>
        /// <param name="ttl">ttl.</param>
        public UIDTokenDetails(Dictionary<string, UIDTokenDetails> children = default(Dictionary<string, UIDTokenDetails>), string comment = default(string), bool denyInheritance = default(bool), bool denyRotate = default(bool), int depth = default(int), string expiredDate = default(string), string id = default(string), string lastRotate = default(string), bool revoked = default(bool), int ttl = default(int))
        {
            this.Children = children;
            this.Comment = comment;
            this.DenyInheritance = denyInheritance;
            this.DenyRotate = denyRotate;
            this.Depth = depth;
            this.ExpiredDate = expiredDate;
            this.Id = id;
            this.LastRotate = lastRotate;
            this.Revoked = revoked;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public Dictionary<string, UIDTokenDetails> Children { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets DenyInheritance
        /// </summary>
        [DataMember(Name = "deny_inheritance", EmitDefaultValue = true)]
        public bool DenyInheritance { get; set; }

        /// <summary>
        /// Gets or Sets DenyRotate
        /// </summary>
        [DataMember(Name = "deny_rotate", EmitDefaultValue = true)]
        public bool DenyRotate { get; set; }

        /// <summary>
        /// Gets or Sets Depth
        /// </summary>
        [DataMember(Name = "depth", EmitDefaultValue = false)]
        public int Depth { get; set; }

        /// <summary>
        /// Gets or Sets ExpiredDate
        /// </summary>
        [DataMember(Name = "expired_date", EmitDefaultValue = false)]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastRotate
        /// </summary>
        [DataMember(Name = "last_rotate", EmitDefaultValue = false)]
        public string LastRotate { get; set; }

        /// <summary>
        /// Gets or Sets Revoked
        /// </summary>
        [DataMember(Name = "revoked", EmitDefaultValue = true)]
        public bool Revoked { get; set; }

        /// <summary>
        /// Gets or Sets Ttl
        /// </summary>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UIDTokenDetails {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  DenyInheritance: ").Append(DenyInheritance).Append("\n");
            sb.Append("  DenyRotate: ").Append(DenyRotate).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  ExpiredDate: ").Append(ExpiredDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastRotate: ").Append(LastRotate).Append("\n");
            sb.Append("  Revoked: ").Append(Revoked).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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

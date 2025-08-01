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
    /// KubeconfigExec
    /// </summary>
    [DataContract(Name = "KubeconfigExec")]
    public partial class KubeconfigExec : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubeconfigExec" /> class.
        /// </summary>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="args">args.</param>
        /// <param name="command">command.</param>
        /// <param name="interactiveMode">interactiveMode.</param>
        public KubeconfigExec(string apiVersion = default(string), List<string> args = default(List<string>), string command = default(string), string interactiveMode = default(string))
        {
            this.ApiVersion = apiVersion;
            this.Args = args;
            this.Command = command;
            this.InteractiveMode = interactiveMode;
        }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name = "args", EmitDefaultValue = false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name = "command", EmitDefaultValue = false)]
        public string Command { get; set; }

        /// <summary>
        /// Gets or Sets InteractiveMode
        /// </summary>
        [DataMember(Name = "interactiveMode", EmitDefaultValue = false)]
        public string InteractiveMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubeconfigExec {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  InteractiveMode: ").Append(InteractiveMode).Append("\n");
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

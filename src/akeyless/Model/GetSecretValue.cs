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
    /// GetSecretValue
    /// </summary>
    [DataContract(Name = "GetSecretValue")]
    public partial class GetSecretValue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecretValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSecretValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecretValue" /> class.
        /// </summary>
        /// <param name="accessibility">for personal password manager (default to &quot;regular&quot;).</param>
        /// <param name="ignoreCache">Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI (default to &quot;false&quot;).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="names">Secret name (required).</param>
        /// <param name="prettyPrint">Print the secret value with json-pretty-print (not relevent to SDK).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="varVersion">Secret version, if negative value N is provided the last N versions will return (maximum 20).</param>
        public GetSecretValue(string accessibility = @"regular", string ignoreCache = @"false", bool json = false, List<string> names = default(List<string>), bool prettyPrint = default(bool), string token = default(string), string uidToken = default(string), int varVersion = default(int))
        {
            // to ensure "names" is required (not null)
            if (names == null)
            {
                throw new ArgumentNullException("names is a required property for GetSecretValue and cannot be null");
            }
            this.Names = names;
            // use default value if no "accessibility" provided
            this.Accessibility = accessibility ?? @"regular";
            // use default value if no "ignoreCache" provided
            this.IgnoreCache = ignoreCache ?? @"false";
            this.Json = json;
            this.PrettyPrint = prettyPrint;
            this.Token = token;
            this.UidToken = uidToken;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// for personal password manager
        /// </summary>
        /// <value>for personal password manager</value>
        [DataMember(Name = "accessibility", EmitDefaultValue = false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI
        /// </summary>
        /// <value>Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI</value>
        [DataMember(Name = "ignore-cache", EmitDefaultValue = false)]
        public string IgnoreCache { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Secret name
        /// </summary>
        /// <value>Secret name</value>
        [DataMember(Name = "names", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Names { get; set; }

        /// <summary>
        /// Print the secret value with json-pretty-print (not relevent to SDK)
        /// </summary>
        /// <value>Print the secret value with json-pretty-print (not relevent to SDK)</value>
        [DataMember(Name = "pretty-print", EmitDefaultValue = true)]
        public bool PrettyPrint { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Secret version, if negative value N is provided the last N versions will return (maximum 20)
        /// </summary>
        /// <value>Secret version, if negative value N is provided the last N versions will return (maximum 20)</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSecretValue {\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  IgnoreCache: ").Append(IgnoreCache).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Names: ").Append(Names).Append("\n");
            sb.Append("  PrettyPrint: ").Append(PrettyPrint).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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

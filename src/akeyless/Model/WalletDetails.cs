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
    /// WalletDetails
    /// </summary>
    [DataContract(Name = "WalletDetails")]
    public partial class WalletDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletDetails" /> class.
        /// </summary>
        /// <param name="loginType">loginType.</param>
        /// <param name="p12DataBase64">p12DataBase64.</param>
        /// <param name="ssoDataBase64">ssoDataBase64.</param>
        public WalletDetails(string loginType = default(string), string p12DataBase64 = default(string), string ssoDataBase64 = default(string))
        {
            this.LoginType = loginType;
            this.P12DataBase64 = p12DataBase64;
            this.SsoDataBase64 = ssoDataBase64;
        }

        /// <summary>
        /// Gets or Sets LoginType
        /// </summary>
        [DataMember(Name = "login_type", EmitDefaultValue = false)]
        public string LoginType { get; set; }

        /// <summary>
        /// Gets or Sets P12DataBase64
        /// </summary>
        [DataMember(Name = "p12_data_base64", EmitDefaultValue = false)]
        public string P12DataBase64 { get; set; }

        /// <summary>
        /// Gets or Sets SsoDataBase64
        /// </summary>
        [DataMember(Name = "sso_data_base64", EmitDefaultValue = false)]
        public string SsoDataBase64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletDetails {\n");
            sb.Append("  LoginType: ").Append(LoginType).Append("\n");
            sb.Append("  P12DataBase64: ").Append(P12DataBase64).Append("\n");
            sb.Append("  SsoDataBase64: ").Append(SsoDataBase64).Append("\n");
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

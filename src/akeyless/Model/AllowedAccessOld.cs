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
    /// Deprecated: AllowedAccessOld please use Gator allowed_access API structs such as AllowedAccessInput/AllowedAccess
    /// </summary>
    [DataContract(Name = "AllowedAccessOld")]
    public partial class AllowedAccessOld : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedAccessOld" /> class.
        /// </summary>
        /// <param name="accId">accId.</param>
        /// <param name="accessPermissions">accessPermissions.</param>
        /// <param name="accessRulesType">accessRulesType.</param>
        /// <param name="allowedApi">allowedApi.</param>
        /// <param name="allowedsLogin">allowedsLogin.</param>
        /// <param name="editable">editable.</param>
        /// <param name="errMsg">errMsg.</param>
        /// <param name="hash">hash.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="name">name.</param>
        /// <param name="subClaims">subClaims.</param>
        public AllowedAccessOld(string accId = default(string), List<string> accessPermissions = default(List<string>), string accessRulesType = default(string), bool allowedApi = default(bool), bool allowedsLogin = default(bool), bool editable = default(bool), string errMsg = default(string), string hash = default(string), bool isValid = default(bool), string name = default(string), Dictionary<string, List<string>> subClaims = default(Dictionary<string, List<string>>))
        {
            this.AccId = accId;
            this.AccessPermissions = accessPermissions;
            this.AccessRulesType = accessRulesType;
            this.AllowedApi = allowedApi;
            this.AllowedsLogin = allowedsLogin;
            this.Editable = editable;
            this.ErrMsg = errMsg;
            this.Hash = hash;
            this.IsValid = isValid;
            this.Name = name;
            this.SubClaims = subClaims;
        }

        /// <summary>
        /// Gets or Sets AccId
        /// </summary>
        [DataMember(Name = "acc_id", EmitDefaultValue = false)]
        public string AccId { get; set; }

        /// <summary>
        /// Gets or Sets AccessPermissions
        /// </summary>
        [DataMember(Name = "access_permissions", EmitDefaultValue = false)]
        public List<string> AccessPermissions { get; set; }

        /// <summary>
        /// Gets or Sets AccessRulesType
        /// </summary>
        [DataMember(Name = "access_rules_type", EmitDefaultValue = false)]
        public string AccessRulesType { get; set; }

        /// <summary>
        /// Gets or Sets AllowedApi
        /// </summary>
        [DataMember(Name = "allowed_api", EmitDefaultValue = true)]
        public bool AllowedApi { get; set; }

        /// <summary>
        /// Gets or Sets AllowedsLogin
        /// </summary>
        [DataMember(Name = "alloweds_login", EmitDefaultValue = true)]
        public bool AllowedsLogin { get; set; }

        /// <summary>
        /// Gets or Sets Editable
        /// </summary>
        [DataMember(Name = "editable", EmitDefaultValue = true)]
        public bool Editable { get; set; }

        /// <summary>
        /// Gets or Sets ErrMsg
        /// </summary>
        [DataMember(Name = "err_msg", EmitDefaultValue = false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "is_valid", EmitDefaultValue = true)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
            sb.Append("class AllowedAccessOld {\n");
            sb.Append("  AccId: ").Append(AccId).Append("\n");
            sb.Append("  AccessPermissions: ").Append(AccessPermissions).Append("\n");
            sb.Append("  AccessRulesType: ").Append(AccessRulesType).Append("\n");
            sb.Append("  AllowedApi: ").Append(AllowedApi).Append("\n");
            sb.Append("  AllowedsLogin: ").Append(AllowedsLogin).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  ErrMsg: ").Append(ErrMsg).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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

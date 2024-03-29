/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 2.0
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
    public partial class AllowedAccessOld : IEquatable<AllowedAccessOld>, IValidatableObject
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowedAccessOld);
        }

        /// <summary>
        /// Returns true if AllowedAccessOld instances are equal
        /// </summary>
        /// <param name="input">Instance of AllowedAccessOld to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllowedAccessOld input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccId == input.AccId ||
                    (this.AccId != null &&
                    this.AccId.Equals(input.AccId))
                ) && 
                (
                    this.AccessPermissions == input.AccessPermissions ||
                    this.AccessPermissions != null &&
                    input.AccessPermissions != null &&
                    this.AccessPermissions.SequenceEqual(input.AccessPermissions)
                ) && 
                (
                    this.AccessRulesType == input.AccessRulesType ||
                    (this.AccessRulesType != null &&
                    this.AccessRulesType.Equals(input.AccessRulesType))
                ) && 
                (
                    this.AllowedApi == input.AllowedApi ||
                    this.AllowedApi.Equals(input.AllowedApi)
                ) && 
                (
                    this.AllowedsLogin == input.AllowedsLogin ||
                    this.AllowedsLogin.Equals(input.AllowedsLogin)
                ) && 
                (
                    this.Editable == input.Editable ||
                    this.Editable.Equals(input.Editable)
                ) && 
                (
                    this.ErrMsg == input.ErrMsg ||
                    (this.ErrMsg != null &&
                    this.ErrMsg.Equals(input.ErrMsg))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubClaims == input.SubClaims ||
                    this.SubClaims != null &&
                    input.SubClaims != null &&
                    this.SubClaims.SequenceEqual(input.SubClaims)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccId != null)
                {
                    hashCode = (hashCode * 59) + this.AccId.GetHashCode();
                }
                if (this.AccessPermissions != null)
                {
                    hashCode = (hashCode * 59) + this.AccessPermissions.GetHashCode();
                }
                if (this.AccessRulesType != null)
                {
                    hashCode = (hashCode * 59) + this.AccessRulesType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowedApi.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowedsLogin.GetHashCode();
                hashCode = (hashCode * 59) + this.Editable.GetHashCode();
                if (this.ErrMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ErrMsg.GetHashCode();
                }
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsValid.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SubClaims != null)
                {
                    hashCode = (hashCode * 59) + this.SubClaims.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

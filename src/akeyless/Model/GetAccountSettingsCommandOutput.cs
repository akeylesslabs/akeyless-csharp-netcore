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
    /// GetAccountSettingsCommandOutput
    /// </summary>
    [DataContract(Name = "GetAccountSettingsCommandOutput")]
    public partial class GetAccountSettingsCommandOutput : IEquatable<GetAccountSettingsCommandOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountSettingsCommandOutput" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="address">address.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="email">email.</param>
        /// <param name="generalSettings">generalSettings.</param>
        /// <param name="objectVersionSettings">objectVersionSettings.</param>
        /// <param name="phone">phone.</param>
        /// <param name="secretManagement">secretManagement.</param>
        /// <param name="secureRemoteAccess">secureRemoteAccess.</param>
        /// <param name="systemAccessCredsSettings">systemAccessCredsSettings.</param>
        public GetAccountSettingsCommandOutput(string accountId = default(string), CustomerFullAddress address = default(CustomerFullAddress), string companyName = default(string), string email = default(string), AccountGeneralSettings generalSettings = default(AccountGeneralSettings), AccountObjectVersionSettingsOutput objectVersionSettings = default(AccountObjectVersionSettingsOutput), string phone = default(string), SmInfo secretManagement = default(SmInfo), SraInfo secureRemoteAccess = default(SraInfo), SystemAccessCredsSettings systemAccessCredsSettings = default(SystemAccessCredsSettings))
        {
            this.AccountId = accountId;
            this.Address = address;
            this.CompanyName = companyName;
            this.Email = email;
            this.GeneralSettings = generalSettings;
            this.ObjectVersionSettings = objectVersionSettings;
            this.Phone = phone;
            this.SecretManagement = secretManagement;
            this.SecureRemoteAccess = secureRemoteAccess;
            this.SystemAccessCredsSettings = systemAccessCredsSettings;
        }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public CustomerFullAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets GeneralSettings
        /// </summary>
        [DataMember(Name = "general_settings", EmitDefaultValue = false)]
        public AccountGeneralSettings GeneralSettings { get; set; }

        /// <summary>
        /// Gets or Sets ObjectVersionSettings
        /// </summary>
        [DataMember(Name = "object_version_settings", EmitDefaultValue = false)]
        public AccountObjectVersionSettingsOutput ObjectVersionSettings { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets SecretManagement
        /// </summary>
        [DataMember(Name = "secret_management", EmitDefaultValue = false)]
        public SmInfo SecretManagement { get; set; }

        /// <summary>
        /// Gets or Sets SecureRemoteAccess
        /// </summary>
        [DataMember(Name = "secure_remote_access", EmitDefaultValue = false)]
        public SraInfo SecureRemoteAccess { get; set; }

        /// <summary>
        /// Gets or Sets SystemAccessCredsSettings
        /// </summary>
        [DataMember(Name = "system_access_creds_settings", EmitDefaultValue = false)]
        public SystemAccessCredsSettings SystemAccessCredsSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAccountSettingsCommandOutput {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  GeneralSettings: ").Append(GeneralSettings).Append("\n");
            sb.Append("  ObjectVersionSettings: ").Append(ObjectVersionSettings).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  SecretManagement: ").Append(SecretManagement).Append("\n");
            sb.Append("  SecureRemoteAccess: ").Append(SecureRemoteAccess).Append("\n");
            sb.Append("  SystemAccessCredsSettings: ").Append(SystemAccessCredsSettings).Append("\n");
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
            return this.Equals(input as GetAccountSettingsCommandOutput);
        }

        /// <summary>
        /// Returns true if GetAccountSettingsCommandOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAccountSettingsCommandOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAccountSettingsCommandOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.GeneralSettings == input.GeneralSettings ||
                    (this.GeneralSettings != null &&
                    this.GeneralSettings.Equals(input.GeneralSettings))
                ) && 
                (
                    this.ObjectVersionSettings == input.ObjectVersionSettings ||
                    (this.ObjectVersionSettings != null &&
                    this.ObjectVersionSettings.Equals(input.ObjectVersionSettings))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.SecretManagement == input.SecretManagement ||
                    (this.SecretManagement != null &&
                    this.SecretManagement.Equals(input.SecretManagement))
                ) && 
                (
                    this.SecureRemoteAccess == input.SecureRemoteAccess ||
                    (this.SecureRemoteAccess != null &&
                    this.SecureRemoteAccess.Equals(input.SecureRemoteAccess))
                ) && 
                (
                    this.SystemAccessCredsSettings == input.SystemAccessCredsSettings ||
                    (this.SystemAccessCredsSettings != null &&
                    this.SystemAccessCredsSettings.Equals(input.SystemAccessCredsSettings))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.GeneralSettings != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralSettings.GetHashCode();
                }
                if (this.ObjectVersionSettings != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectVersionSettings.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.SecretManagement != null)
                {
                    hashCode = (hashCode * 59) + this.SecretManagement.GetHashCode();
                }
                if (this.SecureRemoteAccess != null)
                {
                    hashCode = (hashCode * 59) + this.SecureRemoteAccess.GetHashCode();
                }
                if (this.SystemAccessCredsSettings != null)
                {
                    hashCode = (hashCode * 59) + this.SystemAccessCredsSettings.GetHashCode();
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

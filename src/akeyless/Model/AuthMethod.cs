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
    /// AuthMethod
    /// </summary>
    [DataContract(Name = "AuthMethod")]
    public partial class AuthMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthMethod" /> class.
        /// </summary>
        /// <param name="accessDate">accessDate.</param>
        /// <param name="accessDateDisplay">accessDateDisplay.</param>
        /// <param name="accessInfo">accessInfo.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="associatedGwIds">associatedGwIds.</param>
        /// <param name="authMethodAccessId">authMethodAccessId.</param>
        /// <param name="authMethodAdditionalData">authMethodAdditionalData.</param>
        /// <param name="authMethodId">authMethodId.</param>
        /// <param name="authMethodName">authMethodName.</param>
        /// <param name="authMethodRolesAssoc">authMethodRolesAssoc.</param>
        /// <param name="clientPermissions">clientPermissions.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="deleteProtection">deleteProtection.</param>
        /// <param name="description">description.</param>
        /// <param name="expirationEvents">expirationEvents.</param>
        /// <param name="isApproved">isApproved.</param>
        /// <param name="modificationDate">modificationDate.</param>
        public AuthMethod(DateTime accessDate = default(DateTime), string accessDateDisplay = default(string), AuthMethodAccessInfo accessInfo = default(AuthMethodAccessInfo), string accountId = default(string), List<long> associatedGwIds = default(List<long>), string authMethodAccessId = default(string), AuthMethodAdditionalData authMethodAdditionalData = default(AuthMethodAdditionalData), long authMethodId = default(long), string authMethodName = default(string), List<AuthMethodRoleAssociation> authMethodRolesAssoc = default(List<AuthMethodRoleAssociation>), List<string> clientPermissions = default(List<string>), DateTime creationDate = default(DateTime), bool deleteProtection = default(bool), string description = default(string), List<AuthExpirationEvent> expirationEvents = default(List<AuthExpirationEvent>), bool isApproved = default(bool), DateTime modificationDate = default(DateTime))
        {
            this.AccessDate = accessDate;
            this.AccessDateDisplay = accessDateDisplay;
            this.AccessInfo = accessInfo;
            this.AccountId = accountId;
            this.AssociatedGwIds = associatedGwIds;
            this.AuthMethodAccessId = authMethodAccessId;
            this.AuthMethodAdditionalData = authMethodAdditionalData;
            this.AuthMethodId = authMethodId;
            this.AuthMethodName = authMethodName;
            this.AuthMethodRolesAssoc = authMethodRolesAssoc;
            this.ClientPermissions = clientPermissions;
            this.CreationDate = creationDate;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.ExpirationEvents = expirationEvents;
            this.IsApproved = isApproved;
            this.ModificationDate = modificationDate;
        }

        /// <summary>
        /// Gets or Sets AccessDate
        /// </summary>
        [DataMember(Name = "access_date", EmitDefaultValue = false)]
        public DateTime AccessDate { get; set; }

        /// <summary>
        /// Gets or Sets AccessDateDisplay
        /// </summary>
        [DataMember(Name = "access_date_display", EmitDefaultValue = false)]
        public string AccessDateDisplay { get; set; }

        /// <summary>
        /// Gets or Sets AccessInfo
        /// </summary>
        [DataMember(Name = "access_info", EmitDefaultValue = false)]
        public AuthMethodAccessInfo AccessInfo { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AssociatedGwIds
        /// </summary>
        [DataMember(Name = "associated_gw_ids", EmitDefaultValue = false)]
        public List<long> AssociatedGwIds { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethodAccessId
        /// </summary>
        [DataMember(Name = "auth_method_access_id", EmitDefaultValue = false)]
        public string AuthMethodAccessId { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethodAdditionalData
        /// </summary>
        [DataMember(Name = "auth_method_additional_data", EmitDefaultValue = false)]
        public AuthMethodAdditionalData AuthMethodAdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethodId
        /// </summary>
        [DataMember(Name = "auth_method_id", EmitDefaultValue = false)]
        public long AuthMethodId { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethodName
        /// </summary>
        [DataMember(Name = "auth_method_name", EmitDefaultValue = false)]
        public string AuthMethodName { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethodRolesAssoc
        /// </summary>
        [DataMember(Name = "auth_method_roles_assoc", EmitDefaultValue = false)]
        public List<AuthMethodRoleAssociation> AuthMethodRolesAssoc { get; set; }

        /// <summary>
        /// Gets or Sets ClientPermissions
        /// </summary>
        [DataMember(Name = "client_permissions", EmitDefaultValue = false)]
        public List<string> ClientPermissions { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creation_date", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets DeleteProtection
        /// </summary>
        [DataMember(Name = "delete_protection", EmitDefaultValue = true)]
        public bool DeleteProtection { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationEvents
        /// </summary>
        [DataMember(Name = "expiration_events", EmitDefaultValue = false)]
        public List<AuthExpirationEvent> ExpirationEvents { get; set; }

        /// <summary>
        /// Gets or Sets IsApproved
        /// </summary>
        [DataMember(Name = "is_approved", EmitDefaultValue = true)]
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or Sets ModificationDate
        /// </summary>
        [DataMember(Name = "modification_date", EmitDefaultValue = false)]
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthMethod {\n");
            sb.Append("  AccessDate: ").Append(AccessDate).Append("\n");
            sb.Append("  AccessDateDisplay: ").Append(AccessDateDisplay).Append("\n");
            sb.Append("  AccessInfo: ").Append(AccessInfo).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AssociatedGwIds: ").Append(AssociatedGwIds).Append("\n");
            sb.Append("  AuthMethodAccessId: ").Append(AuthMethodAccessId).Append("\n");
            sb.Append("  AuthMethodAdditionalData: ").Append(AuthMethodAdditionalData).Append("\n");
            sb.Append("  AuthMethodId: ").Append(AuthMethodId).Append("\n");
            sb.Append("  AuthMethodName: ").Append(AuthMethodName).Append("\n");
            sb.Append("  AuthMethodRolesAssoc: ").Append(AuthMethodRolesAssoc).Append("\n");
            sb.Append("  ClientPermissions: ").Append(ClientPermissions).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationEvents: ").Append(ExpirationEvents).Append("\n");
            sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
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

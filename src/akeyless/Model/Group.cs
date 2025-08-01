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
    /// Group
    /// </summary>
    [DataContract(Name = "Group")]
    public partial class Group : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="description">description.</param>
        /// <param name="groupAlias">groupAlias.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="isSubclaimsWithOperator">isSubclaimsWithOperator.</param>
        /// <param name="modificationDate">modificationDate.</param>
        /// <param name="userAssignments">userAssignments.</param>
        public Group(string accountId = default(string), DateTime creationDate = default(DateTime), string description = default(string), string groupAlias = default(string), string groupId = default(string), string groupName = default(string), bool isSubclaimsWithOperator = default(bool), DateTime modificationDate = default(DateTime), List<AccessPermissionAssignment> userAssignments = default(List<AccessPermissionAssignment>))
        {
            this.AccountId = accountId;
            this.CreationDate = creationDate;
            this.Description = description;
            this.GroupAlias = groupAlias;
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.IsSubclaimsWithOperator = isSubclaimsWithOperator;
            this.ModificationDate = modificationDate;
            this.UserAssignments = userAssignments;
        }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creation_date", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets GroupAlias
        /// </summary>
        [DataMember(Name = "group_alias", EmitDefaultValue = false)]
        public string GroupAlias { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name = "group_name", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets IsSubclaimsWithOperator
        /// </summary>
        [DataMember(Name = "is_subclaims_with_operator", EmitDefaultValue = true)]
        public bool IsSubclaimsWithOperator { get; set; }

        /// <summary>
        /// Gets or Sets ModificationDate
        /// </summary>
        [DataMember(Name = "modification_date", EmitDefaultValue = false)]
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Gets or Sets UserAssignments
        /// </summary>
        [DataMember(Name = "user_assignments", EmitDefaultValue = false)]
        public List<AccessPermissionAssignment> UserAssignments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GroupAlias: ").Append(GroupAlias).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  IsSubclaimsWithOperator: ").Append(IsSubclaimsWithOperator).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
            sb.Append("  UserAssignments: ").Append(UserAssignments).Append("\n");
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

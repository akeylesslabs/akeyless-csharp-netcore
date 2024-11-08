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
    /// AzureStorage
    /// </summary>
    [DataContract(Name = "AzureStorage")]
    public partial class AzureStorage : IEquatable<AzureStorage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureStorage" /> class.
        /// </summary>
        /// <param name="authType">authType.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="storageAccount">storageAccount.</param>
        /// <param name="storageContainerName">storageContainerName.</param>
        /// <param name="tenantId">creds.</param>
        public AzureStorage(string authType = default(string), string clientId = default(string), string clientSecret = default(string), string storageAccount = default(string), string storageContainerName = default(string), string tenantId = default(string))
        {
            this.AuthType = authType;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.StorageAccount = storageAccount;
            this.StorageContainerName = storageContainerName;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name = "auth_type", EmitDefaultValue = false)]
        public string AuthType { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets StorageAccount
        /// </summary>
        [DataMember(Name = "storage_account", EmitDefaultValue = false)]
        public string StorageAccount { get; set; }

        /// <summary>
        /// Gets or Sets StorageContainerName
        /// </summary>
        [DataMember(Name = "storage_container_name", EmitDefaultValue = false)]
        public string StorageContainerName { get; set; }

        /// <summary>
        /// creds
        /// </summary>
        /// <value>creds</value>
        [DataMember(Name = "tenant_id", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureStorage {\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  StorageAccount: ").Append(StorageAccount).Append("\n");
            sb.Append("  StorageContainerName: ").Append(StorageContainerName).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as AzureStorage);
        }

        /// <summary>
        /// Returns true if AzureStorage instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureStorage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureStorage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.StorageAccount == input.StorageAccount ||
                    (this.StorageAccount != null &&
                    this.StorageAccount.Equals(input.StorageAccount))
                ) && 
                (
                    this.StorageContainerName == input.StorageContainerName ||
                    (this.StorageContainerName != null &&
                    this.StorageContainerName.Equals(input.StorageContainerName))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.AuthType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthType.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }
                if (this.StorageAccount != null)
                {
                    hashCode = (hashCode * 59) + this.StorageAccount.GetHashCode();
                }
                if (this.StorageContainerName != null)
                {
                    hashCode = (hashCode * 59) + this.StorageContainerName.GetHashCode();
                }
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
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

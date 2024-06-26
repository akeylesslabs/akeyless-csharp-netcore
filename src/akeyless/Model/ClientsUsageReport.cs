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
    /// ClientsUsageReport
    /// </summary>
    [DataContract(Name = "ClientsUsageReport")]
    public partial class ClientsUsageReport : IEquatable<ClientsUsageReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientsUsageReport" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="clients">clients.</param>
        /// <param name="product">product.</param>
        /// <param name="time">time.</param>
        /// <param name="totalClients">totalClients.</param>
        public ClientsUsageReport(string accountId = default(string), List<ClientUsageInfo> clients = default(List<ClientUsageInfo>), string product = default(string), DateTime time = default(DateTime), long totalClients = default(long))
        {
            this.AccountId = accountId;
            this.Clients = clients;
            this.Product = product;
            this.Time = time;
            this.TotalClients = totalClients;
        }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Clients
        /// </summary>
        [DataMember(Name = "clients", EmitDefaultValue = false)]
        public List<ClientUsageInfo> Clients { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public string Product { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets TotalClients
        /// </summary>
        [DataMember(Name = "total_clients", EmitDefaultValue = false)]
        public long TotalClients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientsUsageReport {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TotalClients: ").Append(TotalClients).Append("\n");
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
            return this.Equals(input as ClientsUsageReport);
        }

        /// <summary>
        /// Returns true if ClientsUsageReport instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientsUsageReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientsUsageReport input)
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
                    this.Clients == input.Clients ||
                    this.Clients != null &&
                    input.Clients != null &&
                    this.Clients.SequenceEqual(input.Clients)
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.TotalClients == input.TotalClients ||
                    this.TotalClients.Equals(input.TotalClients)
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
                if (this.Clients != null)
                {
                    hashCode = (hashCode * 59) + this.Clients.GetHashCode();
                }
                if (this.Product != null)
                {
                    hashCode = (hashCode * 59) + this.Product.GetHashCode();
                }
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalClients.GetHashCode();
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

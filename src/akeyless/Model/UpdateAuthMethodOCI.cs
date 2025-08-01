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
    /// updateAuthMethodOCI is a command that updates an auth method that will be used in the account using OCI principle and groups. [Deprecated: Use auth-method-update-oci command]
    /// </summary>
    [DataContract(Name = "updateAuthMethodOCI")]
    public partial class UpdateAuthMethodOCI : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthMethodOCI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAuthMethodOCI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthMethodOCI" /> class.
        /// </summary>
        /// <param name="accessExpires">Access expiration date in Unix timestamp (select 0 for access without expiry date) (default to 0).</param>
        /// <param name="auditLogsClaims">Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot;.</param>
        /// <param name="boundIps">A CIDR whitelist with the IPs that the access is restricted to.</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Auth Method description.</param>
        /// <param name="expirationEventIn">How many days before the expiration of the auth method would you like to be notified..</param>
        /// <param name="forceSubClaims">if true: enforce role-association must include sub claims.</param>
        /// <param name="groupOcid">A list of required groups ocids (required).</param>
        /// <param name="gwBoundIps">A CIDR whitelist with the GW IPs that the access is restricted to.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="jwtTtl">Jwt TTL (default to 0).</param>
        /// <param name="name">Auth Method name (required).</param>
        /// <param name="newName">Auth Method new name.</param>
        /// <param name="productType">Choose the relevant product type for the auth method [sm, sra, pm, dp, ca].</param>
        /// <param name="tenantOcid">The Oracle Cloud tenant ID (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public UpdateAuthMethodOCI(long accessExpires = 0, List<string> auditLogsClaims = default(List<string>), List<string> boundIps = default(List<string>), string deleteProtection = default(string), string description = default(string), List<string> expirationEventIn = default(List<string>), bool forceSubClaims = default(bool), List<string> groupOcid = default(List<string>), List<string> gwBoundIps = default(List<string>), bool json = false, long jwtTtl = 0, string name = default(string), string newName = default(string), List<string> productType = default(List<string>), string tenantOcid = default(string), string token = default(string), string uidToken = default(string))
        {
            // to ensure "groupOcid" is required (not null)
            if (groupOcid == null)
            {
                throw new ArgumentNullException("groupOcid is a required property for UpdateAuthMethodOCI and cannot be null");
            }
            this.GroupOcid = groupOcid;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateAuthMethodOCI and cannot be null");
            }
            this.Name = name;
            // to ensure "tenantOcid" is required (not null)
            if (tenantOcid == null)
            {
                throw new ArgumentNullException("tenantOcid is a required property for UpdateAuthMethodOCI and cannot be null");
            }
            this.TenantOcid = tenantOcid;
            this.AccessExpires = accessExpires;
            this.AuditLogsClaims = auditLogsClaims;
            this.BoundIps = boundIps;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.ExpirationEventIn = expirationEventIn;
            this.ForceSubClaims = forceSubClaims;
            this.GwBoundIps = gwBoundIps;
            this.Json = json;
            this.JwtTtl = jwtTtl;
            this.NewName = newName;
            this.ProductType = productType;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Access expiration date in Unix timestamp (select 0 for access without expiry date)
        /// </summary>
        /// <value>Access expiration date in Unix timestamp (select 0 for access without expiry date)</value>
        [DataMember(Name = "access-expires", EmitDefaultValue = false)]
        public long AccessExpires { get; set; }

        /// <summary>
        /// Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot;
        /// </summary>
        /// <value>Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot;</value>
        [DataMember(Name = "audit-logs-claims", EmitDefaultValue = false)]
        public List<string> AuditLogsClaims { get; set; }

        /// <summary>
        /// A CIDR whitelist with the IPs that the access is restricted to
        /// </summary>
        /// <value>A CIDR whitelist with the IPs that the access is restricted to</value>
        [DataMember(Name = "bound-ips", EmitDefaultValue = false)]
        public List<string> BoundIps { get; set; }

        /// <summary>
        /// Protection from accidental deletion of this object [true/false]
        /// </summary>
        /// <value>Protection from accidental deletion of this object [true/false]</value>
        [DataMember(Name = "delete_protection", EmitDefaultValue = false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// Auth Method description
        /// </summary>
        /// <value>Auth Method description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// How many days before the expiration of the auth method would you like to be notified.
        /// </summary>
        /// <value>How many days before the expiration of the auth method would you like to be notified.</value>
        [DataMember(Name = "expiration-event-in", EmitDefaultValue = false)]
        public List<string> ExpirationEventIn { get; set; }

        /// <summary>
        /// if true: enforce role-association must include sub claims
        /// </summary>
        /// <value>if true: enforce role-association must include sub claims</value>
        [DataMember(Name = "force-sub-claims", EmitDefaultValue = true)]
        public bool ForceSubClaims { get; set; }

        /// <summary>
        /// A list of required groups ocids
        /// </summary>
        /// <value>A list of required groups ocids</value>
        [DataMember(Name = "group-ocid", IsRequired = true, EmitDefaultValue = true)]
        public List<string> GroupOcid { get; set; }

        /// <summary>
        /// A CIDR whitelist with the GW IPs that the access is restricted to
        /// </summary>
        /// <value>A CIDR whitelist with the GW IPs that the access is restricted to</value>
        [DataMember(Name = "gw-bound-ips", EmitDefaultValue = false)]
        public List<string> GwBoundIps { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Jwt TTL
        /// </summary>
        /// <value>Jwt TTL</value>
        [DataMember(Name = "jwt-ttl", EmitDefaultValue = false)]
        public long JwtTtl { get; set; }

        /// <summary>
        /// Auth Method name
        /// </summary>
        /// <value>Auth Method name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Auth Method new name
        /// </summary>
        /// <value>Auth Method new name</value>
        [DataMember(Name = "new-name", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// Choose the relevant product type for the auth method [sm, sra, pm, dp, ca]
        /// </summary>
        /// <value>Choose the relevant product type for the auth method [sm, sra, pm, dp, ca]</value>
        [DataMember(Name = "product-type", EmitDefaultValue = false)]
        public List<string> ProductType { get; set; }

        /// <summary>
        /// The Oracle Cloud tenant ID
        /// </summary>
        /// <value>The Oracle Cloud tenant ID</value>
        [DataMember(Name = "tenant-ocid", IsRequired = true, EmitDefaultValue = true)]
        public string TenantOcid { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateAuthMethodOCI {\n");
            sb.Append("  AccessExpires: ").Append(AccessExpires).Append("\n");
            sb.Append("  AuditLogsClaims: ").Append(AuditLogsClaims).Append("\n");
            sb.Append("  BoundIps: ").Append(BoundIps).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationEventIn: ").Append(ExpirationEventIn).Append("\n");
            sb.Append("  ForceSubClaims: ").Append(ForceSubClaims).Append("\n");
            sb.Append("  GroupOcid: ").Append(GroupOcid).Append("\n");
            sb.Append("  GwBoundIps: ").Append(GwBoundIps).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  JwtTtl: ").Append(JwtTtl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  TenantOcid: ").Append(TenantOcid).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
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

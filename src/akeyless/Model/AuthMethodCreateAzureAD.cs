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
    /// authMethodCreateAzureAD is a command that creates a new auth method that will be able to authenticate using Azure Active Directory credentials.
    /// </summary>
    [DataContract(Name = "authMethodCreateAzureAD")]
    public partial class AuthMethodCreateAzureAD : IEquatable<AuthMethodCreateAzureAD>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthMethodCreateAzureAD" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthMethodCreateAzureAD() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthMethodCreateAzureAD" /> class.
        /// </summary>
        /// <param name="accessExpires">Access expiration date in Unix timestamp (select 0 for access without expiry date) (default to 0).</param>
        /// <param name="audience">Deprecated (Deprecated) The audience in the JWT (default to &quot;https://management.azure.com/&quot;).</param>
        /// <param name="auditLogsClaims">Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot;.</param>
        /// <param name="boundGroupId">A list of group ids that the access is restricted to.</param>
        /// <param name="boundIps">A CIDR whitelist with the IPs that the access is restricted to.</param>
        /// <param name="boundProviders">A list of resource providers that the access is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc).</param>
        /// <param name="boundResourceId">A list of full resource ids that the access is restricted to.</param>
        /// <param name="boundResourceNames">A list of resource names that the access is restricted to (e.g, a virtual machine name, scale set name, etc)..</param>
        /// <param name="boundResourceTypes">A list of resource types that the access is restricted to (e.g, virtualMachines, userAssignedIdentities, etc).</param>
        /// <param name="boundRgId">A list of resource groups that the access is restricted to.</param>
        /// <param name="boundSpid">A list of service principal IDs that the access is restricted to.</param>
        /// <param name="boundSubId">A list of subscription ids that the access is restricted to.</param>
        /// <param name="boundTenantId">The Azure tenant id that the access is restricted to (required).</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Auth Method description.</param>
        /// <param name="forceSubClaims">if true: enforce role-association must include sub claims.</param>
        /// <param name="gwBoundIps">A CIDR whitelist with the GW IPs that the access is restricted to.</param>
        /// <param name="issuer">Issuer URL (default to &quot;https://sts.windows.net/---bound_tenant_id---&quot;).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="jwksUri">The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. (default to &quot;https://login.microsoftonline.com/common/discovery/keys&quot;).</param>
        /// <param name="jwtTtl">Jwt TTL (default to 0).</param>
        /// <param name="name">Auth Method name (required).</param>
        /// <param name="productType">Choose the relevant product type for the auth method [sm, sra, pm, dp, ca].</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="uniqueIdentifier">A unique identifier (ID) value which is a \&quot;sub claim\&quot; name that contains details uniquely identifying that resource. This \&quot;sub claim\&quot; is used to distinguish between different identities..</param>
        public AuthMethodCreateAzureAD(long accessExpires = 0, string audience = "https://management.azure.com/", List<string> auditLogsClaims = default(List<string>), List<string> boundGroupId = default(List<string>), List<string> boundIps = default(List<string>), List<string> boundProviders = default(List<string>), List<string> boundResourceId = default(List<string>), List<string> boundResourceNames = default(List<string>), List<string> boundResourceTypes = default(List<string>), List<string> boundRgId = default(List<string>), List<string> boundSpid = default(List<string>), List<string> boundSubId = default(List<string>), string boundTenantId = default(string), string deleteProtection = default(string), string description = default(string), bool forceSubClaims = default(bool), List<string> gwBoundIps = default(List<string>), string issuer = "https://sts.windows.net/---bound_tenant_id---", bool json = false, string jwksUri = "https://login.microsoftonline.com/common/discovery/keys", long jwtTtl = 0, string name = default(string), List<string> productType = default(List<string>), string token = default(string), string uidToken = default(string), string uniqueIdentifier = default(string))
        {
            // to ensure "boundTenantId" is required (not null)
            if (boundTenantId == null)
            {
                throw new ArgumentNullException("boundTenantId is a required property for AuthMethodCreateAzureAD and cannot be null");
            }
            this.BoundTenantId = boundTenantId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AuthMethodCreateAzureAD and cannot be null");
            }
            this.Name = name;
            this.AccessExpires = accessExpires;
            // use default value if no "audience" provided
            this.Audience = audience ?? "https://management.azure.com/";
            this.AuditLogsClaims = auditLogsClaims;
            this.BoundGroupId = boundGroupId;
            this.BoundIps = boundIps;
            this.BoundProviders = boundProviders;
            this.BoundResourceId = boundResourceId;
            this.BoundResourceNames = boundResourceNames;
            this.BoundResourceTypes = boundResourceTypes;
            this.BoundRgId = boundRgId;
            this.BoundSpid = boundSpid;
            this.BoundSubId = boundSubId;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.ForceSubClaims = forceSubClaims;
            this.GwBoundIps = gwBoundIps;
            // use default value if no "issuer" provided
            this.Issuer = issuer ?? "https://sts.windows.net/---bound_tenant_id---";
            this.Json = json;
            // use default value if no "jwksUri" provided
            this.JwksUri = jwksUri ?? "https://login.microsoftonline.com/common/discovery/keys";
            this.JwtTtl = jwtTtl;
            this.ProductType = productType;
            this.Token = token;
            this.UidToken = uidToken;
            this.UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary>
        /// Access expiration date in Unix timestamp (select 0 for access without expiry date)
        /// </summary>
        /// <value>Access expiration date in Unix timestamp (select 0 for access without expiry date)</value>
        [DataMember(Name = "access-expires", EmitDefaultValue = false)]
        public long AccessExpires { get; set; }

        /// <summary>
        /// Deprecated (Deprecated) The audience in the JWT
        /// </summary>
        /// <value>Deprecated (Deprecated) The audience in the JWT</value>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot;
        /// </summary>
        /// <value>Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot;</value>
        [DataMember(Name = "audit-logs-claims", EmitDefaultValue = false)]
        public List<string> AuditLogsClaims { get; set; }

        /// <summary>
        /// A list of group ids that the access is restricted to
        /// </summary>
        /// <value>A list of group ids that the access is restricted to</value>
        [DataMember(Name = "bound-group-id", EmitDefaultValue = false)]
        public List<string> BoundGroupId { get; set; }

        /// <summary>
        /// A CIDR whitelist with the IPs that the access is restricted to
        /// </summary>
        /// <value>A CIDR whitelist with the IPs that the access is restricted to</value>
        [DataMember(Name = "bound-ips", EmitDefaultValue = false)]
        public List<string> BoundIps { get; set; }

        /// <summary>
        /// A list of resource providers that the access is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc)
        /// </summary>
        /// <value>A list of resource providers that the access is restricted to (e.g, Microsoft.Compute, Microsoft.ManagedIdentity, etc)</value>
        [DataMember(Name = "bound-providers", EmitDefaultValue = false)]
        public List<string> BoundProviders { get; set; }

        /// <summary>
        /// A list of full resource ids that the access is restricted to
        /// </summary>
        /// <value>A list of full resource ids that the access is restricted to</value>
        [DataMember(Name = "bound-resource-id", EmitDefaultValue = false)]
        public List<string> BoundResourceId { get; set; }

        /// <summary>
        /// A list of resource names that the access is restricted to (e.g, a virtual machine name, scale set name, etc).
        /// </summary>
        /// <value>A list of resource names that the access is restricted to (e.g, a virtual machine name, scale set name, etc).</value>
        [DataMember(Name = "bound-resource-names", EmitDefaultValue = false)]
        public List<string> BoundResourceNames { get; set; }

        /// <summary>
        /// A list of resource types that the access is restricted to (e.g, virtualMachines, userAssignedIdentities, etc)
        /// </summary>
        /// <value>A list of resource types that the access is restricted to (e.g, virtualMachines, userAssignedIdentities, etc)</value>
        [DataMember(Name = "bound-resource-types", EmitDefaultValue = false)]
        public List<string> BoundResourceTypes { get; set; }

        /// <summary>
        /// A list of resource groups that the access is restricted to
        /// </summary>
        /// <value>A list of resource groups that the access is restricted to</value>
        [DataMember(Name = "bound-rg-id", EmitDefaultValue = false)]
        public List<string> BoundRgId { get; set; }

        /// <summary>
        /// A list of service principal IDs that the access is restricted to
        /// </summary>
        /// <value>A list of service principal IDs that the access is restricted to</value>
        [DataMember(Name = "bound-spid", EmitDefaultValue = false)]
        public List<string> BoundSpid { get; set; }

        /// <summary>
        /// A list of subscription ids that the access is restricted to
        /// </summary>
        /// <value>A list of subscription ids that the access is restricted to</value>
        [DataMember(Name = "bound-sub-id", EmitDefaultValue = false)]
        public List<string> BoundSubId { get; set; }

        /// <summary>
        /// The Azure tenant id that the access is restricted to
        /// </summary>
        /// <value>The Azure tenant id that the access is restricted to</value>
        [DataMember(Name = "bound-tenant-id", IsRequired = true, EmitDefaultValue = true)]
        public string BoundTenantId { get; set; }

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
        /// if true: enforce role-association must include sub claims
        /// </summary>
        /// <value>if true: enforce role-association must include sub claims</value>
        [DataMember(Name = "force-sub-claims", EmitDefaultValue = true)]
        public bool ForceSubClaims { get; set; }

        /// <summary>
        /// A CIDR whitelist with the GW IPs that the access is restricted to
        /// </summary>
        /// <value>A CIDR whitelist with the GW IPs that the access is restricted to</value>
        [DataMember(Name = "gw-bound-ips", EmitDefaultValue = false)]
        public List<string> GwBoundIps { get; set; }

        /// <summary>
        /// Issuer URL
        /// </summary>
        /// <value>Issuer URL</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.
        /// </summary>
        /// <value>The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.</value>
        [DataMember(Name = "jwks-uri", EmitDefaultValue = false)]
        public string JwksUri { get; set; }

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
        /// Choose the relevant product type for the auth method [sm, sra, pm, dp, ca]
        /// </summary>
        /// <value>Choose the relevant product type for the auth method [sm, sra, pm, dp, ca]</value>
        [DataMember(Name = "product-type", EmitDefaultValue = false)]
        public List<string> ProductType { get; set; }

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
        /// A unique identifier (ID) value which is a \&quot;sub claim\&quot; name that contains details uniquely identifying that resource. This \&quot;sub claim\&quot; is used to distinguish between different identities.
        /// </summary>
        /// <value>A unique identifier (ID) value which is a \&quot;sub claim\&quot; name that contains details uniquely identifying that resource. This \&quot;sub claim\&quot; is used to distinguish between different identities.</value>
        [DataMember(Name = "unique-identifier", EmitDefaultValue = false)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthMethodCreateAzureAD {\n");
            sb.Append("  AccessExpires: ").Append(AccessExpires).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  AuditLogsClaims: ").Append(AuditLogsClaims).Append("\n");
            sb.Append("  BoundGroupId: ").Append(BoundGroupId).Append("\n");
            sb.Append("  BoundIps: ").Append(BoundIps).Append("\n");
            sb.Append("  BoundProviders: ").Append(BoundProviders).Append("\n");
            sb.Append("  BoundResourceId: ").Append(BoundResourceId).Append("\n");
            sb.Append("  BoundResourceNames: ").Append(BoundResourceNames).Append("\n");
            sb.Append("  BoundResourceTypes: ").Append(BoundResourceTypes).Append("\n");
            sb.Append("  BoundRgId: ").Append(BoundRgId).Append("\n");
            sb.Append("  BoundSpid: ").Append(BoundSpid).Append("\n");
            sb.Append("  BoundSubId: ").Append(BoundSubId).Append("\n");
            sb.Append("  BoundTenantId: ").Append(BoundTenantId).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ForceSubClaims: ").Append(ForceSubClaims).Append("\n");
            sb.Append("  GwBoundIps: ").Append(GwBoundIps).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  JwksUri: ").Append(JwksUri).Append("\n");
            sb.Append("  JwtTtl: ").Append(JwtTtl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UniqueIdentifier: ").Append(UniqueIdentifier).Append("\n");
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
            return this.Equals(input as AuthMethodCreateAzureAD);
        }

        /// <summary>
        /// Returns true if AuthMethodCreateAzureAD instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthMethodCreateAzureAD to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthMethodCreateAzureAD input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessExpires == input.AccessExpires ||
                    this.AccessExpires.Equals(input.AccessExpires)
                ) && 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.AuditLogsClaims == input.AuditLogsClaims ||
                    this.AuditLogsClaims != null &&
                    input.AuditLogsClaims != null &&
                    this.AuditLogsClaims.SequenceEqual(input.AuditLogsClaims)
                ) && 
                (
                    this.BoundGroupId == input.BoundGroupId ||
                    this.BoundGroupId != null &&
                    input.BoundGroupId != null &&
                    this.BoundGroupId.SequenceEqual(input.BoundGroupId)
                ) && 
                (
                    this.BoundIps == input.BoundIps ||
                    this.BoundIps != null &&
                    input.BoundIps != null &&
                    this.BoundIps.SequenceEqual(input.BoundIps)
                ) && 
                (
                    this.BoundProviders == input.BoundProviders ||
                    this.BoundProviders != null &&
                    input.BoundProviders != null &&
                    this.BoundProviders.SequenceEqual(input.BoundProviders)
                ) && 
                (
                    this.BoundResourceId == input.BoundResourceId ||
                    this.BoundResourceId != null &&
                    input.BoundResourceId != null &&
                    this.BoundResourceId.SequenceEqual(input.BoundResourceId)
                ) && 
                (
                    this.BoundResourceNames == input.BoundResourceNames ||
                    this.BoundResourceNames != null &&
                    input.BoundResourceNames != null &&
                    this.BoundResourceNames.SequenceEqual(input.BoundResourceNames)
                ) && 
                (
                    this.BoundResourceTypes == input.BoundResourceTypes ||
                    this.BoundResourceTypes != null &&
                    input.BoundResourceTypes != null &&
                    this.BoundResourceTypes.SequenceEqual(input.BoundResourceTypes)
                ) && 
                (
                    this.BoundRgId == input.BoundRgId ||
                    this.BoundRgId != null &&
                    input.BoundRgId != null &&
                    this.BoundRgId.SequenceEqual(input.BoundRgId)
                ) && 
                (
                    this.BoundSpid == input.BoundSpid ||
                    this.BoundSpid != null &&
                    input.BoundSpid != null &&
                    this.BoundSpid.SequenceEqual(input.BoundSpid)
                ) && 
                (
                    this.BoundSubId == input.BoundSubId ||
                    this.BoundSubId != null &&
                    input.BoundSubId != null &&
                    this.BoundSubId.SequenceEqual(input.BoundSubId)
                ) && 
                (
                    this.BoundTenantId == input.BoundTenantId ||
                    (this.BoundTenantId != null &&
                    this.BoundTenantId.Equals(input.BoundTenantId))
                ) && 
                (
                    this.DeleteProtection == input.DeleteProtection ||
                    (this.DeleteProtection != null &&
                    this.DeleteProtection.Equals(input.DeleteProtection))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ForceSubClaims == input.ForceSubClaims ||
                    this.ForceSubClaims.Equals(input.ForceSubClaims)
                ) && 
                (
                    this.GwBoundIps == input.GwBoundIps ||
                    this.GwBoundIps != null &&
                    input.GwBoundIps != null &&
                    this.GwBoundIps.SequenceEqual(input.GwBoundIps)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.JwksUri == input.JwksUri ||
                    (this.JwksUri != null &&
                    this.JwksUri.Equals(input.JwksUri))
                ) && 
                (
                    this.JwtTtl == input.JwtTtl ||
                    this.JwtTtl.Equals(input.JwtTtl)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    this.ProductType != null &&
                    input.ProductType != null &&
                    this.ProductType.SequenceEqual(input.ProductType)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
                ) && 
                (
                    this.UniqueIdentifier == input.UniqueIdentifier ||
                    (this.UniqueIdentifier != null &&
                    this.UniqueIdentifier.Equals(input.UniqueIdentifier))
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
                hashCode = (hashCode * 59) + this.AccessExpires.GetHashCode();
                if (this.Audience != null)
                {
                    hashCode = (hashCode * 59) + this.Audience.GetHashCode();
                }
                if (this.AuditLogsClaims != null)
                {
                    hashCode = (hashCode * 59) + this.AuditLogsClaims.GetHashCode();
                }
                if (this.BoundGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundGroupId.GetHashCode();
                }
                if (this.BoundIps != null)
                {
                    hashCode = (hashCode * 59) + this.BoundIps.GetHashCode();
                }
                if (this.BoundProviders != null)
                {
                    hashCode = (hashCode * 59) + this.BoundProviders.GetHashCode();
                }
                if (this.BoundResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundResourceId.GetHashCode();
                }
                if (this.BoundResourceNames != null)
                {
                    hashCode = (hashCode * 59) + this.BoundResourceNames.GetHashCode();
                }
                if (this.BoundResourceTypes != null)
                {
                    hashCode = (hashCode * 59) + this.BoundResourceTypes.GetHashCode();
                }
                if (this.BoundRgId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundRgId.GetHashCode();
                }
                if (this.BoundSpid != null)
                {
                    hashCode = (hashCode * 59) + this.BoundSpid.GetHashCode();
                }
                if (this.BoundSubId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundSubId.GetHashCode();
                }
                if (this.BoundTenantId != null)
                {
                    hashCode = (hashCode * 59) + this.BoundTenantId.GetHashCode();
                }
                if (this.DeleteProtection != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteProtection.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForceSubClaims.GetHashCode();
                if (this.GwBoundIps != null)
                {
                    hashCode = (hashCode * 59) + this.GwBoundIps.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.JwksUri != null)
                {
                    hashCode = (hashCode * 59) + this.JwksUri.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JwtTtl.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ProductType != null)
                {
                    hashCode = (hashCode * 59) + this.ProductType.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                if (this.UniqueIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueIdentifier.GetHashCode();
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
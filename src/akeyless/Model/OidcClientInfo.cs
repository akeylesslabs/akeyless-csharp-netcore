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
    /// OidcClientInfo
    /// </summary>
    [DataContract(Name = "OidcClientInfo")]
    public partial class OidcClientInfo : IEquatable<OidcClientInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OidcClientInfo" /> class.
        /// </summary>
        /// <param name="accessPermissionAssignment">accessPermissionAssignment.</param>
        /// <param name="audience">audience.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="grantTypes">grantTypes.</param>
        /// <param name="issuerUrl">issuerUrl.</param>
        /// <param name="logoutUris">logoutUris.</param>
        /// <param name="_public">_public.</param>
        /// <param name="redirectUris">redirectUris.</param>
        /// <param name="responseTypes">responseTypes.</param>
        /// <param name="scopes">scopes.</param>
        public OidcClientInfo(List<AccessOrGroupPermissionAssignment> accessPermissionAssignment = default(List<AccessOrGroupPermissionAssignment>), List<string> audience = default(List<string>), string clientId = default(string), List<string> grantTypes = default(List<string>), string issuerUrl = default(string), List<string> logoutUris = default(List<string>), bool _public = default(bool), List<string> redirectUris = default(List<string>), List<string> responseTypes = default(List<string>), List<string> scopes = default(List<string>))
        {
            this.AccessPermissionAssignment = accessPermissionAssignment;
            this.Audience = audience;
            this.ClientId = clientId;
            this.GrantTypes = grantTypes;
            this.IssuerUrl = issuerUrl;
            this.LogoutUris = logoutUris;
            this.Public = _public;
            this.RedirectUris = redirectUris;
            this.ResponseTypes = responseTypes;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Gets or Sets AccessPermissionAssignment
        /// </summary>
        [DataMember(Name = "access_permission_assignment", EmitDefaultValue = false)]
        public List<AccessOrGroupPermissionAssignment> AccessPermissionAssignment { get; set; }

        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public List<string> Audience { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets GrantTypes
        /// </summary>
        [DataMember(Name = "grant_types", EmitDefaultValue = false)]
        public List<string> GrantTypes { get; set; }

        /// <summary>
        /// Gets or Sets IssuerUrl
        /// </summary>
        [DataMember(Name = "issuer_url", EmitDefaultValue = false)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Gets or Sets LogoutUris
        /// </summary>
        [DataMember(Name = "logout_uris", EmitDefaultValue = false)]
        public List<string> LogoutUris { get; set; }

        /// <summary>
        /// Gets or Sets Public
        /// </summary>
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool Public { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUris
        /// </summary>
        [DataMember(Name = "redirect_uris", EmitDefaultValue = false)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTypes
        /// </summary>
        [DataMember(Name = "response_types", EmitDefaultValue = false)]
        public List<string> ResponseTypes { get; set; }

        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OidcClientInfo {\n");
            sb.Append("  AccessPermissionAssignment: ").Append(AccessPermissionAssignment).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  GrantTypes: ").Append(GrantTypes).Append("\n");
            sb.Append("  IssuerUrl: ").Append(IssuerUrl).Append("\n");
            sb.Append("  LogoutUris: ").Append(LogoutUris).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  ResponseTypes: ").Append(ResponseTypes).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as OidcClientInfo);
        }

        /// <summary>
        /// Returns true if OidcClientInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OidcClientInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OidcClientInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessPermissionAssignment == input.AccessPermissionAssignment ||
                    this.AccessPermissionAssignment != null &&
                    input.AccessPermissionAssignment != null &&
                    this.AccessPermissionAssignment.SequenceEqual(input.AccessPermissionAssignment)
                ) && 
                (
                    this.Audience == input.Audience ||
                    this.Audience != null &&
                    input.Audience != null &&
                    this.Audience.SequenceEqual(input.Audience)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.GrantTypes == input.GrantTypes ||
                    this.GrantTypes != null &&
                    input.GrantTypes != null &&
                    this.GrantTypes.SequenceEqual(input.GrantTypes)
                ) && 
                (
                    this.IssuerUrl == input.IssuerUrl ||
                    (this.IssuerUrl != null &&
                    this.IssuerUrl.Equals(input.IssuerUrl))
                ) && 
                (
                    this.LogoutUris == input.LogoutUris ||
                    this.LogoutUris != null &&
                    input.LogoutUris != null &&
                    this.LogoutUris.SequenceEqual(input.LogoutUris)
                ) && 
                (
                    this.Public == input.Public ||
                    this.Public.Equals(input.Public)
                ) && 
                (
                    this.RedirectUris == input.RedirectUris ||
                    this.RedirectUris != null &&
                    input.RedirectUris != null &&
                    this.RedirectUris.SequenceEqual(input.RedirectUris)
                ) && 
                (
                    this.ResponseTypes == input.ResponseTypes ||
                    this.ResponseTypes != null &&
                    input.ResponseTypes != null &&
                    this.ResponseTypes.SequenceEqual(input.ResponseTypes)
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes != null &&
                    input.Scopes != null &&
                    this.Scopes.SequenceEqual(input.Scopes)
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
                if (this.AccessPermissionAssignment != null)
                {
                    hashCode = (hashCode * 59) + this.AccessPermissionAssignment.GetHashCode();
                }
                if (this.Audience != null)
                {
                    hashCode = (hashCode * 59) + this.Audience.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.GrantTypes != null)
                {
                    hashCode = (hashCode * 59) + this.GrantTypes.GetHashCode();
                }
                if (this.IssuerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerUrl.GetHashCode();
                }
                if (this.LogoutUris != null)
                {
                    hashCode = (hashCode * 59) + this.LogoutUris.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Public.GetHashCode();
                if (this.RedirectUris != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUris.GetHashCode();
                }
                if (this.ResponseTypes != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseTypes.GetHashCode();
                }
                if (this.Scopes != null)
                {
                    hashCode = (hashCode * 59) + this.Scopes.GetHashCode();
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

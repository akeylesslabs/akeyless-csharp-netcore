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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// updateAuthMethodOAuth2 is a command that updates a new auth method that will be able to authenticate using Oauth2.
    /// </summary>
    [DataContract]
    public partial class UpdateAuthMethodOAuth2 :  IEquatable<UpdateAuthMethodOAuth2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthMethodOAuth2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAuthMethodOAuth2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthMethodOAuth2" /> class.
        /// </summary>
        /// <param name="accessExpires">Access expiration date in Unix timestamp (select 0 for access without expiry date) (default to 0).</param>
        /// <param name="audience">The audience in the JWT.</param>
        /// <param name="boundClientIds">The clients ids that the access is restricted to.</param>
        /// <param name="boundIps">A CIDR whitelist with the IPs that the access is restricted to.</param>
        /// <param name="forceSubClaims">if true: enforce role-association must include sub claims.</param>
        /// <param name="issuer">Issuer URL.</param>
        /// <param name="jwksUri">The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. (required).</param>
        /// <param name="name">Auth Method name (required).</param>
        /// <param name="newName">Auth Method new name.</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="uniqueIdentifier">A unique identifier (ID) value should be configured for OAuth2, LDAP and SAML authentication method types and is usually a value such as the email, username, or upn for example. Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization. (required).</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public UpdateAuthMethodOAuth2(long accessExpires = 0, string audience = default(string), List<string> boundClientIds = default(List<string>), List<string> boundIps = default(List<string>), bool forceSubClaims = default(bool), string issuer = default(string), string jwksUri = default(string), string name = default(string), string newName = default(string), string password = default(string), string token = default(string), string uidToken = default(string), string uniqueIdentifier = default(string), string username = default(string))
        {
            // to ensure "jwksUri" is required (not null)
            this.JwksUri = jwksUri ?? throw new ArgumentNullException("jwksUri is a required property for UpdateAuthMethodOAuth2 and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UpdateAuthMethodOAuth2 and cannot be null");
            // to ensure "uniqueIdentifier" is required (not null)
            this.UniqueIdentifier = uniqueIdentifier ?? throw new ArgumentNullException("uniqueIdentifier is a required property for UpdateAuthMethodOAuth2 and cannot be null");
            this.AccessExpires = accessExpires;
            this.Audience = audience;
            this.BoundClientIds = boundClientIds;
            this.BoundIps = boundIps;
            this.ForceSubClaims = forceSubClaims;
            this.Issuer = issuer;
            this.NewName = newName;
            this.Password = password;
            this.Token = token;
            this.UidToken = uidToken;
            this.Username = username;
        }
        
        /// <summary>
        /// Access expiration date in Unix timestamp (select 0 for access without expiry date)
        /// </summary>
        /// <value>Access expiration date in Unix timestamp (select 0 for access without expiry date)</value>
        [DataMember(Name="access-expires", EmitDefaultValue=false)]
        public long AccessExpires { get; set; }

        /// <summary>
        /// The audience in the JWT
        /// </summary>
        /// <value>The audience in the JWT</value>
        [DataMember(Name="audience", EmitDefaultValue=false)]
        public string Audience { get; set; }

        /// <summary>
        /// The clients ids that the access is restricted to
        /// </summary>
        /// <value>The clients ids that the access is restricted to</value>
        [DataMember(Name="bound-client-ids", EmitDefaultValue=false)]
        public List<string> BoundClientIds { get; set; }

        /// <summary>
        /// A CIDR whitelist with the IPs that the access is restricted to
        /// </summary>
        /// <value>A CIDR whitelist with the IPs that the access is restricted to</value>
        [DataMember(Name="bound-ips", EmitDefaultValue=false)]
        public List<string> BoundIps { get; set; }

        /// <summary>
        /// if true: enforce role-association must include sub claims
        /// </summary>
        /// <value>if true: enforce role-association must include sub claims</value>
        [DataMember(Name="force-sub-claims", EmitDefaultValue=false)]
        public bool ForceSubClaims { get; set; }

        /// <summary>
        /// Issuer URL
        /// </summary>
        /// <value>Issuer URL</value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.
        /// </summary>
        /// <value>The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.</value>
        [DataMember(Name="jwks-uri", EmitDefaultValue=false)]
        public string JwksUri { get; set; }

        /// <summary>
        /// Auth Method name
        /// </summary>
        /// <value>Auth Method name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Auth Method new name
        /// </summary>
        /// <value>Auth Method new name</value>
        [DataMember(Name="new-name", EmitDefaultValue=false)]
        public string NewName { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name="uid-token", EmitDefaultValue=false)]
        public string UidToken { get; set; }

        /// <summary>
        /// A unique identifier (ID) value should be configured for OAuth2, LDAP and SAML authentication method types and is usually a value such as the email, username, or upn for example. Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization.
        /// </summary>
        /// <value>A unique identifier (ID) value should be configured for OAuth2, LDAP and SAML authentication method types and is usually a value such as the email, username, or upn for example. Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization.</value>
        [DataMember(Name="unique-identifier", EmitDefaultValue=false)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAuthMethodOAuth2 {\n");
            sb.Append("  AccessExpires: ").Append(AccessExpires).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  BoundClientIds: ").Append(BoundClientIds).Append("\n");
            sb.Append("  BoundIps: ").Append(BoundIps).Append("\n");
            sb.Append("  ForceSubClaims: ").Append(ForceSubClaims).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  JwksUri: ").Append(JwksUri).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UniqueIdentifier: ").Append(UniqueIdentifier).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAuthMethodOAuth2);
        }

        /// <summary>
        /// Returns true if UpdateAuthMethodOAuth2 instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAuthMethodOAuth2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAuthMethodOAuth2 input)
        {
            if (input == null)
                return false;

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
                    this.BoundClientIds == input.BoundClientIds ||
                    this.BoundClientIds != null &&
                    input.BoundClientIds != null &&
                    this.BoundClientIds.SequenceEqual(input.BoundClientIds)
                ) && 
                (
                    this.BoundIps == input.BoundIps ||
                    this.BoundIps != null &&
                    input.BoundIps != null &&
                    this.BoundIps.SequenceEqual(input.BoundIps)
                ) && 
                (
                    this.ForceSubClaims == input.ForceSubClaims ||
                    this.ForceSubClaims.Equals(input.ForceSubClaims)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.JwksUri == input.JwksUri ||
                    (this.JwksUri != null &&
                    this.JwksUri.Equals(input.JwksUri))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                hashCode = hashCode * 59 + this.AccessExpires.GetHashCode();
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.BoundClientIds != null)
                    hashCode = hashCode * 59 + this.BoundClientIds.GetHashCode();
                if (this.BoundIps != null)
                    hashCode = hashCode * 59 + this.BoundIps.GetHashCode();
                hashCode = hashCode * 59 + this.ForceSubClaims.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.JwksUri != null)
                    hashCode = hashCode * 59 + this.JwksUri.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewName != null)
                    hashCode = hashCode * 59 + this.NewName.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UidToken != null)
                    hashCode = hashCode * 59 + this.UidToken.GetHashCode();
                if (this.UniqueIdentifier != null)
                    hashCode = hashCode * 59 + this.UniqueIdentifier.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
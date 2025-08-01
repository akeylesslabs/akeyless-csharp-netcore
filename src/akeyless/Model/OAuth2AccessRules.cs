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
    /// OAuth2AccessRules contains access rules specific to OAuth2 authentication method.
    /// </summary>
    [DataContract(Name = "OAuth2AccessRules")]
    public partial class OAuth2AccessRules : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AccessRules" /> class.
        /// </summary>
        /// <param name="audience">The audience in the JWT..</param>
        /// <param name="authorizedGwClusterName">The gateway cluster name that is authorized to access JWKeySetURL.</param>
        /// <param name="boundClaims">The claims that login is restricted to..</param>
        /// <param name="boundClientsId">The clients ids that login is restricted to..</param>
        /// <param name="certificate">Certificate to use when calling jwks_uri from the gateway. in PEM format.</param>
        /// <param name="issuer">Issuer URL.</param>
        /// <param name="jwksJsonData">The JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. base64 encoded string.</param>
        /// <param name="jwksUri">The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server..</param>
        /// <param name="uniqueIdentifier">A unique identifier to distinguish different users.</param>
        public OAuth2AccessRules(string audience = default(string), string authorizedGwClusterName = default(string), List<OAuth2CustomClaim> boundClaims = default(List<OAuth2CustomClaim>), List<string> boundClientsId = default(List<string>), string certificate = default(string), string issuer = default(string), string jwksJsonData = default(string), string jwksUri = default(string), string uniqueIdentifier = default(string))
        {
            this.Audience = audience;
            this.AuthorizedGwClusterName = authorizedGwClusterName;
            this.BoundClaims = boundClaims;
            this.BoundClientsId = boundClientsId;
            this.Certificate = certificate;
            this.Issuer = issuer;
            this.JwksJsonData = jwksJsonData;
            this.JwksUri = jwksUri;
            this.UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary>
        /// The audience in the JWT.
        /// </summary>
        /// <value>The audience in the JWT.</value>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// The gateway cluster name that is authorized to access JWKeySetURL
        /// </summary>
        /// <value>The gateway cluster name that is authorized to access JWKeySetURL</value>
        [DataMember(Name = "authorized_gw_cluster_name", EmitDefaultValue = false)]
        public string AuthorizedGwClusterName { get; set; }

        /// <summary>
        /// The claims that login is restricted to.
        /// </summary>
        /// <value>The claims that login is restricted to.</value>
        [DataMember(Name = "bound_claims", EmitDefaultValue = false)]
        public List<OAuth2CustomClaim> BoundClaims { get; set; }

        /// <summary>
        /// The clients ids that login is restricted to.
        /// </summary>
        /// <value>The clients ids that login is restricted to.</value>
        [DataMember(Name = "bound_clients_id", EmitDefaultValue = false)]
        public List<string> BoundClientsId { get; set; }

        /// <summary>
        /// Certificate to use when calling jwks_uri from the gateway. in PEM format
        /// </summary>
        /// <value>Certificate to use when calling jwks_uri from the gateway. in PEM format</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Issuer URL
        /// </summary>
        /// <value>Issuer URL</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. base64 encoded string
        /// </summary>
        /// <value>The JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. base64 encoded string</value>
        [DataMember(Name = "jwks_json_data", EmitDefaultValue = false)]
        public string JwksJsonData { get; set; }

        /// <summary>
        /// The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.
        /// </summary>
        /// <value>The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server.</value>
        [DataMember(Name = "jwks_uri", EmitDefaultValue = false)]
        public string JwksUri { get; set; }

        /// <summary>
        /// A unique identifier to distinguish different users
        /// </summary>
        /// <value>A unique identifier to distinguish different users</value>
        [DataMember(Name = "unique_identifier", EmitDefaultValue = false)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuth2AccessRules {\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  AuthorizedGwClusterName: ").Append(AuthorizedGwClusterName).Append("\n");
            sb.Append("  BoundClaims: ").Append(BoundClaims).Append("\n");
            sb.Append("  BoundClientsId: ").Append(BoundClientsId).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  JwksJsonData: ").Append(JwksJsonData).Append("\n");
            sb.Append("  JwksUri: ").Append(JwksUri).Append("\n");
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

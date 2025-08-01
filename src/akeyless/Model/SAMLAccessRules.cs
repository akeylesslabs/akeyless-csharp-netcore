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
    /// SAMLAccessRules
    /// </summary>
    [DataContract(Name = "SAMLAccessRules")]
    public partial class SAMLAccessRules : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SAMLAccessRules" /> class.
        /// </summary>
        /// <param name="allowedRedirectURIs">Allowed redirect URIs after the authentication.</param>
        /// <param name="boundAttributes">The attributes that login is restricted to..</param>
        /// <param name="idpMetadataUrl">IDP metadata url.</param>
        /// <param name="idpMetadataXml">IDP metadata XML.</param>
        /// <param name="uniqueIdentifier">A unique identifier to distinguish different users.</param>
        public SAMLAccessRules(List<string> allowedRedirectURIs = default(List<string>), List<SAMLAttribute> boundAttributes = default(List<SAMLAttribute>), string idpMetadataUrl = default(string), string idpMetadataXml = default(string), string uniqueIdentifier = default(string))
        {
            this.AllowedRedirectURIs = allowedRedirectURIs;
            this.BoundAttributes = boundAttributes;
            this.IdpMetadataUrl = idpMetadataUrl;
            this.IdpMetadataXml = idpMetadataXml;
            this.UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary>
        /// Allowed redirect URIs after the authentication
        /// </summary>
        /// <value>Allowed redirect URIs after the authentication</value>
        [DataMember(Name = "allowed_redirect_URIs", EmitDefaultValue = false)]
        public List<string> AllowedRedirectURIs { get; set; }

        /// <summary>
        /// The attributes that login is restricted to.
        /// </summary>
        /// <value>The attributes that login is restricted to.</value>
        [DataMember(Name = "bound_attributes", EmitDefaultValue = false)]
        public List<SAMLAttribute> BoundAttributes { get; set; }

        /// <summary>
        /// IDP metadata url
        /// </summary>
        /// <value>IDP metadata url</value>
        [DataMember(Name = "idp_metadata_url", EmitDefaultValue = false)]
        public string IdpMetadataUrl { get; set; }

        /// <summary>
        /// IDP metadata XML
        /// </summary>
        /// <value>IDP metadata XML</value>
        [DataMember(Name = "idp_metadata_xml", EmitDefaultValue = false)]
        public string IdpMetadataXml { get; set; }

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
            sb.Append("class SAMLAccessRules {\n");
            sb.Append("  AllowedRedirectURIs: ").Append(AllowedRedirectURIs).Append("\n");
            sb.Append("  BoundAttributes: ").Append(BoundAttributes).Append("\n");
            sb.Append("  IdpMetadataUrl: ").Append(IdpMetadataUrl).Append("\n");
            sb.Append("  IdpMetadataXml: ").Append(IdpMetadataXml).Append("\n");
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

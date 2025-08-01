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
    /// KMIPConfigPart
    /// </summary>
    [DataContract(Name = "KMIPConfigPart")]
    public partial class KMIPConfigPart : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KMIPConfigPart" /> class.
        /// </summary>
        /// <param name="clients">clients.</param>
        /// <param name="keyEnc">Saves the private key of the cert issuer in encypted form.</param>
        /// <param name="server">server.</param>
        /// <param name="serverEnc">Saved for backward compatibility TODO: remove this after all clients upgrade.</param>
        public KMIPConfigPart(Dictionary<string, KMIPClient> clients = default(Dictionary<string, KMIPClient>), List<int> keyEnc = default(List<int>), KMIPServer server = default(KMIPServer), List<int> serverEnc = default(List<int>))
        {
            this.Clients = clients;
            this.KeyEnc = keyEnc;
            this.Server = server;
            this.ServerEnc = serverEnc;
        }

        /// <summary>
        /// Gets or Sets Clients
        /// </summary>
        [DataMember(Name = "clients", EmitDefaultValue = false)]
        public Dictionary<string, KMIPClient> Clients { get; set; }

        /// <summary>
        /// Saves the private key of the cert issuer in encypted form
        /// </summary>
        /// <value>Saves the private key of the cert issuer in encypted form</value>
        [DataMember(Name = "key_enc", EmitDefaultValue = false)]
        public List<int> KeyEnc { get; set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name = "server", EmitDefaultValue = false)]
        public KMIPServer Server { get; set; }

        /// <summary>
        /// Saved for backward compatibility TODO: remove this after all clients upgrade
        /// </summary>
        /// <value>Saved for backward compatibility TODO: remove this after all clients upgrade</value>
        [DataMember(Name = "server_enc", EmitDefaultValue = false)]
        public List<int> ServerEnc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KMIPConfigPart {\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
            sb.Append("  KeyEnc: ").Append(KeyEnc).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  ServerEnc: ").Append(ServerEnc).Append("\n");
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

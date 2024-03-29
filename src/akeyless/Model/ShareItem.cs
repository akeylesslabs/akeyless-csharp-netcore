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
    /// ShareItem
    /// </summary>
    [DataContract(Name = "shareItem")]
    public partial class ShareItem : IEquatable<ShareItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShareItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareItem" /> class.
        /// </summary>
        /// <param name="accessibility">for personal password manager (default to &quot;regular&quot;).</param>
        /// <param name="action">Action to be performed on the item [start/stop/describe] (required).</param>
        /// <param name="emails">For Password Management use, reflect the website context.</param>
        /// <param name="itemName">Item name (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="ttl">TTL of the Availability of the shared secret in seconds.</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="viewOnce">ViewOnlyOnce Shared secrets can only be viewed once [true/false] (default to false).</param>
        public ShareItem(string accessibility = "regular", string action = default(string), List<string> emails = default(List<string>), string itemName = default(string), bool json = false, string token = default(string), int ttl = default(int), string uidToken = default(string), bool viewOnce = false)
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for ShareItem and cannot be null");
            }
            this.Action = action;
            // to ensure "itemName" is required (not null)
            if (itemName == null)
            {
                throw new ArgumentNullException("itemName is a required property for ShareItem and cannot be null");
            }
            this.ItemName = itemName;
            // use default value if no "accessibility" provided
            this.Accessibility = accessibility ?? "regular";
            this.Emails = emails;
            this.Json = json;
            this.Token = token;
            this.Ttl = ttl;
            this.UidToken = uidToken;
            this.ViewOnce = viewOnce;
        }

        /// <summary>
        /// for personal password manager
        /// </summary>
        /// <value>for personal password manager</value>
        [DataMember(Name = "accessibility", EmitDefaultValue = false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Action to be performed on the item [start/stop/describe]
        /// </summary>
        /// <value>Action to be performed on the item [start/stop/describe]</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// For Password Management use, reflect the website context
        /// </summary>
        /// <value>For Password Management use, reflect the website context</value>
        [DataMember(Name = "emails", EmitDefaultValue = false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        /// <value>Item name</value>
        [DataMember(Name = "item-name", IsRequired = true, EmitDefaultValue = true)]
        public string ItemName { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// TTL of the Availability of the shared secret in seconds
        /// </summary>
        /// <value>TTL of the Availability of the shared secret in seconds</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// ViewOnlyOnce Shared secrets can only be viewed once [true/false]
        /// </summary>
        /// <value>ViewOnlyOnce Shared secrets can only be viewed once [true/false]</value>
        [DataMember(Name = "view-once", EmitDefaultValue = true)]
        public bool ViewOnce { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShareItem {\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  ViewOnce: ").Append(ViewOnce).Append("\n");
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
            return this.Equals(input as ShareItem);
        }

        /// <summary>
        /// Returns true if ShareItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accessibility == input.Accessibility ||
                    (this.Accessibility != null &&
                    this.Accessibility.Equals(input.Accessibility))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
                ) && 
                (
                    this.ViewOnce == input.ViewOnce ||
                    this.ViewOnce.Equals(input.ViewOnce)
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
                if (this.Accessibility != null)
                {
                    hashCode = (hashCode * 59) + this.Accessibility.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ViewOnce.GetHashCode();
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

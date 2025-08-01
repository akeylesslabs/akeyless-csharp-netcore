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
    /// gatewayUpdateLogForwardingSyslog is a command that updates log forwarding config (syslog target)
    /// </summary>
    [DataContract(Name = "gatewayUpdateLogForwardingSyslog")]
    public partial class GatewayUpdateLogForwardingSyslog : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayUpdateLogForwardingSyslog" /> class.
        /// </summary>
        /// <param name="enable">Enable Log Forwarding [true/false] (default to &quot;true&quot;).</param>
        /// <param name="enableTls">Enable tls relevant only for network type TCP.</param>
        /// <param name="formatter">Syslog formatter [text/cef] (default to &quot;text&quot;).</param>
        /// <param name="host">Syslog host.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="network">Syslog network [tcp/udp] (default to &quot;tcp&quot;).</param>
        /// <param name="outputFormat">Logs format [text/json] (default to &quot;text&quot;).</param>
        /// <param name="pullInterval">Pull interval in seconds (default to &quot;10&quot;).</param>
        /// <param name="targetTag">Syslog target tag (default to &quot;use-existing&quot;).</param>
        /// <param name="tlsCertificate">Syslog tls certificate (default to &quot;use-existing&quot;).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public GatewayUpdateLogForwardingSyslog(string enable = @"true", bool enableTls = default(bool), string formatter = @"text", string host = default(string), bool json = false, string network = @"tcp", string outputFormat = @"text", string pullInterval = @"10", string targetTag = @"use-existing", string tlsCertificate = @"use-existing", string token = default(string), string uidToken = default(string))
        {
            // use default value if no "enable" provided
            this.Enable = enable ?? @"true";
            this.EnableTls = enableTls;
            // use default value if no "formatter" provided
            this.Formatter = formatter ?? @"text";
            this.Host = host;
            this.Json = json;
            // use default value if no "network" provided
            this.Network = network ?? @"tcp";
            // use default value if no "outputFormat" provided
            this.OutputFormat = outputFormat ?? @"text";
            // use default value if no "pullInterval" provided
            this.PullInterval = pullInterval ?? @"10";
            // use default value if no "targetTag" provided
            this.TargetTag = targetTag ?? @"use-existing";
            // use default value if no "tlsCertificate" provided
            this.TlsCertificate = tlsCertificate ?? @"use-existing";
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Enable Log Forwarding [true/false]
        /// </summary>
        /// <value>Enable Log Forwarding [true/false]</value>
        [DataMember(Name = "enable", EmitDefaultValue = false)]
        public string Enable { get; set; }

        /// <summary>
        /// Enable tls relevant only for network type TCP
        /// </summary>
        /// <value>Enable tls relevant only for network type TCP</value>
        [DataMember(Name = "enable-tls", EmitDefaultValue = true)]
        public bool EnableTls { get; set; }

        /// <summary>
        /// Syslog formatter [text/cef]
        /// </summary>
        /// <value>Syslog formatter [text/cef]</value>
        [DataMember(Name = "formatter", EmitDefaultValue = false)]
        public string Formatter { get; set; }

        /// <summary>
        /// Syslog host
        /// </summary>
        /// <value>Syslog host</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Syslog network [tcp/udp]
        /// </summary>
        /// <value>Syslog network [tcp/udp]</value>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Logs format [text/json]
        /// </summary>
        /// <value>Logs format [text/json]</value>
        [DataMember(Name = "output-format", EmitDefaultValue = false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Pull interval in seconds
        /// </summary>
        /// <value>Pull interval in seconds</value>
        [DataMember(Name = "pull-interval", EmitDefaultValue = false)]
        public string PullInterval { get; set; }

        /// <summary>
        /// Syslog target tag
        /// </summary>
        /// <value>Syslog target tag</value>
        [DataMember(Name = "target-tag", EmitDefaultValue = false)]
        public string TargetTag { get; set; }

        /// <summary>
        /// Syslog tls certificate
        /// </summary>
        /// <value>Syslog tls certificate</value>
        [DataMember(Name = "tls-certificate", EmitDefaultValue = false)]
        public string TlsCertificate { get; set; }

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
            sb.Append("class GatewayUpdateLogForwardingSyslog {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  EnableTls: ").Append(EnableTls).Append("\n");
            sb.Append("  Formatter: ").Append(Formatter).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  PullInterval: ").Append(PullInterval).Append("\n");
            sb.Append("  TargetTag: ").Append(TargetTag).Append("\n");
            sb.Append("  TlsCertificate: ").Append(TlsCertificate).Append("\n");
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

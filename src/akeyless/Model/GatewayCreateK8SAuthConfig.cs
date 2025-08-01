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
    /// gatewayCreateK8SAuth is a command that creates k8s auth config
    /// </summary>
    [DataContract(Name = "gatewayCreateK8SAuthConfig")]
    public partial class GatewayCreateK8SAuthConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateK8SAuthConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateK8SAuthConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateK8SAuthConfig" /> class.
        /// </summary>
        /// <param name="accessId">The access ID of the Kubernetes auth method (required).</param>
        /// <param name="clusterApiType">Cluster access type. options: [native_k8s, rancher] (default to &quot;native_k8s&quot;).</param>
        /// <param name="disableIssuerValidation">Disable issuer validation [true/false].</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="k8sAuthType">K8S auth type [token/certificate]. (relevant for \&quot;native_k8s\&quot; only) (default to &quot;token&quot;).</param>
        /// <param name="k8sCaCert">The CA Certificate (base64 encoded) to use to call into the kubernetes API server.</param>
        /// <param name="k8sClientCertificate">Content of the k8 client certificate (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only).</param>
        /// <param name="k8sClientKey">Content of the k8 client private key (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only).</param>
        /// <param name="k8sHost">The URL of the kubernetes API server (required).</param>
        /// <param name="k8sIssuer">The Kubernetes JWT issuer name. K8SIssuer is the claim that specifies who issued the Kubernetes token (default to &quot;kubernetes/serviceaccount&quot;).</param>
        /// <param name="name">K8S Auth config name (required).</param>
        /// <param name="rancherApiKey">The api key used to access the TokenReview API to validate other JWTs (relevant for \&quot;rancher\&quot; only).</param>
        /// <param name="rancherClusterId">The cluster id as define in rancher (relevant for \&quot;rancher\&quot; only).</param>
        /// <param name="signingKey">The private key (base64 encoded) associated with the public key defined in the Kubernetes auth (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="tokenExp">Time in seconds of expiration of the Akeyless Kube Auth Method token (default to 300).</param>
        /// <param name="tokenReviewerJwt">A Kubernetes service account JWT used to access the TokenReview API to validate other JWTs (relevant for \&quot;native_k8s\&quot; only). If not set, the JWT submitted in the authentication process will be used to access the Kubernetes TokenReview API..</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="useGwServiceAccount">Use the GW&#39;s service account.</param>
        public GatewayCreateK8SAuthConfig(string accessId = default(string), string clusterApiType = @"native_k8s", string disableIssuerValidation = default(string), bool json = false, string k8sAuthType = @"token", string k8sCaCert = default(string), string k8sClientCertificate = default(string), string k8sClientKey = default(string), string k8sHost = default(string), string k8sIssuer = @"kubernetes/serviceaccount", string name = default(string), string rancherApiKey = default(string), string rancherClusterId = default(string), string signingKey = default(string), string token = default(string), long tokenExp = 300, string tokenReviewerJwt = default(string), string uidToken = default(string), bool useGwServiceAccount = default(bool))
        {
            // to ensure "accessId" is required (not null)
            if (accessId == null)
            {
                throw new ArgumentNullException("accessId is a required property for GatewayCreateK8SAuthConfig and cannot be null");
            }
            this.AccessId = accessId;
            // to ensure "k8sHost" is required (not null)
            if (k8sHost == null)
            {
                throw new ArgumentNullException("k8sHost is a required property for GatewayCreateK8SAuthConfig and cannot be null");
            }
            this.K8sHost = k8sHost;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GatewayCreateK8SAuthConfig and cannot be null");
            }
            this.Name = name;
            // to ensure "signingKey" is required (not null)
            if (signingKey == null)
            {
                throw new ArgumentNullException("signingKey is a required property for GatewayCreateK8SAuthConfig and cannot be null");
            }
            this.SigningKey = signingKey;
            // use default value if no "clusterApiType" provided
            this.ClusterApiType = clusterApiType ?? @"native_k8s";
            this.DisableIssuerValidation = disableIssuerValidation;
            this.Json = json;
            // use default value if no "k8sAuthType" provided
            this.K8sAuthType = k8sAuthType ?? @"token";
            this.K8sCaCert = k8sCaCert;
            this.K8sClientCertificate = k8sClientCertificate;
            this.K8sClientKey = k8sClientKey;
            // use default value if no "k8sIssuer" provided
            this.K8sIssuer = k8sIssuer ?? @"kubernetes/serviceaccount";
            this.RancherApiKey = rancherApiKey;
            this.RancherClusterId = rancherClusterId;
            this.Token = token;
            this.TokenExp = tokenExp;
            this.TokenReviewerJwt = tokenReviewerJwt;
            this.UidToken = uidToken;
            this.UseGwServiceAccount = useGwServiceAccount;
        }

        /// <summary>
        /// The access ID of the Kubernetes auth method
        /// </summary>
        /// <value>The access ID of the Kubernetes auth method</value>
        [DataMember(Name = "access-id", IsRequired = true, EmitDefaultValue = true)]
        public string AccessId { get; set; }

        /// <summary>
        /// Cluster access type. options: [native_k8s, rancher]
        /// </summary>
        /// <value>Cluster access type. options: [native_k8s, rancher]</value>
        [DataMember(Name = "cluster-api-type", EmitDefaultValue = false)]
        public string ClusterApiType { get; set; }

        /// <summary>
        /// Disable issuer validation [true/false]
        /// </summary>
        /// <value>Disable issuer validation [true/false]</value>
        [DataMember(Name = "disable-issuer-validation", EmitDefaultValue = false)]
        public string DisableIssuerValidation { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// K8S auth type [token/certificate]. (relevant for \&quot;native_k8s\&quot; only)
        /// </summary>
        /// <value>K8S auth type [token/certificate]. (relevant for \&quot;native_k8s\&quot; only)</value>
        [DataMember(Name = "k8s-auth-type", EmitDefaultValue = false)]
        public string K8sAuthType { get; set; }

        /// <summary>
        /// The CA Certificate (base64 encoded) to use to call into the kubernetes API server
        /// </summary>
        /// <value>The CA Certificate (base64 encoded) to use to call into the kubernetes API server</value>
        [DataMember(Name = "k8s-ca-cert", EmitDefaultValue = false)]
        public string K8sCaCert { get; set; }

        /// <summary>
        /// Content of the k8 client certificate (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only)
        /// </summary>
        /// <value>Content of the k8 client certificate (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only)</value>
        [DataMember(Name = "k8s-client-certificate", EmitDefaultValue = false)]
        public string K8sClientCertificate { get; set; }

        /// <summary>
        /// Content of the k8 client private key (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only)
        /// </summary>
        /// <value>Content of the k8 client private key (PEM format) in a Base64 format (relevant for \&quot;native_k8s\&quot; only)</value>
        [DataMember(Name = "k8s-client-key", EmitDefaultValue = false)]
        public string K8sClientKey { get; set; }

        /// <summary>
        /// The URL of the kubernetes API server
        /// </summary>
        /// <value>The URL of the kubernetes API server</value>
        [DataMember(Name = "k8s-host", IsRequired = true, EmitDefaultValue = true)]
        public string K8sHost { get; set; }

        /// <summary>
        /// The Kubernetes JWT issuer name. K8SIssuer is the claim that specifies who issued the Kubernetes token
        /// </summary>
        /// <value>The Kubernetes JWT issuer name. K8SIssuer is the claim that specifies who issued the Kubernetes token</value>
        [DataMember(Name = "k8s-issuer", EmitDefaultValue = false)]
        public string K8sIssuer { get; set; }

        /// <summary>
        /// K8S Auth config name
        /// </summary>
        /// <value>K8S Auth config name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The api key used to access the TokenReview API to validate other JWTs (relevant for \&quot;rancher\&quot; only)
        /// </summary>
        /// <value>The api key used to access the TokenReview API to validate other JWTs (relevant for \&quot;rancher\&quot; only)</value>
        [DataMember(Name = "rancher-api-key", EmitDefaultValue = false)]
        public string RancherApiKey { get; set; }

        /// <summary>
        /// The cluster id as define in rancher (relevant for \&quot;rancher\&quot; only)
        /// </summary>
        /// <value>The cluster id as define in rancher (relevant for \&quot;rancher\&quot; only)</value>
        [DataMember(Name = "rancher-cluster-id", EmitDefaultValue = false)]
        public string RancherClusterId { get; set; }

        /// <summary>
        /// The private key (base64 encoded) associated with the public key defined in the Kubernetes auth
        /// </summary>
        /// <value>The private key (base64 encoded) associated with the public key defined in the Kubernetes auth</value>
        [DataMember(Name = "signing-key", IsRequired = true, EmitDefaultValue = true)]
        public string SigningKey { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Time in seconds of expiration of the Akeyless Kube Auth Method token
        /// </summary>
        /// <value>Time in seconds of expiration of the Akeyless Kube Auth Method token</value>
        [DataMember(Name = "token-exp", EmitDefaultValue = false)]
        public long TokenExp { get; set; }

        /// <summary>
        /// A Kubernetes service account JWT used to access the TokenReview API to validate other JWTs (relevant for \&quot;native_k8s\&quot; only). If not set, the JWT submitted in the authentication process will be used to access the Kubernetes TokenReview API.
        /// </summary>
        /// <value>A Kubernetes service account JWT used to access the TokenReview API to validate other JWTs (relevant for \&quot;native_k8s\&quot; only). If not set, the JWT submitted in the authentication process will be used to access the Kubernetes TokenReview API.</value>
        [DataMember(Name = "token-reviewer-jwt", EmitDefaultValue = false)]
        public string TokenReviewerJwt { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Use the GW&#39;s service account
        /// </summary>
        /// <value>Use the GW&#39;s service account</value>
        [DataMember(Name = "use-gw-service-account", EmitDefaultValue = true)]
        public bool UseGwServiceAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayCreateK8SAuthConfig {\n");
            sb.Append("  AccessId: ").Append(AccessId).Append("\n");
            sb.Append("  ClusterApiType: ").Append(ClusterApiType).Append("\n");
            sb.Append("  DisableIssuerValidation: ").Append(DisableIssuerValidation).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  K8sAuthType: ").Append(K8sAuthType).Append("\n");
            sb.Append("  K8sCaCert: ").Append(K8sCaCert).Append("\n");
            sb.Append("  K8sClientCertificate: ").Append(K8sClientCertificate).Append("\n");
            sb.Append("  K8sClientKey: ").Append(K8sClientKey).Append("\n");
            sb.Append("  K8sHost: ").Append(K8sHost).Append("\n");
            sb.Append("  K8sIssuer: ").Append(K8sIssuer).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RancherApiKey: ").Append(RancherApiKey).Append("\n");
            sb.Append("  RancherClusterId: ").Append(RancherClusterId).Append("\n");
            sb.Append("  SigningKey: ").Append(SigningKey).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenExp: ").Append(TokenExp).Append("\n");
            sb.Append("  TokenReviewerJwt: ").Append(TokenReviewerJwt).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UseGwServiceAccount: ").Append(UseGwServiceAccount).Append("\n");
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

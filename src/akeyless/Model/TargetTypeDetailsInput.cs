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
    /// TargetTypeDetailsInput
    /// </summary>
    [DataContract(Name = "TargetTypeDetailsInput")]
    public partial class TargetTypeDetailsInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetTypeDetailsInput" /> class.
        /// </summary>
        /// <param name="artifactoryTargetDetails">artifactoryTargetDetails.</param>
        /// <param name="awsTargetDetails">awsTargetDetails.</param>
        /// <param name="azureTargetDetails">azureTargetDetails.</param>
        /// <param name="chefTargetDetails">chefTargetDetails.</param>
        /// <param name="customTargetDetails">customTargetDetails.</param>
        /// <param name="dbTargetDetails">dbTargetDetails.</param>
        /// <param name="dockerhubTargetDetails">dockerhubTargetDetails.</param>
        /// <param name="eksTargetDetails">eksTargetDetails.</param>
        /// <param name="gcpTargetDetails">gcpTargetDetails.</param>
        /// <param name="githubTargetDetails">githubTargetDetails.</param>
        /// <param name="gitlabTargetDetails">gitlabTargetDetails.</param>
        /// <param name="gkeTargetDetails">gkeTargetDetails.</param>
        /// <param name="globalsignAtlasTargetDetails">globalsignAtlasTargetDetails.</param>
        /// <param name="globalsignTargetDetails">globalsignTargetDetails.</param>
        /// <param name="godaddyTargetDetails">godaddyTargetDetails.</param>
        /// <param name="hashiVaultTargetDetails">hashiVaultTargetDetails.</param>
        /// <param name="ldapTargetDetails">ldapTargetDetails.</param>
        /// <param name="linkedTargetDetails">linkedTargetDetails.</param>
        /// <param name="mongoDbTargetDetails">mongoDbTargetDetails.</param>
        /// <param name="nativeK8sTargetDetails">nativeK8sTargetDetails.</param>
        /// <param name="pingTargetDetails">pingTargetDetails.</param>
        /// <param name="rabbitMqTargetDetails">rabbitMqTargetDetails.</param>
        /// <param name="salesforceTargetDetails">salesforceTargetDetails.</param>
        /// <param name="sectigoTargetDetails">sectigoTargetDetails.</param>
        /// <param name="sshTargetDetails">sshTargetDetails.</param>
        /// <param name="venafiTargetDetails">venafiTargetDetails.</param>
        /// <param name="webTargetDetails">webTargetDetails.</param>
        /// <param name="windowsTargetDetails">windowsTargetDetails.</param>
        /// <param name="zerosslTargetDetails">zerosslTargetDetails.</param>
        public TargetTypeDetailsInput(ArtifactoryTargetDetails artifactoryTargetDetails = default(ArtifactoryTargetDetails), AWSTargetDetails awsTargetDetails = default(AWSTargetDetails), AzureTargetDetails azureTargetDetails = default(AzureTargetDetails), ChefTargetDetails chefTargetDetails = default(ChefTargetDetails), CustomTargetDetails customTargetDetails = default(CustomTargetDetails), DbTargetDetails dbTargetDetails = default(DbTargetDetails), DockerhubTargetDetails dockerhubTargetDetails = default(DockerhubTargetDetails), EKSTargetDetails eksTargetDetails = default(EKSTargetDetails), GcpTargetDetails gcpTargetDetails = default(GcpTargetDetails), GithubTargetDetails githubTargetDetails = default(GithubTargetDetails), GitlabTargetDetails gitlabTargetDetails = default(GitlabTargetDetails), GKETargetDetails gkeTargetDetails = default(GKETargetDetails), GlobalSignAtlasTargetDetails globalsignAtlasTargetDetails = default(GlobalSignAtlasTargetDetails), GlobalSignGCCTargetDetails globalsignTargetDetails = default(GlobalSignGCCTargetDetails), GodaddyTargetDetails godaddyTargetDetails = default(GodaddyTargetDetails), HashiVaultTargetDetails hashiVaultTargetDetails = default(HashiVaultTargetDetails), LdapTargetDetails ldapTargetDetails = default(LdapTargetDetails), LinkedTargetDetails linkedTargetDetails = default(LinkedTargetDetails), MongoDBTargetDetails mongoDbTargetDetails = default(MongoDBTargetDetails), NativeK8sTargetDetails nativeK8sTargetDetails = default(NativeK8sTargetDetails), PingTargetDetails pingTargetDetails = default(PingTargetDetails), RabbitMQTargetDetails rabbitMqTargetDetails = default(RabbitMQTargetDetails), SalesforceTargetDetails salesforceTargetDetails = default(SalesforceTargetDetails), SectigoTargetDetails sectigoTargetDetails = default(SectigoTargetDetails), SSHTargetDetails sshTargetDetails = default(SSHTargetDetails), VenafiTargetDetails venafiTargetDetails = default(VenafiTargetDetails), WebTargetDetails webTargetDetails = default(WebTargetDetails), WindowsTargetDetails windowsTargetDetails = default(WindowsTargetDetails), ZeroSSLTargetDetails zerosslTargetDetails = default(ZeroSSLTargetDetails))
        {
            this.ArtifactoryTargetDetails = artifactoryTargetDetails;
            this.AwsTargetDetails = awsTargetDetails;
            this.AzureTargetDetails = azureTargetDetails;
            this.ChefTargetDetails = chefTargetDetails;
            this.CustomTargetDetails = customTargetDetails;
            this.DbTargetDetails = dbTargetDetails;
            this.DockerhubTargetDetails = dockerhubTargetDetails;
            this.EksTargetDetails = eksTargetDetails;
            this.GcpTargetDetails = gcpTargetDetails;
            this.GithubTargetDetails = githubTargetDetails;
            this.GitlabTargetDetails = gitlabTargetDetails;
            this.GkeTargetDetails = gkeTargetDetails;
            this.GlobalsignAtlasTargetDetails = globalsignAtlasTargetDetails;
            this.GlobalsignTargetDetails = globalsignTargetDetails;
            this.GodaddyTargetDetails = godaddyTargetDetails;
            this.HashiVaultTargetDetails = hashiVaultTargetDetails;
            this.LdapTargetDetails = ldapTargetDetails;
            this.LinkedTargetDetails = linkedTargetDetails;
            this.MongoDbTargetDetails = mongoDbTargetDetails;
            this.NativeK8sTargetDetails = nativeK8sTargetDetails;
            this.PingTargetDetails = pingTargetDetails;
            this.RabbitMqTargetDetails = rabbitMqTargetDetails;
            this.SalesforceTargetDetails = salesforceTargetDetails;
            this.SectigoTargetDetails = sectigoTargetDetails;
            this.SshTargetDetails = sshTargetDetails;
            this.VenafiTargetDetails = venafiTargetDetails;
            this.WebTargetDetails = webTargetDetails;
            this.WindowsTargetDetails = windowsTargetDetails;
            this.ZerosslTargetDetails = zerosslTargetDetails;
        }

        /// <summary>
        /// Gets or Sets ArtifactoryTargetDetails
        /// </summary>
        [DataMember(Name = "artifactory_target_details", EmitDefaultValue = false)]
        public ArtifactoryTargetDetails ArtifactoryTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets AwsTargetDetails
        /// </summary>
        [DataMember(Name = "aws_target_details", EmitDefaultValue = false)]
        public AWSTargetDetails AwsTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets AzureTargetDetails
        /// </summary>
        [DataMember(Name = "azure_target_details", EmitDefaultValue = false)]
        public AzureTargetDetails AzureTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets ChefTargetDetails
        /// </summary>
        [DataMember(Name = "chef_target_details", EmitDefaultValue = false)]
        public ChefTargetDetails ChefTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets CustomTargetDetails
        /// </summary>
        [DataMember(Name = "custom_target_details", EmitDefaultValue = false)]
        public CustomTargetDetails CustomTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets DbTargetDetails
        /// </summary>
        [DataMember(Name = "db_target_details", EmitDefaultValue = false)]
        public DbTargetDetails DbTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets DockerhubTargetDetails
        /// </summary>
        [DataMember(Name = "dockerhub_target_details", EmitDefaultValue = false)]
        public DockerhubTargetDetails DockerhubTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets EksTargetDetails
        /// </summary>
        [DataMember(Name = "eks_target_details", EmitDefaultValue = false)]
        public EKSTargetDetails EksTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GcpTargetDetails
        /// </summary>
        [DataMember(Name = "gcp_target_details", EmitDefaultValue = false)]
        public GcpTargetDetails GcpTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GithubTargetDetails
        /// </summary>
        [DataMember(Name = "github_target_details", EmitDefaultValue = false)]
        public GithubTargetDetails GithubTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GitlabTargetDetails
        /// </summary>
        [DataMember(Name = "gitlab_target_details", EmitDefaultValue = false)]
        public GitlabTargetDetails GitlabTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GkeTargetDetails
        /// </summary>
        [DataMember(Name = "gke_target_details", EmitDefaultValue = false)]
        public GKETargetDetails GkeTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GlobalsignAtlasTargetDetails
        /// </summary>
        [DataMember(Name = "globalsign_atlas_target_details", EmitDefaultValue = false)]
        public GlobalSignAtlasTargetDetails GlobalsignAtlasTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GlobalsignTargetDetails
        /// </summary>
        [DataMember(Name = "globalsign_target_details", EmitDefaultValue = false)]
        public GlobalSignGCCTargetDetails GlobalsignTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets GodaddyTargetDetails
        /// </summary>
        [DataMember(Name = "godaddy_target_details", EmitDefaultValue = false)]
        public GodaddyTargetDetails GodaddyTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets HashiVaultTargetDetails
        /// </summary>
        [DataMember(Name = "hashi_vault_target_details", EmitDefaultValue = false)]
        public HashiVaultTargetDetails HashiVaultTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets LdapTargetDetails
        /// </summary>
        [DataMember(Name = "ldap_target_details", EmitDefaultValue = false)]
        public LdapTargetDetails LdapTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets LinkedTargetDetails
        /// </summary>
        [DataMember(Name = "linked_target_details", EmitDefaultValue = false)]
        public LinkedTargetDetails LinkedTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets MongoDbTargetDetails
        /// </summary>
        [DataMember(Name = "mongo_db_target_details", EmitDefaultValue = false)]
        public MongoDBTargetDetails MongoDbTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets NativeK8sTargetDetails
        /// </summary>
        [DataMember(Name = "native_k8s_target_details", EmitDefaultValue = false)]
        public NativeK8sTargetDetails NativeK8sTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets PingTargetDetails
        /// </summary>
        [DataMember(Name = "ping_target_details", EmitDefaultValue = false)]
        public PingTargetDetails PingTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets RabbitMqTargetDetails
        /// </summary>
        [DataMember(Name = "rabbit_mq_target_details", EmitDefaultValue = false)]
        public RabbitMQTargetDetails RabbitMqTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets SalesforceTargetDetails
        /// </summary>
        [DataMember(Name = "salesforce_target_details", EmitDefaultValue = false)]
        public SalesforceTargetDetails SalesforceTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets SectigoTargetDetails
        /// </summary>
        [DataMember(Name = "sectigo_target_details", EmitDefaultValue = false)]
        public SectigoTargetDetails SectigoTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets SshTargetDetails
        /// </summary>
        [DataMember(Name = "ssh_target_details", EmitDefaultValue = false)]
        public SSHTargetDetails SshTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets VenafiTargetDetails
        /// </summary>
        [DataMember(Name = "venafi_target_details", EmitDefaultValue = false)]
        public VenafiTargetDetails VenafiTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets WebTargetDetails
        /// </summary>
        [DataMember(Name = "web_target_details", EmitDefaultValue = false)]
        public WebTargetDetails WebTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets WindowsTargetDetails
        /// </summary>
        [DataMember(Name = "windows_target_details", EmitDefaultValue = false)]
        public WindowsTargetDetails WindowsTargetDetails { get; set; }

        /// <summary>
        /// Gets or Sets ZerosslTargetDetails
        /// </summary>
        [DataMember(Name = "zerossl_target_details", EmitDefaultValue = false)]
        public ZeroSSLTargetDetails ZerosslTargetDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetTypeDetailsInput {\n");
            sb.Append("  ArtifactoryTargetDetails: ").Append(ArtifactoryTargetDetails).Append("\n");
            sb.Append("  AwsTargetDetails: ").Append(AwsTargetDetails).Append("\n");
            sb.Append("  AzureTargetDetails: ").Append(AzureTargetDetails).Append("\n");
            sb.Append("  ChefTargetDetails: ").Append(ChefTargetDetails).Append("\n");
            sb.Append("  CustomTargetDetails: ").Append(CustomTargetDetails).Append("\n");
            sb.Append("  DbTargetDetails: ").Append(DbTargetDetails).Append("\n");
            sb.Append("  DockerhubTargetDetails: ").Append(DockerhubTargetDetails).Append("\n");
            sb.Append("  EksTargetDetails: ").Append(EksTargetDetails).Append("\n");
            sb.Append("  GcpTargetDetails: ").Append(GcpTargetDetails).Append("\n");
            sb.Append("  GithubTargetDetails: ").Append(GithubTargetDetails).Append("\n");
            sb.Append("  GitlabTargetDetails: ").Append(GitlabTargetDetails).Append("\n");
            sb.Append("  GkeTargetDetails: ").Append(GkeTargetDetails).Append("\n");
            sb.Append("  GlobalsignAtlasTargetDetails: ").Append(GlobalsignAtlasTargetDetails).Append("\n");
            sb.Append("  GlobalsignTargetDetails: ").Append(GlobalsignTargetDetails).Append("\n");
            sb.Append("  GodaddyTargetDetails: ").Append(GodaddyTargetDetails).Append("\n");
            sb.Append("  HashiVaultTargetDetails: ").Append(HashiVaultTargetDetails).Append("\n");
            sb.Append("  LdapTargetDetails: ").Append(LdapTargetDetails).Append("\n");
            sb.Append("  LinkedTargetDetails: ").Append(LinkedTargetDetails).Append("\n");
            sb.Append("  MongoDbTargetDetails: ").Append(MongoDbTargetDetails).Append("\n");
            sb.Append("  NativeK8sTargetDetails: ").Append(NativeK8sTargetDetails).Append("\n");
            sb.Append("  PingTargetDetails: ").Append(PingTargetDetails).Append("\n");
            sb.Append("  RabbitMqTargetDetails: ").Append(RabbitMqTargetDetails).Append("\n");
            sb.Append("  SalesforceTargetDetails: ").Append(SalesforceTargetDetails).Append("\n");
            sb.Append("  SectigoTargetDetails: ").Append(SectigoTargetDetails).Append("\n");
            sb.Append("  SshTargetDetails: ").Append(SshTargetDetails).Append("\n");
            sb.Append("  VenafiTargetDetails: ").Append(VenafiTargetDetails).Append("\n");
            sb.Append("  WebTargetDetails: ").Append(WebTargetDetails).Append("\n");
            sb.Append("  WindowsTargetDetails: ").Append(WindowsTargetDetails).Append("\n");
            sb.Append("  ZerosslTargetDetails: ").Append(ZerosslTargetDetails).Append("\n");
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

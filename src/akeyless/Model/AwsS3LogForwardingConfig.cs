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
    /// AwsS3LogForwardingConfig
    /// </summary>
    [DataContract(Name = "AwsS3LogForwardingConfig")]
    public partial class AwsS3LogForwardingConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsS3LogForwardingConfig" /> class.
        /// </summary>
        /// <param name="awsAccessId">awsAccessId.</param>
        /// <param name="awsAccessKey">awsAccessKey.</param>
        /// <param name="awsAuthType">awsAuthType.</param>
        /// <param name="awsRegion">awsRegion.</param>
        /// <param name="awsRoleArn">awsRoleArn.</param>
        /// <param name="awsUseGatewayCloudIdentity">deprecated.</param>
        /// <param name="bucketName">bucketName.</param>
        /// <param name="logFolder">logFolder.</param>
        public AwsS3LogForwardingConfig(string awsAccessId = default(string), string awsAccessKey = default(string), string awsAuthType = default(string), string awsRegion = default(string), string awsRoleArn = default(string), bool awsUseGatewayCloudIdentity = default(bool), string bucketName = default(string), string logFolder = default(string))
        {
            this.AwsAccessId = awsAccessId;
            this.AwsAccessKey = awsAccessKey;
            this.AwsAuthType = awsAuthType;
            this.AwsRegion = awsRegion;
            this.AwsRoleArn = awsRoleArn;
            this.AwsUseGatewayCloudIdentity = awsUseGatewayCloudIdentity;
            this.BucketName = bucketName;
            this.LogFolder = logFolder;
        }

        /// <summary>
        /// Gets or Sets AwsAccessId
        /// </summary>
        [DataMember(Name = "aws_access_id", EmitDefaultValue = false)]
        public string AwsAccessId { get; set; }

        /// <summary>
        /// Gets or Sets AwsAccessKey
        /// </summary>
        [DataMember(Name = "aws_access_key", EmitDefaultValue = false)]
        public string AwsAccessKey { get; set; }

        /// <summary>
        /// Gets or Sets AwsAuthType
        /// </summary>
        [DataMember(Name = "aws_auth_type", EmitDefaultValue = false)]
        public string AwsAuthType { get; set; }

        /// <summary>
        /// Gets or Sets AwsRegion
        /// </summary>
        [DataMember(Name = "aws_region", EmitDefaultValue = false)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Gets or Sets AwsRoleArn
        /// </summary>
        [DataMember(Name = "aws_role_arn", EmitDefaultValue = false)]
        public string AwsRoleArn { get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        /// <value>deprecated</value>
        [DataMember(Name = "aws_use_gateway_cloud_identity", EmitDefaultValue = true)]
        public bool AwsUseGatewayCloudIdentity { get; set; }

        /// <summary>
        /// Gets or Sets BucketName
        /// </summary>
        [DataMember(Name = "bucket_name", EmitDefaultValue = false)]
        public string BucketName { get; set; }

        /// <summary>
        /// Gets or Sets LogFolder
        /// </summary>
        [DataMember(Name = "log_folder", EmitDefaultValue = false)]
        public string LogFolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AwsS3LogForwardingConfig {\n");
            sb.Append("  AwsAccessId: ").Append(AwsAccessId).Append("\n");
            sb.Append("  AwsAccessKey: ").Append(AwsAccessKey).Append("\n");
            sb.Append("  AwsAuthType: ").Append(AwsAuthType).Append("\n");
            sb.Append("  AwsRegion: ").Append(AwsRegion).Append("\n");
            sb.Append("  AwsRoleArn: ").Append(AwsRoleArn).Append("\n");
            sb.Append("  AwsUseGatewayCloudIdentity: ").Append(AwsUseGatewayCloudIdentity).Append("\n");
            sb.Append("  BucketName: ").Append(BucketName).Append("\n");
            sb.Append("  LogFolder: ").Append(LogFolder).Append("\n");
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

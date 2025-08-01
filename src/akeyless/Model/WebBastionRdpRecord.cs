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
    /// WebBastionRdpRecord
    /// </summary>
    [DataContract(Name = "WebBastionRdpRecord")]
    public partial class WebBastionRdpRecord : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebBastionRdpRecord" /> class.
        /// </summary>
        /// <param name="aws">aws.</param>
        /// <param name="azure">azure.</param>
        /// <param name="compress">compress.</param>
        /// <param name="encryptionKey">encryptionKey.</param>
        /// <param name="recordingQuality">recordingQuality.</param>
        /// <param name="storageType">storageType.</param>
        public WebBastionRdpRecord(AwsStorage aws = default(AwsStorage), AzureStorage azure = default(AzureStorage), bool compress = default(bool), string encryptionKey = default(string), string recordingQuality = default(string), string storageType = default(string))
        {
            this.Aws = aws;
            this.Azure = azure;
            this.Compress = compress;
            this.EncryptionKey = encryptionKey;
            this.RecordingQuality = recordingQuality;
            this.StorageType = storageType;
        }

        /// <summary>
        /// Gets or Sets Aws
        /// </summary>
        [DataMember(Name = "aws", EmitDefaultValue = false)]
        public AwsStorage Aws { get; set; }

        /// <summary>
        /// Gets or Sets Azure
        /// </summary>
        [DataMember(Name = "azure", EmitDefaultValue = false)]
        public AzureStorage Azure { get; set; }

        /// <summary>
        /// Gets or Sets Compress
        /// </summary>
        [DataMember(Name = "compress", EmitDefaultValue = true)]
        public bool Compress { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionKey
        /// </summary>
        [DataMember(Name = "encryption_key", EmitDefaultValue = false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Gets or Sets RecordingQuality
        /// </summary>
        [DataMember(Name = "recording_quality", EmitDefaultValue = false)]
        public string RecordingQuality { get; set; }

        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "storage_type", EmitDefaultValue = false)]
        public string StorageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebBastionRdpRecord {\n");
            sb.Append("  Aws: ").Append(Aws).Append("\n");
            sb.Append("  Azure: ").Append(Azure).Append("\n");
            sb.Append("  Compress: ").Append(Compress).Append("\n");
            sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
            sb.Append("  RecordingQuality: ").Append(RecordingQuality).Append("\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
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

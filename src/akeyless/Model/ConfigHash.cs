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
    /// ConfigHash
    /// </summary>
    [DataContract(Name = "ConfigHash")]
    public partial class ConfigHash : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigHash" /> class.
        /// </summary>
        /// <param name="admins">admins.</param>
        /// <param name="cache">cache.</param>
        /// <param name="customerFragements">customerFragements.</param>
        /// <param name="general">general.</param>
        /// <param name="k8sAuths">k8sAuths.</param>
        /// <param name="kmip">kmip.</param>
        /// <param name="ldap">ldap.</param>
        /// <param name="leadership">leadership.</param>
        /// <param name="logForwarding">logForwarding.</param>
        /// <param name="mQueue">mQueue.</param>
        /// <param name="migrationStatus">migrationStatus.</param>
        /// <param name="migrations">migrations.</param>
        /// <param name="producers">producers.</param>
        /// <param name="producersStatus">producersStatus.</param>
        /// <param name="rotators">rotators.</param>
        /// <param name="saml">saml.</param>
        /// <param name="universalIdentity">universalIdentity.</param>
        public ConfigHash(string admins = default(string), string cache = default(string), string customerFragements = default(string), string general = default(string), string k8sAuths = default(string), string kmip = default(string), string ldap = default(string), string leadership = default(string), string logForwarding = default(string), string mQueue = default(string), string migrationStatus = default(string), string migrations = default(string), Object producers = default(Object), string producersStatus = default(string), Object rotators = default(Object), string saml = default(string), string universalIdentity = default(string))
        {
            this.Admins = admins;
            this.Cache = cache;
            this.CustomerFragements = customerFragements;
            this.General = general;
            this.K8sAuths = k8sAuths;
            this.Kmip = kmip;
            this.Ldap = ldap;
            this.Leadership = leadership;
            this.LogForwarding = logForwarding;
            this.MQueue = mQueue;
            this.MigrationStatus = migrationStatus;
            this.Migrations = migrations;
            this.Producers = producers;
            this.ProducersStatus = producersStatus;
            this.Rotators = rotators;
            this.Saml = saml;
            this.UniversalIdentity = universalIdentity;
        }

        /// <summary>
        /// Gets or Sets Admins
        /// </summary>
        [DataMember(Name = "admins", EmitDefaultValue = false)]
        public string Admins { get; set; }

        /// <summary>
        /// Gets or Sets Cache
        /// </summary>
        [DataMember(Name = "cache", EmitDefaultValue = false)]
        public string Cache { get; set; }

        /// <summary>
        /// Gets or Sets CustomerFragements
        /// </summary>
        [DataMember(Name = "customer_fragements", EmitDefaultValue = false)]
        public string CustomerFragements { get; set; }

        /// <summary>
        /// Gets or Sets General
        /// </summary>
        [DataMember(Name = "general", EmitDefaultValue = false)]
        public string General { get; set; }

        /// <summary>
        /// Gets or Sets K8sAuths
        /// </summary>
        [DataMember(Name = "k8s_auths", EmitDefaultValue = false)]
        public string K8sAuths { get; set; }

        /// <summary>
        /// Gets or Sets Kmip
        /// </summary>
        [DataMember(Name = "kmip", EmitDefaultValue = false)]
        public string Kmip { get; set; }

        /// <summary>
        /// Gets or Sets Ldap
        /// </summary>
        [DataMember(Name = "ldap", EmitDefaultValue = false)]
        public string Ldap { get; set; }

        /// <summary>
        /// Gets or Sets Leadership
        /// </summary>
        [DataMember(Name = "leadership", EmitDefaultValue = false)]
        public string Leadership { get; set; }

        /// <summary>
        /// Gets or Sets LogForwarding
        /// </summary>
        [DataMember(Name = "log_forwarding", EmitDefaultValue = false)]
        public string LogForwarding { get; set; }

        /// <summary>
        /// Gets or Sets MQueue
        /// </summary>
        [DataMember(Name = "m_queue", EmitDefaultValue = false)]
        public string MQueue { get; set; }

        /// <summary>
        /// Gets or Sets MigrationStatus
        /// </summary>
        [DataMember(Name = "migration_status", EmitDefaultValue = false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// Gets or Sets Migrations
        /// </summary>
        [DataMember(Name = "migrations", EmitDefaultValue = false)]
        public string Migrations { get; set; }

        /// <summary>
        /// Gets or Sets Producers
        /// </summary>
        [DataMember(Name = "producers", EmitDefaultValue = true)]
        public Object Producers { get; set; }

        /// <summary>
        /// Gets or Sets ProducersStatus
        /// </summary>
        [DataMember(Name = "producers_status", EmitDefaultValue = false)]
        public string ProducersStatus { get; set; }

        /// <summary>
        /// Gets or Sets Rotators
        /// </summary>
        [DataMember(Name = "rotators", EmitDefaultValue = true)]
        public Object Rotators { get; set; }

        /// <summary>
        /// Gets or Sets Saml
        /// </summary>
        [DataMember(Name = "saml", EmitDefaultValue = false)]
        public string Saml { get; set; }

        /// <summary>
        /// Gets or Sets UniversalIdentity
        /// </summary>
        [DataMember(Name = "universal_identity", EmitDefaultValue = false)]
        public string UniversalIdentity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigHash {\n");
            sb.Append("  Admins: ").Append(Admins).Append("\n");
            sb.Append("  Cache: ").Append(Cache).Append("\n");
            sb.Append("  CustomerFragements: ").Append(CustomerFragements).Append("\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  K8sAuths: ").Append(K8sAuths).Append("\n");
            sb.Append("  Kmip: ").Append(Kmip).Append("\n");
            sb.Append("  Ldap: ").Append(Ldap).Append("\n");
            sb.Append("  Leadership: ").Append(Leadership).Append("\n");
            sb.Append("  LogForwarding: ").Append(LogForwarding).Append("\n");
            sb.Append("  MQueue: ").Append(MQueue).Append("\n");
            sb.Append("  MigrationStatus: ").Append(MigrationStatus).Append("\n");
            sb.Append("  Migrations: ").Append(Migrations).Append("\n");
            sb.Append("  Producers: ").Append(Producers).Append("\n");
            sb.Append("  ProducersStatus: ").Append(ProducersStatus).Append("\n");
            sb.Append("  Rotators: ").Append(Rotators).Append("\n");
            sb.Append("  Saml: ").Append(Saml).Append("\n");
            sb.Append("  UniversalIdentity: ").Append(UniversalIdentity).Append("\n");
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

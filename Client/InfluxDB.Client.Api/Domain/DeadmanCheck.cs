/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// DeadmanCheck
    /// </summary>
    [DataContract]
    public partial class DeadmanCheck : Check,  IEquatable<DeadmanCheck>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Deadman for value: deadman
            /// </summary>
            [EnumMember(Value = "deadman")]
            Deadman = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeadmanCheck" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeadmanCheck() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeadmanCheck" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="timeSince">string duration before deadman triggers..</param>
        /// <param name="staleTime">string duration for time that a series is considered stale and should not trigger deadman..</param>
        /// <param name="reportZero">If only zero values reported since time, trigger an alert.</param>
        /// <param name="level">level.</param>
        public DeadmanCheck(TypeEnum? type = default(TypeEnum?), string timeSince = default(string), string staleTime = default(string), bool? reportZero = default(bool?), CheckStatusLevel level = default(CheckStatusLevel), string name = default(string), string orgID = default(string), DashboardQuery query = default(DashboardQuery), TaskStatusType? status = default(TaskStatusType?), string every = default(string), string offset = default(string), List<CheckBaseTags> tags = default(List<CheckBaseTags>), string description = default(string), string statusMessageTemplate = default(string), List<Label> labels = default(List<Label>), CheckBaseLinks links = default(CheckBaseLinks)) : base(name, orgID, query, status, every, offset, tags, description, statusMessageTemplate, labels, links)
        {
            this.Type = type;
            this.TimeSince = timeSince;
            this.StaleTime = staleTime;
            this.ReportZero = reportZero;
            this.Level = level;
        }


        /// <summary>
        /// string duration before deadman triggers.
        /// </summary>
        /// <value>string duration before deadman triggers.</value>
        [DataMember(Name="timeSince", EmitDefaultValue=false)]
        public string TimeSince { get; set; }

        /// <summary>
        /// string duration for time that a series is considered stale and should not trigger deadman.
        /// </summary>
        /// <value>string duration for time that a series is considered stale and should not trigger deadman.</value>
        [DataMember(Name="staleTime", EmitDefaultValue=false)]
        public string StaleTime { get; set; }

        /// <summary>
        /// If only zero values reported since time, trigger an alert
        /// </summary>
        /// <value>If only zero values reported since time, trigger an alert</value>
        [DataMember(Name="reportZero", EmitDefaultValue=false)]
        public bool? ReportZero { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public CheckStatusLevel Level { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeadmanCheck {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeSince: ").Append(TimeSince).Append("\n");
            sb.Append("  StaleTime: ").Append(StaleTime).Append("\n");
            sb.Append("  ReportZero: ").Append(ReportZero).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeadmanCheck);
        }

        /// <summary>
        /// Returns true if DeadmanCheck instances are equal
        /// </summary>
        /// <param name="input">Instance of DeadmanCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeadmanCheck input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.TimeSince == input.TimeSince ||
                    (this.TimeSince != null &&
                    this.TimeSince.Equals(input.TimeSince))
                ) && base.Equals(input) && 
                (
                    this.StaleTime == input.StaleTime ||
                    (this.StaleTime != null &&
                    this.StaleTime.Equals(input.StaleTime))
                ) && base.Equals(input) && 
                (
                    this.ReportZero == input.ReportZero ||
                    (this.ReportZero != null &&
                    this.ReportZero.Equals(input.ReportZero))
                ) && base.Equals(input) && 
                (
                    this.Level.Equals(input.Level)
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TimeSince != null)
                    hashCode = hashCode * 59 + this.TimeSince.GetHashCode();
                if (this.StaleTime != null)
                    hashCode = hashCode * 59 + this.StaleTime.GetHashCode();
                if (this.ReportZero != null)
                    hashCode = hashCode * 59 + this.ReportZero.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                return hashCode;
            }
        }

    }

}

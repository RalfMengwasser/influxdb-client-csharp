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
    /// ThresholdCheck
    /// </summary>
    [DataContract]
    public partial class ThresholdCheck : Check,  IEquatable<ThresholdCheck>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Threshold for value: threshold
            /// </summary>
            [EnumMember(Value = "threshold")]
            Threshold = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdCheck" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThresholdCheck() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdCheck" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="thresholds">thresholds.</param>
        public ThresholdCheck(TypeEnum? type = default(TypeEnum?), List<Threshold> thresholds = default(List<Threshold>), string name = default(string), string orgID = default(string), DashboardQuery query = default(DashboardQuery), TaskStatusType? status = default(TaskStatusType?), string every = default(string), string offset = default(string), List<CheckBaseTags> tags = default(List<CheckBaseTags>), string description = default(string), string statusMessageTemplate = default(string), List<Label> labels = default(List<Label>), CheckBaseLinks links = default(CheckBaseLinks)) : base(name, orgID, query, status, every, offset, tags, description, statusMessageTemplate, labels, links)
        {
            this.Type = type;
            this.Thresholds = thresholds;
        }


        /// <summary>
        /// Gets or Sets Thresholds
        /// </summary>
        [DataMember(Name="thresholds", EmitDefaultValue=false)]
        public List<Threshold> Thresholds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThresholdCheck {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Thresholds: ").Append(Thresholds).Append("\n");
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
            return this.Equals(input as ThresholdCheck);
        }

        /// <summary>
        /// Returns true if ThresholdCheck instances are equal
        /// </summary>
        /// <param name="input">Instance of ThresholdCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThresholdCheck input)
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
                    this.Thresholds == input.Thresholds ||
                    this.Thresholds != null &&
                    this.Thresholds.SequenceEqual(input.Thresholds)
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
                if (this.Thresholds != null)
                    hashCode = hashCode * 59 + this.Thresholds.GetHashCode();
                return hashCode;
            }
        }

    }

}

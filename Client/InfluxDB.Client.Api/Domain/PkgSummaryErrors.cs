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
    /// PkgSummaryErrors
    /// </summary>
    [DataContract]
    public partial class PkgSummaryErrors :  IEquatable<PkgSummaryErrors>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PkgSummaryErrors" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="reason">reason.</param>
        /// <param name="fields">fields.</param>
        /// <param name="indexes">indexes.</param>
        public PkgSummaryErrors(string kind = default(string), string reason = default(string), List<string> fields = default(List<string>), List<int?> indexes = default(List<int?>))
        {
            this.Kind = kind;
            this.Reason = reason;
            this.Fields = fields;
            this.Indexes = indexes;
        }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Indexes
        /// </summary>
        [DataMember(Name="indexes", EmitDefaultValue=false)]
        public List<int?> Indexes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PkgSummaryErrors {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Indexes: ").Append(Indexes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as PkgSummaryErrors);
        }

        /// <summary>
        /// Returns true if PkgSummaryErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of PkgSummaryErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkgSummaryErrors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Indexes == input.Indexes ||
                    this.Indexes != null &&
                    this.Indexes.SequenceEqual(input.Indexes)
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
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Indexes != null)
                    hashCode = hashCode * 59 + this.Indexes.GetHashCode();
                return hashCode;
            }
        }

    }

}

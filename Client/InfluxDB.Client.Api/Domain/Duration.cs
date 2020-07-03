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
    /// A pair consisting of length of time and the unit of time measured. It is the atomic unit from which all duration literals are composed.
    /// </summary>
    [DataContract]
    public partial class Duration :  IEquatable<Duration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        /// <param name="type">Type of AST node.</param>
        /// <param name="magnitude">magnitude.</param>
        /// <param name="unit">unit.</param>
        public Duration(string type = default(string), int? magnitude = default(int?), string unit = default(string))
        {
            this.Type = type;
            this.Magnitude = magnitude;
            this.Unit = unit;
        }

        /// <summary>
        /// Type of AST node
        /// </summary>
        /// <value>Type of AST node</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Magnitude
        /// </summary>
        [DataMember(Name="magnitude", EmitDefaultValue=false)]
        public int? Magnitude { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Magnitude: ").Append(Magnitude).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as Duration);
        }

        /// <summary>
        /// Returns true if Duration instances are equal
        /// </summary>
        /// <param name="input">Instance of Duration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Duration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Magnitude == input.Magnitude ||
                    (this.Magnitude != null &&
                    this.Magnitude.Equals(input.Magnitude))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Magnitude != null)
                    hashCode = hashCode * 59 + this.Magnitude.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }

    }

}

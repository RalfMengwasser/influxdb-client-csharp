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
    /// Indicates whether decimal places should be enforced, and how many digits it should show.
    /// </summary>
    [DataContract]
    public partial class DecimalPlaces :  IEquatable<DecimalPlaces>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalPlaces" /> class.
        /// </summary>
        /// <param name="isEnforced">Indicates whether decimal point setting should be enforced.</param>
        /// <param name="digits">The number of digits after decimal to display.</param>
        public DecimalPlaces(bool? isEnforced = default(bool?), int? digits = default(int?))
        {
            this.IsEnforced = isEnforced;
            this.Digits = digits;
        }

        /// <summary>
        /// Indicates whether decimal point setting should be enforced
        /// </summary>
        /// <value>Indicates whether decimal point setting should be enforced</value>
        [DataMember(Name="isEnforced", EmitDefaultValue=false)]
        public bool? IsEnforced { get; set; }

        /// <summary>
        /// The number of digits after decimal to display
        /// </summary>
        /// <value>The number of digits after decimal to display</value>
        [DataMember(Name="digits", EmitDefaultValue=false)]
        public int? Digits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecimalPlaces {\n");
            sb.Append("  IsEnforced: ").Append(IsEnforced).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
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
            return this.Equals(input as DecimalPlaces);
        }

        /// <summary>
        /// Returns true if DecimalPlaces instances are equal
        /// </summary>
        /// <param name="input">Instance of DecimalPlaces to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecimalPlaces input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnforced == input.IsEnforced ||
                    (this.IsEnforced != null &&
                    this.IsEnforced.Equals(input.IsEnforced))
                ) && 
                (
                    this.Digits == input.Digits ||
                    (this.Digits != null &&
                    this.Digits.Equals(input.Digits))
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
                if (this.IsEnforced != null)
                    hashCode = hashCode * 59 + this.IsEnforced.GetHashCode();
                if (this.Digits != null)
                    hashCode = hashCode * 59 + this.Digits.GetHashCode();
                return hashCode;
            }
        }

    }

}

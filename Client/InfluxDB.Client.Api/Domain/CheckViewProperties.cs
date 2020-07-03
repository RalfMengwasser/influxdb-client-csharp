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
    /// CheckViewProperties
    /// </summary>
    [DataContract]
    public partial class CheckViewProperties : ViewProperties,  IEquatable<CheckViewProperties>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Check for value: check
            /// </summary>
            [EnumMember(Value = "check")]
            Check = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Shape
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeEnum
        {
            /// <summary>
            /// Enum ChronografV2 for value: chronograf-v2
            /// </summary>
            [EnumMember(Value = "chronograf-v2")]
            ChronografV2 = 1

        }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum Shape { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckViewProperties" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="shape">shape (required).</param>
        /// <param name="checkID">checkID (required).</param>
        /// <param name="check">check.</param>
        /// <param name="queries">queries (required).</param>
        /// <param name="colors">Colors define color encoding of data into a visualization (required).</param>
        public CheckViewProperties(TypeEnum type = default(TypeEnum), ShapeEnum shape = default(ShapeEnum), string checkID = default(string), Check check = default(Check), List<DashboardQuery> queries = default(List<DashboardQuery>), List<string> colors = default(List<string>)) : base()
        {
            this.Type = type;
            this.Shape = shape;

            // to ensure "checkID" is required (not null)
            if (checkID == null)
            {
                throw new InvalidDataException("checkID is a required property for CheckViewProperties and cannot be null");
            }
            else
            {
                this.CheckID = checkID;
            }
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new InvalidDataException("queries is a required property for CheckViewProperties and cannot be null");
            }
            else
            {
                this.Queries = queries;
            }
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new InvalidDataException("colors is a required property for CheckViewProperties and cannot be null");
            }
            else
            {
                this.Colors = colors;
            }
            this.Check = check;
        }



        /// <summary>
        /// Gets or Sets CheckID
        /// </summary>
        [DataMember(Name="checkID", EmitDefaultValue=false)]
        public string CheckID { get; set; }

        /// <summary>
        /// Gets or Sets Check
        /// </summary>
        [DataMember(Name="check", EmitDefaultValue=false)]
        public Check Check { get; set; }

        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name="queries", EmitDefaultValue=false)]
        public List<DashboardQuery> Queries { get; set; }

        /// <summary>
        /// Colors define color encoding of data into a visualization
        /// </summary>
        /// <value>Colors define color encoding of data into a visualization</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<string> Colors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  CheckID: ").Append(CheckID).Append("\n");
            sb.Append("  Check: ").Append(Check).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
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
            return this.Equals(input as CheckViewProperties);
        }

        /// <summary>
        /// Returns true if CheckViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && base.Equals(input) && 
                (
                    this.Shape == input.Shape ||
                    this.Shape.Equals(input.Shape)
                ) && base.Equals(input) && 
                (
                    this.CheckID == input.CheckID ||
                    (this.CheckID != null &&
                    this.CheckID.Equals(input.CheckID))
                ) && base.Equals(input) && 
                (
                    
                    (this.Check != null &&
                    this.Check.Equals(input.Check))
                ) && base.Equals(input) && 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
                ) && base.Equals(input) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.CheckID != null)
                    hashCode = hashCode * 59 + this.CheckID.GetHashCode();
                if (this.Check != null)
                    hashCode = hashCode * 59 + this.Check.GetHashCode();
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                return hashCode;
            }
        }

    }

}

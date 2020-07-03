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
    /// HistogramViewProperties
    /// </summary>
    [DataContract]
    public partial class HistogramViewProperties : ViewProperties,  IEquatable<HistogramViewProperties>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Histogram for value: histogram
            /// </summary>
            [EnumMember(Value = "histogram")]
            Histogram = 1

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
        /// Defines Position
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionEnum
        {
            /// <summary>
            /// Enum Overlaid for value: overlaid
            /// </summary>
            [EnumMember(Value = "overlaid")]
            Overlaid = 1,

            /// <summary>
            /// Enum Stacked for value: stacked
            /// </summary>
            [EnumMember(Value = "stacked")]
            Stacked = 2

        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionEnum Position { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HistogramViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramViewProperties" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="queries">queries (required).</param>
        /// <param name="colors">Colors define color encoding of data into a visualization (required).</param>
        /// <param name="shape">shape (required).</param>
        /// <param name="note">note (required).</param>
        /// <param name="showNoteWhenEmpty">If true, will display note when empty (required).</param>
        /// <param name="xColumn">xColumn (required).</param>
        /// <param name="fillColumns">fillColumns (required).</param>
        /// <param name="xDomain">xDomain (required).</param>
        /// <param name="xAxisLabel">xAxisLabel (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="binCount">binCount (required).</param>
        public HistogramViewProperties(TypeEnum type = default(TypeEnum), List<DashboardQuery> queries = default(List<DashboardQuery>), List<DashboardColor> colors = default(List<DashboardColor>), ShapeEnum shape = default(ShapeEnum), string note = default(string), bool? showNoteWhenEmpty = default(bool?), string xColumn = default(string), List<string> fillColumns = default(List<string>), List<float?> xDomain = default(List<float?>), string xAxisLabel = default(string), PositionEnum position = default(PositionEnum), int? binCount = default(int?)) : base()
        {
            this.Type = type;
            this.Shape = shape;

            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new InvalidDataException("queries is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.Queries = queries;
            }
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new InvalidDataException("colors is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.Colors = colors;
            }

            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new InvalidDataException("note is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.Note = note;
            }
            // to ensure "showNoteWhenEmpty" is required (not null)
            if (showNoteWhenEmpty == null)
            {
                throw new InvalidDataException("showNoteWhenEmpty is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.ShowNoteWhenEmpty = showNoteWhenEmpty;
            }
            // to ensure "xColumn" is required (not null)
            if (xColumn == null)
            {
                throw new InvalidDataException("xColumn is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.XColumn = xColumn;
            }
            // to ensure "fillColumns" is required (not null)
            if (fillColumns == null)
            {
                throw new InvalidDataException("fillColumns is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.FillColumns = fillColumns;
            }
            // to ensure "xDomain" is required (not null)
            if (xDomain == null)
            {
                throw new InvalidDataException("xDomain is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.XDomain = xDomain;
            }
            // to ensure "xAxisLabel" is required (not null)
            if (xAxisLabel == null)
            {
                throw new InvalidDataException("xAxisLabel is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.XAxisLabel = xAxisLabel;
            }

            this.Position = position;

            // to ensure "binCount" is required (not null)
            if (binCount == null)
            {
                throw new InvalidDataException("binCount is a required property for HistogramViewProperties and cannot be null");
            }
            else
            {
                this.BinCount = binCount;
            }
        }


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
        public List<DashboardColor> Colors { get; set; }


        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// If true, will display note when empty
        /// </summary>
        /// <value>If true, will display note when empty</value>
        [DataMember(Name="showNoteWhenEmpty", EmitDefaultValue=false)]
        public bool? ShowNoteWhenEmpty { get; set; }

        /// <summary>
        /// Gets or Sets XColumn
        /// </summary>
        [DataMember(Name="xColumn", EmitDefaultValue=false)]
        public string XColumn { get; set; }

        /// <summary>
        /// Gets or Sets FillColumns
        /// </summary>
        [DataMember(Name="fillColumns", EmitDefaultValue=false)]
        public List<string> FillColumns { get; set; }

        /// <summary>
        /// Gets or Sets XDomain
        /// </summary>
        [DataMember(Name="xDomain", EmitDefaultValue=false)]
        public List<float?> XDomain { get; set; }

        /// <summary>
        /// Gets or Sets XAxisLabel
        /// </summary>
        [DataMember(Name="xAxisLabel", EmitDefaultValue=false)]
        public string XAxisLabel { get; set; }


        /// <summary>
        /// Gets or Sets BinCount
        /// </summary>
        [DataMember(Name="binCount", EmitDefaultValue=false)]
        public int? BinCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistogramViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ShowNoteWhenEmpty: ").Append(ShowNoteWhenEmpty).Append("\n");
            sb.Append("  XColumn: ").Append(XColumn).Append("\n");
            sb.Append("  FillColumns: ").Append(FillColumns).Append("\n");
            sb.Append("  XDomain: ").Append(XDomain).Append("\n");
            sb.Append("  XAxisLabel: ").Append(XAxisLabel).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  BinCount: ").Append(BinCount).Append("\n");
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
            return this.Equals(input as HistogramViewProperties);
        }

        /// <summary>
        /// Returns true if HistogramViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of HistogramViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistogramViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                ) && base.Equals(input) && 
                (
                    this.Shape == input.Shape ||
                    this.Shape.Equals(input.Shape)
                ) && base.Equals(input) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && base.Equals(input) && 
                (
                    this.ShowNoteWhenEmpty == input.ShowNoteWhenEmpty ||
                    (this.ShowNoteWhenEmpty != null &&
                    this.ShowNoteWhenEmpty.Equals(input.ShowNoteWhenEmpty))
                ) && base.Equals(input) && 
                (
                    this.XColumn == input.XColumn ||
                    (this.XColumn != null &&
                    this.XColumn.Equals(input.XColumn))
                ) && base.Equals(input) && 
                (
                    this.FillColumns == input.FillColumns ||
                    this.FillColumns != null &&
                    this.FillColumns.SequenceEqual(input.FillColumns)
                ) && base.Equals(input) && 
                (
                    this.XDomain == input.XDomain ||
                    this.XDomain != null &&
                    this.XDomain.SequenceEqual(input.XDomain)
                ) && base.Equals(input) && 
                (
                    this.XAxisLabel == input.XAxisLabel ||
                    (this.XAxisLabel != null &&
                    this.XAxisLabel.Equals(input.XAxisLabel))
                ) && base.Equals(input) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && base.Equals(input) && 
                (
                    this.BinCount == input.BinCount ||
                    (this.BinCount != null &&
                    this.BinCount.Equals(input.BinCount))
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
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.ShowNoteWhenEmpty != null)
                    hashCode = hashCode * 59 + this.ShowNoteWhenEmpty.GetHashCode();
                if (this.XColumn != null)
                    hashCode = hashCode * 59 + this.XColumn.GetHashCode();
                if (this.FillColumns != null)
                    hashCode = hashCode * 59 + this.FillColumns.GetHashCode();
                if (this.XDomain != null)
                    hashCode = hashCode * 59 + this.XDomain.GetHashCode();
                if (this.XAxisLabel != null)
                    hashCode = hashCode * 59 + this.XAxisLabel.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.BinCount != null)
                    hashCode = hashCode * 59 + this.BinCount.GetHashCode();
                return hashCode;
            }
        }

    }

}

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
    /// Describes a field that can be renamed and made visible or invisible.
    /// </summary>
    [DataContract]
    public partial class RenamableField :  IEquatable<RenamableField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenamableField" /> class.
        /// </summary>
        /// <param name="displayName">The name that a field is renamed to by the user..</param>
        /// <param name="visible">Indicates whether this field should be visible on the table..</param>
        public RenamableField(string displayName = default(string), bool? visible = default(bool?))
        {
            this.DisplayName = displayName;
            this.Visible = visible;
        }

        /// <summary>
        /// The calculated name of a field.
        /// </summary>
        /// <value>The calculated name of a field.</value>
        [DataMember(Name="internalName", EmitDefaultValue=false)]
        public string InternalName { get; private set; }

        /// <summary>
        /// The name that a field is renamed to by the user.
        /// </summary>
        /// <value>The name that a field is renamed to by the user.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates whether this field should be visible on the table.
        /// </summary>
        /// <value>Indicates whether this field should be visible on the table.</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenamableField {\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
            return this.Equals(input as RenamableField);
        }

        /// <summary>
        /// Returns true if RenamableField instances are equal
        /// </summary>
        /// <param name="input">Instance of RenamableField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenamableField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
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
                if (this.InternalName != null)
                    hashCode = hashCode * 59 + this.InternalName.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                return hashCode;
            }
        }

    }

}

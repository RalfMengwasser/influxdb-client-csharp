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
    /// PkgCreate
    /// </summary>
    [DataContract]
    public partial class PkgCreate :  IEquatable<PkgCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PkgCreate" /> class.
        /// </summary>
        /// <param name="pkgName">pkgName.</param>
        /// <param name="pkgDescription">pkgDescription.</param>
        /// <param name="pkgVersion">pkgVersion.</param>
        /// <param name="resources">resources.</param>
        public PkgCreate(string pkgName = default(string), string pkgDescription = default(string), string pkgVersion = default(string), PkgCreateResources resources = default(PkgCreateResources))
        {
            this.PkgName = pkgName;
            this.PkgDescription = pkgDescription;
            this.PkgVersion = pkgVersion;
            this.Resources = resources;
        }

        /// <summary>
        /// Gets or Sets PkgName
        /// </summary>
        [DataMember(Name="pkgName", EmitDefaultValue=false)]
        public string PkgName { get; set; }

        /// <summary>
        /// Gets or Sets PkgDescription
        /// </summary>
        [DataMember(Name="pkgDescription", EmitDefaultValue=false)]
        public string PkgDescription { get; set; }

        /// <summary>
        /// Gets or Sets PkgVersion
        /// </summary>
        [DataMember(Name="pkgVersion", EmitDefaultValue=false)]
        public string PkgVersion { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public PkgCreateResources Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PkgCreate {\n");
            sb.Append("  PkgName: ").Append(PkgName).Append("\n");
            sb.Append("  PkgDescription: ").Append(PkgDescription).Append("\n");
            sb.Append("  PkgVersion: ").Append(PkgVersion).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as PkgCreate);
        }

        /// <summary>
        /// Returns true if PkgCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of PkgCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkgCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PkgName == input.PkgName ||
                    (this.PkgName != null &&
                    this.PkgName.Equals(input.PkgName))
                ) && 
                (
                    this.PkgDescription == input.PkgDescription ||
                    (this.PkgDescription != null &&
                    this.PkgDescription.Equals(input.PkgDescription))
                ) && 
                (
                    this.PkgVersion == input.PkgVersion ||
                    (this.PkgVersion != null &&
                    this.PkgVersion.Equals(input.PkgVersion))
                ) && 
                (
                    
                    (this.Resources != null &&
                    this.Resources.Equals(input.Resources))
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
                if (this.PkgName != null)
                    hashCode = hashCode * 59 + this.PkgName.GetHashCode();
                if (this.PkgDescription != null)
                    hashCode = hashCode * 59 + this.PkgDescription.GetHashCode();
                if (this.PkgVersion != null)
                    hashCode = hashCode * 59 + this.PkgVersion.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }

    }

}

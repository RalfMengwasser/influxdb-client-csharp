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
    /// Buckets
    /// </summary>
    [DataContract]
    public partial class Buckets :  IEquatable<Buckets>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Buckets" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="buckets">buckets.</param>
        public Buckets(Links links = default(Links), List<Bucket> buckets = default(List<Bucket>))
        {
            this.Links = links;
            this._Buckets = buckets;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets _Buckets
        /// </summary>
        [DataMember(Name="buckets", EmitDefaultValue=false)]
        public List<Bucket> _Buckets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Buckets {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _Buckets: ").Append(_Buckets).Append("\n");
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
            return this.Equals(input as Buckets);
        }

        /// <summary>
        /// Returns true if Buckets instances are equal
        /// </summary>
        /// <param name="input">Instance of Buckets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Buckets input)
        {
            if (input == null)
                return false;

            return 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this._Buckets == input._Buckets ||
                    this._Buckets != null &&
                    this._Buckets.SequenceEqual(input._Buckets)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this._Buckets != null)
                    hashCode = hashCode * 59 + this._Buckets.GetHashCode();
                return hashCode;
            }
        }

    }

}

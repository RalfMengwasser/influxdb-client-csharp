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
    /// ResourceOwner
    /// </summary>
    [DataContract]
    public partial class ResourceOwner : User,  IEquatable<ResourceOwner>
    {
        /// <summary>
        /// Defines Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum Owner for value: owner
            /// </summary>
            [EnumMember(Value = "owner")]
            Owner = 1

        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceOwner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceOwner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceOwner" /> class.
        /// </summary>
        /// <param name="role">role (default to RoleEnum.Owner).</param>
        public ResourceOwner(RoleEnum? role = RoleEnum.Owner, string oauthID = default(string), string name = default(string), StatusEnum? status = StatusEnum.Active, UserLinks links = default(UserLinks)) : base(oauthID, name, status, links)
        {
            // use default value if no "role" provided
            if (role == null)
            {
                this.Role = RoleEnum.Owner;
            }
            else
            {
                this.Role = role;
            }
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceOwner {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as ResourceOwner);
        }

        /// <summary>
        /// Returns true if ResourceOwner instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceOwner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceOwner input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                return hashCode;
            }
        }

    }

}

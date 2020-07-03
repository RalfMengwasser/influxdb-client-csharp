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
    /// SlackNotificationRule
    /// </summary>
    [DataContract]
    public partial class SlackNotificationRule : SlackNotificationRuleBase,  IEquatable<SlackNotificationRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackNotificationRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SlackNotificationRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackNotificationRule" /> class.
        /// </summary>
        public SlackNotificationRule(TypeEnum type = default(TypeEnum), string channel = default(string), string messageTemplate = default(string)) : base(type, channel, messageTemplate)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlackNotificationRule {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as SlackNotificationRule);
        }

        /// <summary>
        /// Returns true if SlackNotificationRule instances are equal
        /// </summary>
        /// <param name="input">Instance of SlackNotificationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlackNotificationRule input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
                return hashCode;
            }
        }

    }

}

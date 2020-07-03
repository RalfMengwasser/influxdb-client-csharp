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
    /// PagerDutyNotificationRule
    /// </summary>
    [DataContract]
    public partial class PagerDutyNotificationRule : PagerDutyNotificationRuleBase,  IEquatable<PagerDutyNotificationRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagerDutyNotificationRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PagerDutyNotificationRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PagerDutyNotificationRule" /> class.
        /// </summary>
        public PagerDutyNotificationRule(TypeEnum type = default(TypeEnum), string messageTemplate = default(string)) : base(type, messageTemplate)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PagerDutyNotificationRule {\n");
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
            return this.Equals(input as PagerDutyNotificationRule);
        }

        /// <summary>
        /// Returns true if PagerDutyNotificationRule instances are equal
        /// </summary>
        /// <param name="input">Instance of PagerDutyNotificationRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagerDutyNotificationRule input)
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

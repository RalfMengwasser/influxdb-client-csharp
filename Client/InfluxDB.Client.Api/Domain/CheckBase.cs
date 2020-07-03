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
    /// CheckBase
    /// </summary>
    [DataContract]
    public partial class CheckBase : CheckDiscriminator,  IEquatable<CheckBase>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public TaskStatusType? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBase" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="orgID">The ID of the organization that owns this check. (required).</param>
        /// <param name="query">query (required).</param>
        /// <param name="status">status.</param>
        /// <param name="every">Check repetition interval..</param>
        /// <param name="offset">Duration to delay after the schedule, before executing check..</param>
        /// <param name="tags">List of tags to write to each status..</param>
        /// <param name="description">An optional description of the check..</param>
        /// <param name="statusMessageTemplate">The template used to generate and write a status message..</param>
        /// <param name="labels">labels.</param>
        /// <param name="links">links.</param>
        public CheckBase(string name = default(string), string orgID = default(string), DashboardQuery query = default(DashboardQuery), TaskStatusType? status = default(TaskStatusType?), string every = default(string), string offset = default(string), List<CheckBaseTags> tags = default(List<CheckBaseTags>), string description = default(string), string statusMessageTemplate = default(string), List<Label> labels = default(List<Label>), CheckBaseLinks links = default(CheckBaseLinks)) : base()
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CheckBase and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException("orgID is a required property for CheckBase and cannot be null");
            }
            else
            {
                this.OrgID = orgID;
            }
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for CheckBase and cannot be null");
            }
            else
            {
                this.Query = query;
            }
            this.Status = status;
            this.Every = every;
            this.Offset = offset;
            this.Tags = tags;
            this.Description = description;
            this.StatusMessageTemplate = statusMessageTemplate;
            this.Labels = labels;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the organization that owns this check.
        /// </summary>
        /// <value>The ID of the organization that owns this check.</value>
        [DataMember(Name="orgID", EmitDefaultValue=false)]
        public string OrgID { get; set; }

        /// <summary>
        /// The ID of creator used to create this check.
        /// </summary>
        /// <value>The ID of creator used to create this check.</value>
        [DataMember(Name="ownerID", EmitDefaultValue=false)]
        public string OwnerID { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public DashboardQuery Query { get; set; }


        /// <summary>
        /// Check repetition interval.
        /// </summary>
        /// <value>Check repetition interval.</value>
        [DataMember(Name="every", EmitDefaultValue=false)]
        public string Every { get; set; }

        /// <summary>
        /// Duration to delay after the schedule, before executing check.
        /// </summary>
        /// <value>Duration to delay after the schedule, before executing check.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public string Offset { get; set; }

        /// <summary>
        /// List of tags to write to each status.
        /// </summary>
        /// <value>List of tags to write to each status.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<CheckBaseTags> Tags { get; set; }

        /// <summary>
        /// An optional description of the check.
        /// </summary>
        /// <value>An optional description of the check.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The template used to generate and write a status message.
        /// </summary>
        /// <value>The template used to generate and write a status message.</value>
        [DataMember(Name="statusMessageTemplate", EmitDefaultValue=false)]
        public string StatusMessageTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public CheckBaseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckBase {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  OwnerID: ").Append(OwnerID).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Every: ").Append(Every).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StatusMessageTemplate: ").Append(StatusMessageTemplate).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as CheckBase);
        }

        /// <summary>
        /// Returns true if CheckBase instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckBase input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.OrgID == input.OrgID ||
                    (this.OrgID != null &&
                    this.OrgID.Equals(input.OrgID))
                ) && base.Equals(input) && 
                (
                    this.OwnerID == input.OwnerID ||
                    (this.OwnerID != null &&
                    this.OwnerID.Equals(input.OwnerID))
                ) && base.Equals(input) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && base.Equals(input) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && base.Equals(input) && 
                (
                    
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Every == input.Every ||
                    (this.Every != null &&
                    this.Every.Equals(input.Every))
                ) && base.Equals(input) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && base.Equals(input) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.StatusMessageTemplate == input.StatusMessageTemplate ||
                    (this.StatusMessageTemplate != null &&
                    this.StatusMessageTemplate.Equals(input.StatusMessageTemplate))
                ) && base.Equals(input) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && base.Equals(input) && 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrgID != null)
                    hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.OwnerID != null)
                    hashCode = hashCode * 59 + this.OwnerID.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Every != null)
                    hashCode = hashCode * 59 + this.Every.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StatusMessageTemplate != null)
                    hashCode = hashCode * 59 + this.StatusMessageTemplate.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }

}

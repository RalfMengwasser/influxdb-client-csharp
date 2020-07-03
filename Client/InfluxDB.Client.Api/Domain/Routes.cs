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
    /// Routes
    /// </summary>
    [DataContract]
    public partial class Routes :  IEquatable<Routes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Routes" /> class.
        /// </summary>
        /// <param name="authorizations">authorizations.</param>
        /// <param name="buckets">buckets.</param>
        /// <param name="dashboards">dashboards.</param>
        /// <param name="external">external.</param>
        /// <param name="variables">variables.</param>
        /// <param name="me">me.</param>
        /// <param name="orgs">orgs.</param>
        /// <param name="query">query.</param>
        /// <param name="setup">setup.</param>
        /// <param name="signin">signin.</param>
        /// <param name="signout">signout.</param>
        /// <param name="sources">sources.</param>
        /// <param name="system">system.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="telegrafs">telegrafs.</param>
        /// <param name="users">users.</param>
        /// <param name="write">write.</param>
        public Routes(string authorizations = default(string), string buckets = default(string), string dashboards = default(string), RoutesExternal external = default(RoutesExternal), string variables = default(string), string me = default(string), string orgs = default(string), RoutesQuery query = default(RoutesQuery), string setup = default(string), string signin = default(string), string signout = default(string), string sources = default(string), RoutesSystem system = default(RoutesSystem), string tasks = default(string), string telegrafs = default(string), string users = default(string), string write = default(string))
        {
            this.Authorizations = authorizations;
            this.Buckets = buckets;
            this.Dashboards = dashboards;
            this.External = external;
            this.Variables = variables;
            this.Me = me;
            this.Orgs = orgs;
            this.Query = query;
            this.Setup = setup;
            this.Signin = signin;
            this.Signout = signout;
            this.Sources = sources;
            this.System = system;
            this.Tasks = tasks;
            this.Telegrafs = telegrafs;
            this.Users = users;
            this.Write = write;
        }

        /// <summary>
        /// Gets or Sets Authorizations
        /// </summary>
        [DataMember(Name="authorizations", EmitDefaultValue=false)]
        public string Authorizations { get; set; }

        /// <summary>
        /// Gets or Sets Buckets
        /// </summary>
        [DataMember(Name="buckets", EmitDefaultValue=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// Gets or Sets Dashboards
        /// </summary>
        [DataMember(Name="dashboards", EmitDefaultValue=false)]
        public string Dashboards { get; set; }

        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name="external", EmitDefaultValue=false)]
        public RoutesExternal External { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public string Variables { get; set; }

        /// <summary>
        /// Gets or Sets Me
        /// </summary>
        [DataMember(Name="me", EmitDefaultValue=false)]
        public string Me { get; set; }

        /// <summary>
        /// Gets or Sets Orgs
        /// </summary>
        [DataMember(Name="orgs", EmitDefaultValue=false)]
        public string Orgs { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public RoutesQuery Query { get; set; }

        /// <summary>
        /// Gets or Sets Setup
        /// </summary>
        [DataMember(Name="setup", EmitDefaultValue=false)]
        public string Setup { get; set; }

        /// <summary>
        /// Gets or Sets Signin
        /// </summary>
        [DataMember(Name="signin", EmitDefaultValue=false)]
        public string Signin { get; set; }

        /// <summary>
        /// Gets or Sets Signout
        /// </summary>
        [DataMember(Name="signout", EmitDefaultValue=false)]
        public string Signout { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public string Sources { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public RoutesSystem System { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        public string Tasks { get; set; }

        /// <summary>
        /// Gets or Sets Telegrafs
        /// </summary>
        [DataMember(Name="telegrafs", EmitDefaultValue=false)]
        public string Telegrafs { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public string Users { get; set; }

        /// <summary>
        /// Gets or Sets Write
        /// </summary>
        [DataMember(Name="write", EmitDefaultValue=false)]
        public string Write { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Routes {\n");
            sb.Append("  Authorizations: ").Append(Authorizations).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
            sb.Append("  Dashboards: ").Append(Dashboards).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Me: ").Append(Me).Append("\n");
            sb.Append("  Orgs: ").Append(Orgs).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Signin: ").Append(Signin).Append("\n");
            sb.Append("  Signout: ").Append(Signout).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  Telegrafs: ").Append(Telegrafs).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Write: ").Append(Write).Append("\n");
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
            return this.Equals(input as Routes);
        }

        /// <summary>
        /// Returns true if Routes instances are equal
        /// </summary>
        /// <param name="input">Instance of Routes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Routes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorizations == input.Authorizations ||
                    (this.Authorizations != null &&
                    this.Authorizations.Equals(input.Authorizations))
                ) && 
                (
                    this.Buckets == input.Buckets ||
                    (this.Buckets != null &&
                    this.Buckets.Equals(input.Buckets))
                ) && 
                (
                    this.Dashboards == input.Dashboards ||
                    (this.Dashboards != null &&
                    this.Dashboards.Equals(input.Dashboards))
                ) && 
                (
                    
                    (this.External != null &&
                    this.External.Equals(input.External))
                ) && 
                (
                    this.Variables == input.Variables ||
                    (this.Variables != null &&
                    this.Variables.Equals(input.Variables))
                ) && 
                (
                    this.Me == input.Me ||
                    (this.Me != null &&
                    this.Me.Equals(input.Me))
                ) && 
                (
                    this.Orgs == input.Orgs ||
                    (this.Orgs != null &&
                    this.Orgs.Equals(input.Orgs))
                ) && 
                (
                    
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Setup == input.Setup ||
                    (this.Setup != null &&
                    this.Setup.Equals(input.Setup))
                ) && 
                (
                    this.Signin == input.Signin ||
                    (this.Signin != null &&
                    this.Signin.Equals(input.Signin))
                ) && 
                (
                    this.Signout == input.Signout ||
                    (this.Signout != null &&
                    this.Signout.Equals(input.Signout))
                ) && 
                (
                    this.Sources == input.Sources ||
                    (this.Sources != null &&
                    this.Sources.Equals(input.Sources))
                ) && 
                (
                    
                    (this.System != null &&
                    this.System.Equals(input.System))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    (this.Tasks != null &&
                    this.Tasks.Equals(input.Tasks))
                ) && 
                (
                    this.Telegrafs == input.Telegrafs ||
                    (this.Telegrafs != null &&
                    this.Telegrafs.Equals(input.Telegrafs))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.Write == input.Write ||
                    (this.Write != null &&
                    this.Write.Equals(input.Write))
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
                if (this.Authorizations != null)
                    hashCode = hashCode * 59 + this.Authorizations.GetHashCode();
                if (this.Buckets != null)
                    hashCode = hashCode * 59 + this.Buckets.GetHashCode();
                if (this.Dashboards != null)
                    hashCode = hashCode * 59 + this.Dashboards.GetHashCode();
                if (this.External != null)
                    hashCode = hashCode * 59 + this.External.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.Me != null)
                    hashCode = hashCode * 59 + this.Me.GetHashCode();
                if (this.Orgs != null)
                    hashCode = hashCode * 59 + this.Orgs.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Setup != null)
                    hashCode = hashCode * 59 + this.Setup.GetHashCode();
                if (this.Signin != null)
                    hashCode = hashCode * 59 + this.Signin.GetHashCode();
                if (this.Signout != null)
                    hashCode = hashCode * 59 + this.Signout.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.System != null)
                    hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.Telegrafs != null)
                    hashCode = hashCode * 59 + this.Telegrafs.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Write != null)
                    hashCode = hashCode * 59 + this.Write.GetHashCode();
                return hashCode;
            }
        }

    }

}

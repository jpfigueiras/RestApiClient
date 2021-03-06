using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// Entitlement feature record.
    /// </summary>
    [DataContract]
    public partial class Feature :  IEquatable<Feature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        /// <param name="Entitlment">Entitlment.</param>
        /// <param name="Enabled">Whether this entitlement is enabled for the user..</param>
        public Feature(string Entitlment = null, bool? Enabled = null)
        {
            
            
                        this.Entitlment = Entitlment;
            
                        this.Enabled = Enabled;
            
        }
        
        /// <summary>
        /// Gets or Sets Entitlment
        /// </summary>
        [DataMember(Name="entitlment", EmitDefaultValue=false)]
        public string Entitlment { get; set; }
        /// <summary>
        /// Whether this entitlement is enabled for the user.
        /// </summary>
        /// <value>Whether this entitlement is enabled for the user.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Feature {\n");
            sb.Append("  Entitlment: ").Append(Entitlment).Append("\n");
sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Feature);
        }

        /// <summary>
        /// Returns true if Feature instances are equal
        /// </summary>
        /// <param name="other">Instance of Feature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Feature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Entitlment == other.Entitlment ||
                    this.Entitlment != null &&
                    this.Entitlment.Equals(other.Entitlment)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Entitlment != null)
                    hash = hash * 59 + this.Entitlment.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                return hash;
            }
        }
    }

}

﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
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
    /// Health information about the Integration Bridge
    /// </summary>
    [DataContract]
    public partial class IntegrationBridgeHealth :  IEquatable<IntegrationBridgeHealth>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationBridgeHealth" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Capabilities">Capabilities.</param>
        public IntegrationBridgeHealth(string Status = null, string Version = null, List<string> Capabilities = null)
        {
            
            
                        this.Status = Status;
            
                        this.Version = Version;
            
                        this.Capabilities = Capabilities;
            
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<string> Capabilities { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationBridgeHealth {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
sb.Append("  Version: ").Append(Version).Append("\n");
sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
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
            return this.Equals(obj as IntegrationBridgeHealth);
        }

        /// <summary>
        /// Returns true if IntegrationBridgeHealth instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationBridgeHealth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationBridgeHealth other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(other.Capabilities)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                return hash;
            }
        }
    }

}

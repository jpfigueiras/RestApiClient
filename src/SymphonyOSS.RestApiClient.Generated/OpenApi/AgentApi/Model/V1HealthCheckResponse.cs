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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// V1HealthCheckResponse
    /// </summary>
    [DataContract]
    public partial class V1HealthCheckResponse :  IEquatable<V1HealthCheckResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HealthCheckResponse" /> class.
        /// </summary>
        /// <param name="PodConnectivity">Indicates whether the Agent server can connect to the Pod.</param>
        /// <param name="PodConnectivityError">Error details in case of no Pod connectivity.</param>
        /// <param name="KeyManagerConnectivity">Indicates whether the Agent server can connect to the Key Manager.</param>
        /// <param name="KeyManagerConnectivityError">Error details in case of no Key Manager connectivity.</param>
        /// <param name="Version">The version number of the Agent server.</param>
        public V1HealthCheckResponse(bool? PodConnectivity = null, string PodConnectivityError = null, bool? KeyManagerConnectivity = null, string KeyManagerConnectivityError = null, string Version = null)
        {
            
            
                        this.PodConnectivity = PodConnectivity;
            
                        this.PodConnectivityError = PodConnectivityError;
            
                        this.KeyManagerConnectivity = KeyManagerConnectivity;
            
                        this.KeyManagerConnectivityError = KeyManagerConnectivityError;
            
                        this.Version = Version;
            
        }
        
        /// <summary>
        /// Indicates whether the Agent server can connect to the Pod
        /// </summary>
        /// <value>Indicates whether the Agent server can connect to the Pod</value>
        [DataMember(Name="podConnectivity", EmitDefaultValue=false)]
        public bool? PodConnectivity { get; set; }
        /// <summary>
        /// Error details in case of no Pod connectivity
        /// </summary>
        /// <value>Error details in case of no Pod connectivity</value>
        [DataMember(Name="podConnectivityError", EmitDefaultValue=false)]
        public string PodConnectivityError { get; set; }
        /// <summary>
        /// Indicates whether the Agent server can connect to the Key Manager
        /// </summary>
        /// <value>Indicates whether the Agent server can connect to the Key Manager</value>
        [DataMember(Name="keyManagerConnectivity", EmitDefaultValue=false)]
        public bool? KeyManagerConnectivity { get; set; }
        /// <summary>
        /// Error details in case of no Key Manager connectivity
        /// </summary>
        /// <value>Error details in case of no Key Manager connectivity</value>
        [DataMember(Name="keyManagerConnectivityError", EmitDefaultValue=false)]
        public string KeyManagerConnectivityError { get; set; }
        /// <summary>
        /// The version number of the Agent server
        /// </summary>
        /// <value>The version number of the Agent server</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1HealthCheckResponse {\n");
            sb.Append("  PodConnectivity: ").Append(PodConnectivity).Append("\n");
sb.Append("  PodConnectivityError: ").Append(PodConnectivityError).Append("\n");
sb.Append("  KeyManagerConnectivity: ").Append(KeyManagerConnectivity).Append("\n");
sb.Append("  KeyManagerConnectivityError: ").Append(KeyManagerConnectivityError).Append("\n");
sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as V1HealthCheckResponse);
        }

        /// <summary>
        /// Returns true if V1HealthCheckResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of V1HealthCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1HealthCheckResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PodConnectivity == other.PodConnectivity ||
                    this.PodConnectivity != null &&
                    this.PodConnectivity.Equals(other.PodConnectivity)
                ) && 
                (
                    this.PodConnectivityError == other.PodConnectivityError ||
                    this.PodConnectivityError != null &&
                    this.PodConnectivityError.Equals(other.PodConnectivityError)
                ) && 
                (
                    this.KeyManagerConnectivity == other.KeyManagerConnectivity ||
                    this.KeyManagerConnectivity != null &&
                    this.KeyManagerConnectivity.Equals(other.KeyManagerConnectivity)
                ) && 
                (
                    this.KeyManagerConnectivityError == other.KeyManagerConnectivityError ||
                    this.KeyManagerConnectivityError != null &&
                    this.KeyManagerConnectivityError.Equals(other.KeyManagerConnectivityError)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.PodConnectivity != null)
                    hash = hash * 59 + this.PodConnectivity.GetHashCode();
                if (this.PodConnectivityError != null)
                    hash = hash * 59 + this.PodConnectivityError.GetHashCode();
                if (this.KeyManagerConnectivity != null)
                    hash = hash * 59 + this.KeyManagerConnectivity.GetHashCode();
                if (this.KeyManagerConnectivityError != null)
                    hash = hash * 59 + this.KeyManagerConnectivityError.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }
    }

}

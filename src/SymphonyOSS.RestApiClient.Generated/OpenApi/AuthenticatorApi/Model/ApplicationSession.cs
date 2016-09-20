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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Model
{
    /// <summary>
    /// ApplicationSession
    /// </summary>
    [DataContract]
    public partial class ApplicationSession :  IEquatable<ApplicationSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSession" /> class.
        /// </summary>
        /// <param name="AppInstanceId">The ID that uniquely identifies this application in the context of a\nspecific user.\n.</param>
        /// <param name="AppToken">This token generated by the application when calling Symphony\n.</param>
        /// <param name="VerificationToken">This token should be used by the application to verify it&#39;s talking to Symphony.\nFor example, when challenged by the application, Symphony should return this token..</param>
        public ApplicationSession(string AppInstanceId = null, string AppToken = null, string VerificationToken = null)
        {
            
            
                        this.AppInstanceId = AppInstanceId;
            
                        this.AppToken = AppToken;
            
                        this.VerificationToken = VerificationToken;
            
        }
        
        /// <summary>
        /// The ID that uniquely identifies this application in the context of a\nspecific user.\n
        /// </summary>
        /// <value>The ID that uniquely identifies this application in the context of a\nspecific user.\n</value>
        [DataMember(Name="appInstanceId", EmitDefaultValue=false)]
        public string AppInstanceId { get; set; }
        /// <summary>
        /// This token generated by the application when calling Symphony\n
        /// </summary>
        /// <value>This token generated by the application when calling Symphony\n</value>
        [DataMember(Name="appToken", EmitDefaultValue=false)]
        public string AppToken { get; set; }
        /// <summary>
        /// This token should be used by the application to verify it&#39;s talking to Symphony.\nFor example, when challenged by the application, Symphony should return this token.
        /// </summary>
        /// <value>This token should be used by the application to verify it&#39;s talking to Symphony.\nFor example, when challenged by the application, Symphony should return this token.</value>
        [DataMember(Name="verificationToken", EmitDefaultValue=false)]
        public string VerificationToken { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationSession {\n");
            sb.Append("  AppInstanceId: ").Append(AppInstanceId).Append("\n");
sb.Append("  AppToken: ").Append(AppToken).Append("\n");
sb.Append("  VerificationToken: ").Append(VerificationToken).Append("\n");
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
            return this.Equals(obj as ApplicationSession);
        }

        /// <summary>
        /// Returns true if ApplicationSession instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AppInstanceId == other.AppInstanceId ||
                    this.AppInstanceId != null &&
                    this.AppInstanceId.Equals(other.AppInstanceId)
                ) && 
                (
                    this.AppToken == other.AppToken ||
                    this.AppToken != null &&
                    this.AppToken.Equals(other.AppToken)
                ) && 
                (
                    this.VerificationToken == other.VerificationToken ||
                    this.VerificationToken != null &&
                    this.VerificationToken.Equals(other.VerificationToken)
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
                if (this.AppInstanceId != null)
                    hash = hash * 59 + this.AppInstanceId.GetHashCode();
                if (this.AppToken != null)
                    hash = hash * 59 + this.AppToken.GetHashCode();
                if (this.VerificationToken != null)
                    hash = hash * 59 + this.VerificationToken.GetHashCode();
                return hash;
            }
        }
    }

}

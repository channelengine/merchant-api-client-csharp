/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;

namespace ChannelEngine.Api.Client.Model
{
    /// <summary>
    /// MerchantShipmentTrackingRequest
    /// </summary>
    [DataContract]
    public partial class MerchantShipmentTrackingRequest :  IEquatable<MerchantShipmentTrackingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentTrackingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantShipmentTrackingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentTrackingRequest" /> class.
        /// </summary>
        /// <param name="Method">Method (required).</param>
        /// <param name="TrackTraceNo">TrackTraceNo (required).</param>
        /// <param name="TrackTraceUrl">TrackTraceUrl.</param>
        public MerchantShipmentTrackingRequest(string Method = default(string), string TrackTraceNo = default(string), string TrackTraceUrl = default(string))
        {
            // to ensure "Method" is required (not null)
            if (Method == null)
            {
                throw new InvalidDataException("Method is a required property for MerchantShipmentTrackingRequest and cannot be null");
            }
            else
            {
                this.Method = Method;
            }
            // to ensure "TrackTraceNo" is required (not null)
            if (TrackTraceNo == null)
            {
                throw new InvalidDataException("TrackTraceNo is a required property for MerchantShipmentTrackingRequest and cannot be null");
            }
            else
            {
                this.TrackTraceNo = TrackTraceNo;
            }
            this.TrackTraceUrl = TrackTraceUrl;
        }
        
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="Method", EmitDefaultValue=false)]
        public string Method { get; set; }
        /// <summary>
        /// Gets or Sets TrackTraceNo
        /// </summary>
        [DataMember(Name="TrackTraceNo", EmitDefaultValue=false)]
        public string TrackTraceNo { get; set; }
        /// <summary>
        /// Gets or Sets TrackTraceUrl
        /// </summary>
        [DataMember(Name="TrackTraceUrl", EmitDefaultValue=false)]
        public string TrackTraceUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantShipmentTrackingRequest {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  TrackTraceNo: ").Append(TrackTraceNo).Append("\n");
            sb.Append("  TrackTraceUrl: ").Append(TrackTraceUrl).Append("\n");
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
            return this.Equals(obj as MerchantShipmentTrackingRequest);
        }

        /// <summary>
        /// Returns true if MerchantShipmentTrackingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MerchantShipmentTrackingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShipmentTrackingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.TrackTraceNo == other.TrackTraceNo ||
                    this.TrackTraceNo != null &&
                    this.TrackTraceNo.Equals(other.TrackTraceNo)
                ) && 
                (
                    this.TrackTraceUrl == other.TrackTraceUrl ||
                    this.TrackTraceUrl != null &&
                    this.TrackTraceUrl.Equals(other.TrackTraceUrl)
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
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.TrackTraceNo != null)
                    hash = hash * 59 + this.TrackTraceNo.GetHashCode();
                if (this.TrackTraceUrl != null)
                    hash = hash * 59 + this.TrackTraceUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Method (string) maxLength
            if(this.Method != null && this.Method.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Method, length must be less than 50.", new [] { "Method" });
            }

            // Method (string) minLength
            if(this.Method != null && this.Method.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Method, length must be greater than 0.", new [] { "Method" });
            }

            // TrackTraceNo (string) maxLength
            if(this.TrackTraceNo != null && this.TrackTraceNo.Length > 50)
            {
                yield return new ValidationResult("Invalid value for TrackTraceNo, length must be less than 50.", new [] { "TrackTraceNo" });
            }

            // TrackTraceNo (string) minLength
            if(this.TrackTraceNo != null && this.TrackTraceNo.Length < 0)
            {
                yield return new ValidationResult("Invalid value for TrackTraceNo, length must be greater than 0.", new [] { "TrackTraceNo" });
            }

            // TrackTraceUrl (string) maxLength
            if(this.TrackTraceUrl != null && this.TrackTraceUrl.Length > 250)
            {
                yield return new ValidationResult("Invalid value for TrackTraceUrl, length must be less than 250.", new [] { "TrackTraceUrl" });
            }

            // TrackTraceUrl (string) minLength
            if(this.TrackTraceUrl != null && this.TrackTraceUrl.Length < 0)
            {
                yield return new ValidationResult("Invalid value for TrackTraceUrl, length must be greater than 0.", new [] { "TrackTraceUrl" });
            }

            yield break;
        }
    }

}
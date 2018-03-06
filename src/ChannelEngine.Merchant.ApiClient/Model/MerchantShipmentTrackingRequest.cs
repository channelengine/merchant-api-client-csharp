/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.6.0
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
using SwaggerDateConverter = ChannelEngine.Merchant.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
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
        /// <param name="method">method (required).</param>
        /// <param name="trackTraceNo">trackTraceNo (required).</param>
        /// <param name="trackTraceUrl">trackTraceUrl.</param>
        public MerchantShipmentTrackingRequest(string method = default(string), string trackTraceNo = default(string), string trackTraceUrl = default(string))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new InvalidDataException("method is a required property for MerchantShipmentTrackingRequest and cannot be null");
            }
            else
            {
                this.Method = method;
            }
            // to ensure "trackTraceNo" is required (not null)
            if (trackTraceNo == null)
            {
                throw new InvalidDataException("trackTraceNo is a required property for MerchantShipmentTrackingRequest and cannot be null");
            }
            else
            {
                this.TrackTraceNo = trackTraceNo;
            }
            this.TrackTraceUrl = trackTraceUrl;
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
            return this.Equals(input as MerchantShipmentTrackingRequest);
        }

        /// <summary>
        /// Returns true if MerchantShipmentTrackingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantShipmentTrackingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShipmentTrackingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.TrackTraceNo == input.TrackTraceNo ||
                    (this.TrackTraceNo != null &&
                    this.TrackTraceNo.Equals(input.TrackTraceNo))
                ) && 
                (
                    this.TrackTraceUrl == input.TrackTraceUrl ||
                    (this.TrackTraceUrl != null &&
                    this.TrackTraceUrl.Equals(input.TrackTraceUrl))
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
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.TrackTraceNo != null)
                    hashCode = hashCode * 59 + this.TrackTraceNo.GetHashCode();
                if (this.TrackTraceUrl != null)
                    hashCode = hashCode * 59 + this.TrackTraceUrl.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Method (string) maxLength
            if(this.Method != null && this.Method.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Method, length must be less than 50.", new [] { "Method" });
            }

            // Method (string) minLength
            if(this.Method != null && this.Method.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Method, length must be greater than 0.", new [] { "Method" });
            }

            // TrackTraceNo (string) maxLength
            if(this.TrackTraceNo != null && this.TrackTraceNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceNo, length must be less than 50.", new [] { "TrackTraceNo" });
            }

            // TrackTraceNo (string) minLength
            if(this.TrackTraceNo != null && this.TrackTraceNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceNo, length must be greater than 0.", new [] { "TrackTraceNo" });
            }

            // TrackTraceUrl (string) maxLength
            if(this.TrackTraceUrl != null && this.TrackTraceUrl.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceUrl, length must be less than 250.", new [] { "TrackTraceUrl" });
            }

            // TrackTraceUrl (string) minLength
            if(this.TrackTraceUrl != null && this.TrackTraceUrl.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceUrl, length must be greater than 0.", new [] { "TrackTraceUrl" });
            }

            yield break;
        }
    }

}
/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.3
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChannelEngine.Merchant.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// MerchantShipmentRequest
    /// </summary>
    [DataContract]
    public partial class MerchantShipmentRequest :  IEquatable<MerchantShipmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantShipmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentRequest" /> class.
        /// </summary>
        /// <param name="merchantShipmentNo">The unique shipment reference used by the Merchant. (required).</param>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant. (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="trackTraceNo">The unique shipping reference used by the Shipping carrier (track&amp;trace number)..</param>
        /// <param name="trackTraceUrl">A link to a page of the carrier where the customer can track the shipping of her package..</param>
        /// <param name="returnTrackTraceNo">The unique return shipping reference that may be used by the Shipping carrier (track &amp; trace number) if the shipment is returned..</param>
        /// <param name="method">Shipment method: the carrier used for shipping the package. E.g. DHL, postNL..</param>
        public MerchantShipmentRequest(string merchantShipmentNo = default(string), string merchantOrderNo = default(string), List<MerchantShipmentLineRequest> lines = default(List<MerchantShipmentLineRequest>), string trackTraceNo = default(string), string trackTraceUrl = default(string), string returnTrackTraceNo = default(string), string method = default(string))
        {
            // to ensure "merchantShipmentNo" is required (not null)
            this.MerchantShipmentNo = merchantShipmentNo ?? throw new ArgumentNullException("merchantShipmentNo is a required property for MerchantShipmentRequest and cannot be null");
            // to ensure "merchantOrderNo" is required (not null)
            this.MerchantOrderNo = merchantOrderNo ?? throw new ArgumentNullException("merchantOrderNo is a required property for MerchantShipmentRequest and cannot be null");
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for MerchantShipmentRequest and cannot be null");
            this.TrackTraceNo = trackTraceNo;
            this.TrackTraceUrl = trackTraceUrl;
            this.ReturnTrackTraceNo = returnTrackTraceNo;
            this.Method = method;
        }
        
        /// <summary>
        /// The unique shipment reference used by the Merchant.
        /// </summary>
        /// <value>The unique shipment reference used by the Merchant.</value>
        [DataMember(Name="MerchantShipmentNo", EmitDefaultValue=false)]
        public string MerchantShipmentNo { get; set; }

        /// <summary>
        /// The unique order reference used by the Merchant.
        /// </summary>
        /// <value>The unique order reference used by the Merchant.</value>
        [DataMember(Name="MerchantOrderNo", EmitDefaultValue=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<MerchantShipmentLineRequest> Lines { get; set; }

        /// <summary>
        /// The unique shipping reference used by the Shipping carrier (track&amp;trace number).
        /// </summary>
        /// <value>The unique shipping reference used by the Shipping carrier (track&amp;trace number).</value>
        [DataMember(Name="TrackTraceNo", EmitDefaultValue=true)]
        public string TrackTraceNo { get; set; }

        /// <summary>
        /// A link to a page of the carrier where the customer can track the shipping of her package.
        /// </summary>
        /// <value>A link to a page of the carrier where the customer can track the shipping of her package.</value>
        [DataMember(Name="TrackTraceUrl", EmitDefaultValue=true)]
        public string TrackTraceUrl { get; set; }

        /// <summary>
        /// The unique return shipping reference that may be used by the Shipping carrier (track &amp; trace number) if the shipment is returned.
        /// </summary>
        /// <value>The unique return shipping reference that may be used by the Shipping carrier (track &amp; trace number) if the shipment is returned.</value>
        [DataMember(Name="ReturnTrackTraceNo", EmitDefaultValue=true)]
        public string ReturnTrackTraceNo { get; set; }

        /// <summary>
        /// Shipment method: the carrier used for shipping the package. E.g. DHL, postNL.
        /// </summary>
        /// <value>Shipment method: the carrier used for shipping the package. E.g. DHL, postNL.</value>
        [DataMember(Name="Method", EmitDefaultValue=true)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantShipmentRequest {\n");
            sb.Append("  MerchantShipmentNo: ").Append(MerchantShipmentNo).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  TrackTraceNo: ").Append(TrackTraceNo).Append("\n");
            sb.Append("  TrackTraceUrl: ").Append(TrackTraceUrl).Append("\n");
            sb.Append("  ReturnTrackTraceNo: ").Append(ReturnTrackTraceNo).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as MerchantShipmentRequest);
        }

        /// <summary>
        /// Returns true if MerchantShipmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantShipmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShipmentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantShipmentNo == input.MerchantShipmentNo ||
                    (this.MerchantShipmentNo != null &&
                    this.MerchantShipmentNo.Equals(input.MerchantShipmentNo))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                ) && 
                (
                    this.ReturnTrackTraceNo == input.ReturnTrackTraceNo ||
                    (this.ReturnTrackTraceNo != null &&
                    this.ReturnTrackTraceNo.Equals(input.ReturnTrackTraceNo))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.MerchantShipmentNo != null)
                    hashCode = hashCode * 59 + this.MerchantShipmentNo.GetHashCode();
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.TrackTraceNo != null)
                    hashCode = hashCode * 59 + this.TrackTraceNo.GetHashCode();
                if (this.TrackTraceUrl != null)
                    hashCode = hashCode * 59 + this.TrackTraceUrl.GetHashCode();
                if (this.ReturnTrackTraceNo != null)
                    hashCode = hashCode * 59 + this.ReturnTrackTraceNo.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
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

            // ReturnTrackTraceNo (string) maxLength
            if(this.ReturnTrackTraceNo != null && this.ReturnTrackTraceNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReturnTrackTraceNo, length must be less than 50.", new [] { "ReturnTrackTraceNo" });
            }

            // ReturnTrackTraceNo (string) minLength
            if(this.ReturnTrackTraceNo != null && this.ReturnTrackTraceNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReturnTrackTraceNo, length must be greater than 0.", new [] { "ReturnTrackTraceNo" });
            }

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

            yield break;
        }
    }

}

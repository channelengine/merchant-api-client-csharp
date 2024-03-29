/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.13.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChannelEngine.Merchant.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// MerchantChannelLabelShipmentRequest
    /// </summary>
    [DataContract(Name = "MerchantChannelLabelShipmentRequest")]
    public partial class MerchantChannelLabelShipmentRequest : IEquatable<MerchantChannelLabelShipmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantChannelLabelShipmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantChannelLabelShipmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantChannelLabelShipmentRequest" /> class.
        /// </summary>
        /// <param name="dimensions">dimensions (required).</param>
        /// <param name="weight">weight (required).</param>
        /// <param name="channelMethodCode">channelMethodCode (required).</param>
        /// <param name="merchantShipmentNo">The unique shipment reference used by the Merchant. (required).</param>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant. (required).</param>
        /// <param name="shippedFromCountryCode">The code of the country from where the package is being shipped..</param>
        /// <param name="lines">lines (required).</param>
        public MerchantChannelLabelShipmentRequest(MerchantShipmentPackageDimensionsRequest dimensions = default(MerchantShipmentPackageDimensionsRequest), MerchantShipmentPackageWeightRequest weight = default(MerchantShipmentPackageWeightRequest), string channelMethodCode = default(string), string merchantShipmentNo = default(string), string merchantOrderNo = default(string), string shippedFromCountryCode = default(string), List<MerchantShipmentLineRequest> lines = default(List<MerchantShipmentLineRequest>))
        {
            // to ensure "dimensions" is required (not null)
            if (dimensions == null) {
                throw new ArgumentNullException("dimensions is a required property for MerchantChannelLabelShipmentRequest and cannot be null");
            }
            this.Dimensions = dimensions;
            // to ensure "weight" is required (not null)
            if (weight == null) {
                throw new ArgumentNullException("weight is a required property for MerchantChannelLabelShipmentRequest and cannot be null");
            }
            this.Weight = weight;
            // to ensure "channelMethodCode" is required (not null)
            if (channelMethodCode == null) {
                throw new ArgumentNullException("channelMethodCode is a required property for MerchantChannelLabelShipmentRequest and cannot be null");
            }
            this.ChannelMethodCode = channelMethodCode;
            // to ensure "merchantShipmentNo" is required (not null)
            if (merchantShipmentNo == null) {
                throw new ArgumentNullException("merchantShipmentNo is a required property for MerchantChannelLabelShipmentRequest and cannot be null");
            }
            this.MerchantShipmentNo = merchantShipmentNo;
            // to ensure "merchantOrderNo" is required (not null)
            if (merchantOrderNo == null) {
                throw new ArgumentNullException("merchantOrderNo is a required property for MerchantChannelLabelShipmentRequest and cannot be null");
            }
            this.MerchantOrderNo = merchantOrderNo;
            // to ensure "lines" is required (not null)
            if (lines == null) {
                throw new ArgumentNullException("lines is a required property for MerchantChannelLabelShipmentRequest and cannot be null");
            }
            this.Lines = lines;
            this.ShippedFromCountryCode = shippedFromCountryCode;
        }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "Dimensions", IsRequired = true, EmitDefaultValue = false)]
        public MerchantShipmentPackageDimensionsRequest Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "Weight", IsRequired = true, EmitDefaultValue = false)]
        public MerchantShipmentPackageWeightRequest Weight { get; set; }

        /// <summary>
        /// Gets or Sets ChannelMethodCode
        /// </summary>
        [DataMember(Name = "ChannelMethodCode", IsRequired = true, EmitDefaultValue = false)]
        public string ChannelMethodCode { get; set; }

        /// <summary>
        /// The unique shipment reference used by the Merchant.
        /// </summary>
        /// <value>The unique shipment reference used by the Merchant.</value>
        [DataMember(Name = "MerchantShipmentNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantShipmentNo { get; set; }

        /// <summary>
        /// The unique order reference used by the Merchant.
        /// </summary>
        /// <value>The unique order reference used by the Merchant.</value>
        [DataMember(Name = "MerchantOrderNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The code of the country from where the package is being shipped.
        /// </summary>
        /// <value>The code of the country from where the package is being shipped.</value>
        [DataMember(Name = "ShippedFromCountryCode", EmitDefaultValue = true)]
        public string ShippedFromCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", IsRequired = true, EmitDefaultValue = false)]
        public List<MerchantShipmentLineRequest> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantChannelLabelShipmentRequest {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  ChannelMethodCode: ").Append(ChannelMethodCode).Append("\n");
            sb.Append("  MerchantShipmentNo: ").Append(MerchantShipmentNo).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  ShippedFromCountryCode: ").Append(ShippedFromCountryCode).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MerchantChannelLabelShipmentRequest);
        }

        /// <summary>
        /// Returns true if MerchantChannelLabelShipmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantChannelLabelShipmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantChannelLabelShipmentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.ChannelMethodCode == input.ChannelMethodCode ||
                    (this.ChannelMethodCode != null &&
                    this.ChannelMethodCode.Equals(input.ChannelMethodCode))
                ) && 
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
                    this.ShippedFromCountryCode == input.ShippedFromCountryCode ||
                    (this.ShippedFromCountryCode != null &&
                    this.ShippedFromCountryCode.Equals(input.ShippedFromCountryCode))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.ChannelMethodCode != null)
                    hashCode = hashCode * 59 + this.ChannelMethodCode.GetHashCode();
                if (this.MerchantShipmentNo != null)
                    hashCode = hashCode * 59 + this.MerchantShipmentNo.GetHashCode();
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.ShippedFromCountryCode != null)
                    hashCode = hashCode * 59 + this.ShippedFromCountryCode.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // MerchantShipmentNo (string) maxLength
            if(this.MerchantShipmentNo != null && this.MerchantShipmentNo.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantShipmentNo, length must be less than 250.", new [] { "MerchantShipmentNo" });
            }

            // MerchantShipmentNo (string) minLength
            if(this.MerchantShipmentNo != null && this.MerchantShipmentNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantShipmentNo, length must be greater than 0.", new [] { "MerchantShipmentNo" });
            }

            // MerchantOrderNo (string) maxLength
            if(this.MerchantOrderNo != null && this.MerchantOrderNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantOrderNo, length must be less than 50.", new [] { "MerchantOrderNo" });
            }

            // MerchantOrderNo (string) minLength
            if(this.MerchantOrderNo != null && this.MerchantOrderNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantOrderNo, length must be greater than 0.", new [] { "MerchantOrderNo" });
            }

            // ShippedFromCountryCode (string) maxLength
            if(this.ShippedFromCountryCode != null && this.ShippedFromCountryCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippedFromCountryCode, length must be less than 3.", new [] { "ShippedFromCountryCode" });
            }

            // ShippedFromCountryCode (string) minLength
            if(this.ShippedFromCountryCode != null && this.ShippedFromCountryCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippedFromCountryCode, length must be greater than 0.", new [] { "ShippedFromCountryCode" });
            }

            yield break;
        }
    }

}

/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.11
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
    /// MerchantCancellationRequest
    /// </summary>
    [DataContract(Name = "MerchantCancellationRequest")]
    public partial class MerchantCancellationRequest : IEquatable<MerchantCancellationRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name = "ReasonCode", EmitDefaultValue = false)]
        public MancoReason? ReasonCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCancellationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantCancellationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCancellationRequest" /> class.
        /// </summary>
        /// <param name="merchantCancellationNo">The unique cancellation reference used by the Merchant (sku). (required).</param>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant (sku). (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="reason">Reason for cancellation (text)..</param>
        /// <param name="reasonCode">reasonCode.</param>
        public MerchantCancellationRequest(string merchantCancellationNo = default(string), string merchantOrderNo = default(string), List<MerchantCancellationLineRequest> lines = default(List<MerchantCancellationLineRequest>), string reason = default(string), MancoReason? reasonCode = default(MancoReason?))
        {
            // to ensure "merchantCancellationNo" is required (not null)
            this.MerchantCancellationNo = merchantCancellationNo ?? throw new ArgumentNullException("merchantCancellationNo is a required property for MerchantCancellationRequest and cannot be null");
            // to ensure "merchantOrderNo" is required (not null)
            this.MerchantOrderNo = merchantOrderNo ?? throw new ArgumentNullException("merchantOrderNo is a required property for MerchantCancellationRequest and cannot be null");
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for MerchantCancellationRequest and cannot be null");
            this.Reason = reason;
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// The unique cancellation reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique cancellation reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantCancellationNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantCancellationNo { get; set; }

        /// <summary>
        /// The unique order reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique order reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantOrderNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", IsRequired = true, EmitDefaultValue = false)]
        public List<MerchantCancellationLineRequest> Lines { get; set; }

        /// <summary>
        /// Reason for cancellation (text).
        /// </summary>
        /// <value>Reason for cancellation (text).</value>
        [DataMember(Name = "Reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantCancellationRequest {\n");
            sb.Append("  MerchantCancellationNo: ").Append(MerchantCancellationNo).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
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
            return this.Equals(input as MerchantCancellationRequest);
        }

        /// <summary>
        /// Returns true if MerchantCancellationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantCancellationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantCancellationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantCancellationNo == input.MerchantCancellationNo ||
                    (this.MerchantCancellationNo != null &&
                    this.MerchantCancellationNo.Equals(input.MerchantCancellationNo))
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
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    this.ReasonCode.Equals(input.ReasonCode)
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
                if (this.MerchantCancellationNo != null)
                    hashCode = hashCode * 59 + this.MerchantCancellationNo.GetHashCode();
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
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
            // MerchantCancellationNo (string) maxLength
            if(this.MerchantCancellationNo != null && this.MerchantCancellationNo.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantCancellationNo, length must be less than 250.", new [] { "MerchantCancellationNo" });
            }

            // MerchantCancellationNo (string) minLength
            if(this.MerchantCancellationNo != null && this.MerchantCancellationNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantCancellationNo, length must be greater than 0.", new [] { "MerchantCancellationNo" });
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

            yield break;
        }
    }

}

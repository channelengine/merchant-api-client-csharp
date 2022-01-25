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
    /// MerchantReturnRequest
    /// </summary>
    [DataContract(Name = "MerchantReturnRequest")]
    public partial class MerchantReturnRequest : IEquatable<MerchantReturnRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "Reason", EmitDefaultValue = false)]
        public ReturnReason? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnRequest" /> class.
        /// </summary>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant (sku). (required).</param>
        /// <param name="merchantReturnNo">The unique return reference used by the Merchant (sku). (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="id">The unique return reference used by ChannelEngine..</param>
        /// <param name="reason">reason.</param>
        /// <param name="customerComment">Optional. Comment of customer on the (reason of) the return..</param>
        /// <param name="merchantComment">Optional. Comment of merchant on the return..</param>
        /// <param name="refundInclVat">Refund amount incl. VAT..</param>
        /// <param name="refundExclVat">Refund amount excl. VAT..</param>
        public MerchantReturnRequest(string merchantOrderNo = default(string), string merchantReturnNo = default(string), List<MerchantReturnLineRequest> lines = default(List<MerchantReturnLineRequest>), int id = default(int), ReturnReason? reason = default(ReturnReason?), string customerComment = default(string), string merchantComment = default(string), decimal refundInclVat = default(decimal), decimal refundExclVat = default(decimal))
        {
            // to ensure "merchantOrderNo" is required (not null)
            this.MerchantOrderNo = merchantOrderNo ?? throw new ArgumentNullException("merchantOrderNo is a required property for MerchantReturnRequest and cannot be null");
            // to ensure "merchantReturnNo" is required (not null)
            this.MerchantReturnNo = merchantReturnNo ?? throw new ArgumentNullException("merchantReturnNo is a required property for MerchantReturnRequest and cannot be null");
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for MerchantReturnRequest and cannot be null");
            this.Id = id;
            this.Reason = reason;
            this.CustomerComment = customerComment;
            this.MerchantComment = merchantComment;
            this.RefundInclVat = refundInclVat;
            this.RefundExclVat = refundExclVat;
        }

        /// <summary>
        /// The unique order reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique order reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantOrderNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The unique return reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique return reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantReturnNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantReturnNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", IsRequired = true, EmitDefaultValue = false)]
        public List<MerchantReturnLineRequest> Lines { get; set; }

        /// <summary>
        /// The unique return reference used by ChannelEngine.
        /// </summary>
        /// <value>The unique return reference used by ChannelEngine.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Optional. Comment of customer on the (reason of) the return.
        /// </summary>
        /// <value>Optional. Comment of customer on the (reason of) the return.</value>
        [DataMember(Name = "CustomerComment", EmitDefaultValue = true)]
        public string CustomerComment { get; set; }

        /// <summary>
        /// Optional. Comment of merchant on the return.
        /// </summary>
        /// <value>Optional. Comment of merchant on the return.</value>
        [DataMember(Name = "MerchantComment", EmitDefaultValue = true)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Refund amount incl. VAT.
        /// </summary>
        /// <value>Refund amount incl. VAT.</value>
        [DataMember(Name = "RefundInclVat", EmitDefaultValue = false)]
        public decimal RefundInclVat { get; set; }

        /// <summary>
        /// Refund amount excl. VAT.
        /// </summary>
        /// <value>Refund amount excl. VAT.</value>
        [DataMember(Name = "RefundExclVat", EmitDefaultValue = false)]
        public decimal RefundExclVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnRequest {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  MerchantReturnNo: ").Append(MerchantReturnNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  CustomerComment: ").Append(CustomerComment).Append("\n");
            sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
            sb.Append("  RefundInclVat: ").Append(RefundInclVat).Append("\n");
            sb.Append("  RefundExclVat: ").Append(RefundExclVat).Append("\n");
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
            return this.Equals(input as MerchantReturnRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.MerchantReturnNo == input.MerchantReturnNo ||
                    (this.MerchantReturnNo != null &&
                    this.MerchantReturnNo.Equals(input.MerchantReturnNo))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.CustomerComment == input.CustomerComment ||
                    (this.CustomerComment != null &&
                    this.CustomerComment.Equals(input.CustomerComment))
                ) && 
                (
                    this.MerchantComment == input.MerchantComment ||
                    (this.MerchantComment != null &&
                    this.MerchantComment.Equals(input.MerchantComment))
                ) && 
                (
                    this.RefundInclVat == input.RefundInclVat ||
                    this.RefundInclVat.Equals(input.RefundInclVat)
                ) && 
                (
                    this.RefundExclVat == input.RefundExclVat ||
                    this.RefundExclVat.Equals(input.RefundExclVat)
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
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.MerchantReturnNo != null)
                    hashCode = hashCode * 59 + this.MerchantReturnNo.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.CustomerComment != null)
                    hashCode = hashCode * 59 + this.CustomerComment.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
                hashCode = hashCode * 59 + this.RefundInclVat.GetHashCode();
                hashCode = hashCode * 59 + this.RefundExclVat.GetHashCode();
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

            // MerchantReturnNo (string) maxLength
            if(this.MerchantReturnNo != null && this.MerchantReturnNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantReturnNo, length must be less than 50.", new [] { "MerchantReturnNo" });
            }

            // MerchantReturnNo (string) minLength
            if(this.MerchantReturnNo != null && this.MerchantReturnNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantReturnNo, length must be greater than 0.", new [] { "MerchantReturnNo" });
            }

            // CustomerComment (string) maxLength
            if(this.CustomerComment != null && this.CustomerComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be less than 4001.", new [] { "CustomerComment" });
            }

            // CustomerComment (string) minLength
            if(this.CustomerComment != null && this.CustomerComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be greater than 0.", new [] { "CustomerComment" });
            }

            // MerchantComment (string) maxLength
            if(this.MerchantComment != null && this.MerchantComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be less than 4001.", new [] { "MerchantComment" });
            }

            // MerchantComment (string) minLength
            if(this.MerchantComment != null && this.MerchantComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be greater than 0.", new [] { "MerchantComment" });
            }

            // RefundInclVat (decimal) minimum
            if(this.RefundInclVat < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefundInclVat, must be a value greater than or equal to 0.", new [] { "RefundInclVat" });
            }

            // RefundExclVat (decimal) minimum
            if(this.RefundExclVat < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefundExclVat, must be a value greater than or equal to 0.", new [] { "RefundExclVat" });
            }

            yield break;
        }
    }

}

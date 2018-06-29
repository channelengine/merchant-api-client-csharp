/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.0.0
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
    /// MerchantReturnResponse
    /// </summary>
    [DataContract]
    public partial class MerchantReturnResponse :  IEquatable<MerchantReturnResponse>, IValidatableObject
    {
        /// <summary>
        /// The reason code of the return
        /// </summary>
        /// <value>The reason code of the return</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum PRODUCTDEFECT for value: PRODUCT_DEFECT
            /// </summary>
            [EnumMember(Value = "PRODUCT_DEFECT")]
            PRODUCTDEFECT = 1,
            
            /// <summary>
            /// Enum PRODUCTUNSATISFACTORY for value: PRODUCT_UNSATISFACTORY
            /// </summary>
            [EnumMember(Value = "PRODUCT_UNSATISFACTORY")]
            PRODUCTUNSATISFACTORY = 2,
            
            /// <summary>
            /// Enum WRONGPRODUCT for value: WRONG_PRODUCT
            /// </summary>
            [EnumMember(Value = "WRONG_PRODUCT")]
            WRONGPRODUCT = 3,
            
            /// <summary>
            /// Enum TOOMANYPRODUCTS for value: TOO_MANY_PRODUCTS
            /// </summary>
            [EnumMember(Value = "TOO_MANY_PRODUCTS")]
            TOOMANYPRODUCTS = 4,
            
            /// <summary>
            /// Enum REFUSED for value: REFUSED
            /// </summary>
            [EnumMember(Value = "REFUSED")]
            REFUSED = 5,
            
            /// <summary>
            /// Enum REFUSEDDAMAGED for value: REFUSED_DAMAGED
            /// </summary>
            [EnumMember(Value = "REFUSED_DAMAGED")]
            REFUSEDDAMAGED = 6,
            
            /// <summary>
            /// Enum WRONGADDRESS for value: WRONG_ADDRESS
            /// </summary>
            [EnumMember(Value = "WRONG_ADDRESS")]
            WRONGADDRESS = 7,
            
            /// <summary>
            /// Enum NOTCOLLECTED for value: NOT_COLLECTED
            /// </summary>
            [EnumMember(Value = "NOT_COLLECTED")]
            NOTCOLLECTED = 8,
            
            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 9
        }

        /// <summary>
        /// The reason code of the return
        /// </summary>
        /// <value>The reason code of the return</value>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnResponse" /> class.
        /// </summary>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant.</param>
        /// <param name="lines">lines.</param>
        /// <param name="id">The unique return reference used by ChannelEngine.</param>
        /// <param name="reason">The reason code of the return.</param>
        /// <param name="customerComment">Optional. Comment of customer on the (reason of) the return.</param>
        /// <param name="merchantComment">Optional. Comment of merchant on the return..</param>
        /// <param name="refundInclVat">Refund amount incl. VAT.</param>
        /// <param name="refundExclVat">Refund amount excl. VAT.</param>
        public MerchantReturnResponse(string merchantOrderNo = default(string), List<MerchantReturnLineResponse> lines = default(List<MerchantReturnLineResponse>), int? id = default(int?), ReasonEnum? reason = default(ReasonEnum?), string customerComment = default(string), string merchantComment = default(string), decimal? refundInclVat = default(decimal?), decimal? refundExclVat = default(decimal?))
        {
            this.MerchantOrderNo = merchantOrderNo;
            this.Lines = lines;
            this.Id = id;
            this.Reason = reason;
            this.CustomerComment = customerComment;
            this.MerchantComment = merchantComment;
            this.RefundInclVat = refundInclVat;
            this.RefundExclVat = refundExclVat;
        }
        
        /// <summary>
        /// The unique order reference used by the Merchant
        /// </summary>
        /// <value>The unique order reference used by the Merchant</value>
        [DataMember(Name="MerchantOrderNo", EmitDefaultValue=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<MerchantReturnLineResponse> Lines { get; set; }

        /// <summary>
        /// The unique return reference used by ChannelEngine
        /// </summary>
        /// <value>The unique return reference used by ChannelEngine</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Optional. Comment of customer on the (reason of) the return
        /// </summary>
        /// <value>Optional. Comment of customer on the (reason of) the return</value>
        [DataMember(Name="CustomerComment", EmitDefaultValue=false)]
        public string CustomerComment { get; set; }

        /// <summary>
        /// Optional. Comment of merchant on the return.
        /// </summary>
        /// <value>Optional. Comment of merchant on the return.</value>
        [DataMember(Name="MerchantComment", EmitDefaultValue=false)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Refund amount incl. VAT
        /// </summary>
        /// <value>Refund amount incl. VAT</value>
        [DataMember(Name="RefundInclVat", EmitDefaultValue=false)]
        public decimal? RefundInclVat { get; set; }

        /// <summary>
        /// Refund amount excl. VAT
        /// </summary>
        /// <value>Refund amount excl. VAT</value>
        [DataMember(Name="RefundExclVat", EmitDefaultValue=false)]
        public decimal? RefundExclVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnResponse {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MerchantReturnResponse);
        }

        /// <summary>
        /// Returns true if MerchantReturnResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnResponse input)
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
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                    (this.RefundInclVat != null &&
                    this.RefundInclVat.Equals(input.RefundInclVat))
                ) && 
                (
                    this.RefundExclVat == input.RefundExclVat ||
                    (this.RefundExclVat != null &&
                    this.RefundExclVat.Equals(input.RefundExclVat))
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
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.CustomerComment != null)
                    hashCode = hashCode * 59 + this.CustomerComment.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
                if (this.RefundInclVat != null)
                    hashCode = hashCode * 59 + this.RefundInclVat.GetHashCode();
                if (this.RefundExclVat != null)
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

            yield break;
        }
    }

}

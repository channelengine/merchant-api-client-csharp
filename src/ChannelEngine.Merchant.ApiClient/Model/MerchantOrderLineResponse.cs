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
    /// MerchantOrderLineResponse
    /// </summary>
    [DataContract]
    public partial class MerchantOrderLineResponse :  IEquatable<MerchantOrderLineResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum INPROGRESS for value: IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            INPROGRESS = 1,
            
            /// <summary>
            /// Enum SHIPPED for value: SHIPPED
            /// </summary>
            [EnumMember(Value = "SHIPPED")]
            SHIPPED = 2,
            
            /// <summary>
            /// Enum INBACKORDER for value: IN_BACKORDER
            /// </summary>
            [EnumMember(Value = "IN_BACKORDER")]
            INBACKORDER = 3,
            
            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED = 4,
            
            /// <summary>
            /// Enum MANCO for value: MANCO
            /// </summary>
            [EnumMember(Value = "MANCO")]
            MANCO = 5,
            
            /// <summary>
            /// Enum INCOMBI for value: IN_COMBI
            /// </summary>
            [EnumMember(Value = "IN_COMBI")]
            INCOMBI = 6,
            
            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED = 7,
            
            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW = 8,
            
            /// <summary>
            /// Enum RETURNED for value: RETURNED
            /// </summary>
            [EnumMember(Value = "RETURNED")]
            RETURNED = 9,
            
            /// <summary>
            /// Enum REQUIRESCORRECTION for value: REQUIRES_CORRECTION
            /// </summary>
            [EnumMember(Value = "REQUIRES_CORRECTION")]
            REQUIRESCORRECTION = 10
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The condition of the product, this can be used to indicate that a product is a second-hand product
        /// </summary>
        /// <value>The condition of the product, this can be used to indicate that a product is a second-hand product</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionEnum
        {
            
            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW = 1,
            
            /// <summary>
            /// Enum NEWREFURBISHED for value: NEW_REFURBISHED
            /// </summary>
            [EnumMember(Value = "NEW_REFURBISHED")]
            NEWREFURBISHED = 2,
            
            /// <summary>
            /// Enum USEDASNEW for value: USED_AS_NEW
            /// </summary>
            [EnumMember(Value = "USED_AS_NEW")]
            USEDASNEW = 3,
            
            /// <summary>
            /// Enum USEDGOOD for value: USED_GOOD
            /// </summary>
            [EnumMember(Value = "USED_GOOD")]
            USEDGOOD = 4,
            
            /// <summary>
            /// Enum USEDREASONABLE for value: USED_REASONABLE
            /// </summary>
            [EnumMember(Value = "USED_REASONABLE")]
            USEDREASONABLE = 5,
            
            /// <summary>
            /// Enum USEDMEDIOCRE for value: USED_MEDIOCRE
            /// </summary>
            [EnumMember(Value = "USED_MEDIOCRE")]
            USEDMEDIOCRE = 6,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 7
        }

        /// <summary>
        /// The condition of the product, this can be used to indicate that a product is a second-hand product
        /// </summary>
        /// <value>The condition of the product, this can be used to indicate that a product is a second-hand product</value>
        [DataMember(Name="Condition", EmitDefaultValue=false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderLineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantOrderLineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderLineResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="isFulfillmentByMarketplace">isFulfillmentByMarketplace.</param>
        /// <param name="merchantProductNo">merchantProductNo.</param>
        /// <param name="unitVat">The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="lineTotalInclVat">The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="lineVat">The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="originalUnitPriceInclVat">The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalUnitVat">The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalLineTotalInclVat">The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalLineVat">The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="channelProductNo">channelProductNo (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="unitPriceInclVat">The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering). (required).</param>
        /// <param name="feeFixed">A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable..</param>
        /// <param name="feeRate">A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable..</param>
        /// <param name="condition">The condition of the product, this can be used to indicate that a product is a second-hand product.</param>
        public MerchantOrderLineResponse(StatusEnum? status = default(StatusEnum?), bool? isFulfillmentByMarketplace = default(bool?), string merchantProductNo = default(string), double? unitVat = default(double?), double? lineTotalInclVat = default(double?), double? lineVat = default(double?), double? originalUnitPriceInclVat = default(double?), double? originalUnitVat = default(double?), double? originalLineTotalInclVat = default(double?), double? originalLineVat = default(double?), string channelProductNo = default(string), int? quantity = default(int?), double? unitPriceInclVat = default(double?), double? feeFixed = default(double?), double? feeRate = default(double?), ConditionEnum? condition = default(ConditionEnum?))
        {
            // to ensure "channelProductNo" is required (not null)
            if (channelProductNo == null)
            {
                throw new InvalidDataException("channelProductNo is a required property for MerchantOrderLineResponse and cannot be null");
            }
            else
            {
                this.ChannelProductNo = channelProductNo;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for MerchantOrderLineResponse and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "unitPriceInclVat" is required (not null)
            if (unitPriceInclVat == null)
            {
                throw new InvalidDataException("unitPriceInclVat is a required property for MerchantOrderLineResponse and cannot be null");
            }
            else
            {
                this.UnitPriceInclVat = unitPriceInclVat;
            }
            this.Status = status;
            this.IsFulfillmentByMarketplace = isFulfillmentByMarketplace;
            this.MerchantProductNo = merchantProductNo;
            this.UnitVat = unitVat;
            this.LineTotalInclVat = lineTotalInclVat;
            this.LineVat = lineVat;
            this.OriginalUnitPriceInclVat = originalUnitPriceInclVat;
            this.OriginalUnitVat = originalUnitVat;
            this.OriginalLineTotalInclVat = originalLineTotalInclVat;
            this.OriginalLineVat = originalLineVat;
            this.FeeFixed = feeFixed;
            this.FeeRate = feeRate;
            this.Condition = condition;
        }
        

        /// <summary>
        /// Gets or Sets IsFulfillmentByMarketplace
        /// </summary>
        [DataMember(Name="IsFulfillmentByMarketplace", EmitDefaultValue=false)]
        public bool? IsFulfillmentByMarketplace { get; set; }

        /// <summary>
        /// Gets or Sets MerchantProductNo
        /// </summary>
        [DataMember(Name="MerchantProductNo", EmitDefaultValue=false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name="UnitVat", EmitDefaultValue=false)]
        public double? UnitVat { get; set; }

        /// <summary>
        /// The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name="LineTotalInclVat", EmitDefaultValue=false)]
        public double? LineTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name="LineVat", EmitDefaultValue=false)]
        public double? LineVat { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name="OriginalUnitPriceInclVat", EmitDefaultValue=false)]
        public double? OriginalUnitPriceInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name="OriginalUnitVat", EmitDefaultValue=false)]
        public double? OriginalUnitVat { get; set; }

        /// <summary>
        /// The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name="OriginalLineTotalInclVat", EmitDefaultValue=false)]
        public double? OriginalLineTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name="OriginalLineVat", EmitDefaultValue=false)]
        public double? OriginalLineVat { get; set; }

        /// <summary>
        /// Gets or Sets ChannelProductNo
        /// </summary>
        [DataMember(Name="ChannelProductNo", EmitDefaultValue=false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name="UnitPriceInclVat", EmitDefaultValue=false)]
        public double? UnitPriceInclVat { get; set; }

        /// <summary>
        /// A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name="FeeFixed", EmitDefaultValue=false)]
        public double? FeeFixed { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name="FeeRate", EmitDefaultValue=false)]
        public double? FeeRate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderLineResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsFulfillmentByMarketplace: ").Append(IsFulfillmentByMarketplace).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  UnitVat: ").Append(UnitVat).Append("\n");
            sb.Append("  LineTotalInclVat: ").Append(LineTotalInclVat).Append("\n");
            sb.Append("  LineVat: ").Append(LineVat).Append("\n");
            sb.Append("  OriginalUnitPriceInclVat: ").Append(OriginalUnitPriceInclVat).Append("\n");
            sb.Append("  OriginalUnitVat: ").Append(OriginalUnitVat).Append("\n");
            sb.Append("  OriginalLineTotalInclVat: ").Append(OriginalLineTotalInclVat).Append("\n");
            sb.Append("  OriginalLineVat: ").Append(OriginalLineVat).Append("\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPriceInclVat: ").Append(UnitPriceInclVat).Append("\n");
            sb.Append("  FeeFixed: ").Append(FeeFixed).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
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
            return this.Equals(input as MerchantOrderLineResponse);
        }

        /// <summary>
        /// Returns true if MerchantOrderLineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderLineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderLineResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IsFulfillmentByMarketplace == input.IsFulfillmentByMarketplace ||
                    (this.IsFulfillmentByMarketplace != null &&
                    this.IsFulfillmentByMarketplace.Equals(input.IsFulfillmentByMarketplace))
                ) && 
                (
                    this.MerchantProductNo == input.MerchantProductNo ||
                    (this.MerchantProductNo != null &&
                    this.MerchantProductNo.Equals(input.MerchantProductNo))
                ) && 
                (
                    this.UnitVat == input.UnitVat ||
                    (this.UnitVat != null &&
                    this.UnitVat.Equals(input.UnitVat))
                ) && 
                (
                    this.LineTotalInclVat == input.LineTotalInclVat ||
                    (this.LineTotalInclVat != null &&
                    this.LineTotalInclVat.Equals(input.LineTotalInclVat))
                ) && 
                (
                    this.LineVat == input.LineVat ||
                    (this.LineVat != null &&
                    this.LineVat.Equals(input.LineVat))
                ) && 
                (
                    this.OriginalUnitPriceInclVat == input.OriginalUnitPriceInclVat ||
                    (this.OriginalUnitPriceInclVat != null &&
                    this.OriginalUnitPriceInclVat.Equals(input.OriginalUnitPriceInclVat))
                ) && 
                (
                    this.OriginalUnitVat == input.OriginalUnitVat ||
                    (this.OriginalUnitVat != null &&
                    this.OriginalUnitVat.Equals(input.OriginalUnitVat))
                ) && 
                (
                    this.OriginalLineTotalInclVat == input.OriginalLineTotalInclVat ||
                    (this.OriginalLineTotalInclVat != null &&
                    this.OriginalLineTotalInclVat.Equals(input.OriginalLineTotalInclVat))
                ) && 
                (
                    this.OriginalLineVat == input.OriginalLineVat ||
                    (this.OriginalLineVat != null &&
                    this.OriginalLineVat.Equals(input.OriginalLineVat))
                ) && 
                (
                    this.ChannelProductNo == input.ChannelProductNo ||
                    (this.ChannelProductNo != null &&
                    this.ChannelProductNo.Equals(input.ChannelProductNo))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.UnitPriceInclVat == input.UnitPriceInclVat ||
                    (this.UnitPriceInclVat != null &&
                    this.UnitPriceInclVat.Equals(input.UnitPriceInclVat))
                ) && 
                (
                    this.FeeFixed == input.FeeFixed ||
                    (this.FeeFixed != null &&
                    this.FeeFixed.Equals(input.FeeFixed))
                ) && 
                (
                    this.FeeRate == input.FeeRate ||
                    (this.FeeRate != null &&
                    this.FeeRate.Equals(input.FeeRate))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsFulfillmentByMarketplace != null)
                    hashCode = hashCode * 59 + this.IsFulfillmentByMarketplace.GetHashCode();
                if (this.MerchantProductNo != null)
                    hashCode = hashCode * 59 + this.MerchantProductNo.GetHashCode();
                if (this.UnitVat != null)
                    hashCode = hashCode * 59 + this.UnitVat.GetHashCode();
                if (this.LineTotalInclVat != null)
                    hashCode = hashCode * 59 + this.LineTotalInclVat.GetHashCode();
                if (this.LineVat != null)
                    hashCode = hashCode * 59 + this.LineVat.GetHashCode();
                if (this.OriginalUnitPriceInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalUnitPriceInclVat.GetHashCode();
                if (this.OriginalUnitVat != null)
                    hashCode = hashCode * 59 + this.OriginalUnitVat.GetHashCode();
                if (this.OriginalLineTotalInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalLineTotalInclVat.GetHashCode();
                if (this.OriginalLineVat != null)
                    hashCode = hashCode * 59 + this.OriginalLineVat.GetHashCode();
                if (this.ChannelProductNo != null)
                    hashCode = hashCode * 59 + this.ChannelProductNo.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.UnitPriceInclVat != null)
                    hashCode = hashCode * 59 + this.UnitPriceInclVat.GetHashCode();
                if (this.FeeFixed != null)
                    hashCode = hashCode * 59 + this.FeeFixed.GetHashCode();
                if (this.FeeRate != null)
                    hashCode = hashCode * 59 + this.FeeRate.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
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
            // ChannelProductNo (string) maxLength
            if(this.ChannelProductNo != null && this.ChannelProductNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelProductNo, length must be less than 50.", new [] { "ChannelProductNo" });
            }

            // ChannelProductNo (string) minLength
            if(this.ChannelProductNo != null && this.ChannelProductNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelProductNo, length must be greater than 0.", new [] { "ChannelProductNo" });
            }

            yield break;
        }
    }

}

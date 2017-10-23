/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.4.0
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
using SwaggerDateConverter = ChannelEngine.Api.Client.Client.SwaggerDateConverter;

namespace ChannelEngine.Api.Client.Model
{
    /// <summary>
    /// OrderFilter
    /// </summary>
    [DataContract]
    public partial class OrderFilter :  IEquatable<OrderFilter>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusesEnum
        {
            
            /// <summary>
            /// Enum INPROGRESS for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            INPROGRESS,
            
            /// <summary>
            /// Enum SHIPPED for "SHIPPED"
            /// </summary>
            [EnumMember(Value = "SHIPPED")]
            SHIPPED,
            
            /// <summary>
            /// Enum INBACKORDER for "IN_BACKORDER"
            /// </summary>
            [EnumMember(Value = "IN_BACKORDER")]
            INBACKORDER,
            
            /// <summary>
            /// Enum CANCELED for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED,
            
            /// <summary>
            /// Enum MANCO for "MANCO"
            /// </summary>
            [EnumMember(Value = "MANCO")]
            MANCO,
            
            /// <summary>
            /// Enum INCOMBI for "IN_COMBI"
            /// </summary>
            [EnumMember(Value = "IN_COMBI")]
            INCOMBI,
            
            /// <summary>
            /// Enum CLOSED for "CLOSED"
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED,
            
            /// <summary>
            /// Enum NEW for "NEW"
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW,
            
            /// <summary>
            /// Enum RETURNED for "RETURNED"
            /// </summary>
            [EnumMember(Value = "RETURNED")]
            RETURNED,
            
            /// <summary>
            /// Enum REQUIRESCORRECTION for "REQUIRES_CORRECTION"
            /// </summary>
            [EnumMember(Value = "REQUIRES_CORRECTION")]
            REQUIRESCORRECTION
        }

        /// <summary>
        /// Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.
        /// </summary>
        /// <value>Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FulfillmentTypeEnum
        {
            
            /// <summary>
            /// Enum ALL for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL,
            
            /// <summary>
            /// Enum ONLYMERCHANT for "ONLY_MERCHANT"
            /// </summary>
            [EnumMember(Value = "ONLY_MERCHANT")]
            ONLYMERCHANT,
            
            /// <summary>
            /// Enum ONLYCHANNEL for "ONLY_CHANNEL"
            /// </summary>
            [EnumMember(Value = "ONLY_CHANNEL")]
            ONLYCHANNEL,
            
            /// <summary>
            /// Enum MIXED for "MIXED"
            /// </summary>
            [EnumMember(Value = "MIXED")]
            MIXED
        }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name="Statuses", EmitDefaultValue=false)]
        public List<StatusesEnum> Statuses { get; set; }
        /// <summary>
        /// Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.
        /// </summary>
        /// <value>Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.</value>
        [DataMember(Name="FulfillmentType", EmitDefaultValue=false)]
        public FulfillmentTypeEnum? FulfillmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFilter" /> class.
        /// </summary>
        /// <param name="Statuses">Statuses.</param>
        /// <param name="MerchantOrderNos">MerchantOrderNos.</param>
        /// <param name="ExcludeMarketplaceFulfilledOrdersAndLines">ExcludeMarketplaceFulfilledOrdersAndLines.</param>
        /// <param name="FulfillmentType">Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true..</param>
        /// <param name="Page">Page.</param>
        public OrderFilter(List<StatusesEnum> Statuses = default(List<StatusesEnum>), List<string> MerchantOrderNos = default(List<string>), bool? ExcludeMarketplaceFulfilledOrdersAndLines = default(bool?), FulfillmentTypeEnum? FulfillmentType = default(FulfillmentTypeEnum?), int? Page = default(int?))
        {
            this.Statuses = Statuses;
            this.MerchantOrderNos = MerchantOrderNos;
            this.ExcludeMarketplaceFulfilledOrdersAndLines = ExcludeMarketplaceFulfilledOrdersAndLines;
            this.FulfillmentType = FulfillmentType;
            this.Page = Page;
        }
        

        /// <summary>
        /// Gets or Sets MerchantOrderNos
        /// </summary>
        [DataMember(Name="MerchantOrderNos", EmitDefaultValue=false)]
        public List<string> MerchantOrderNos { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeMarketplaceFulfilledOrdersAndLines
        /// </summary>
        [DataMember(Name="ExcludeMarketplaceFulfilledOrdersAndLines", EmitDefaultValue=false)]
        public bool? ExcludeMarketplaceFulfilledOrdersAndLines { get; set; }


        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFilter {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  MerchantOrderNos: ").Append(MerchantOrderNos).Append("\n");
            sb.Append("  ExcludeMarketplaceFulfilledOrdersAndLines: ").Append(ExcludeMarketplaceFulfilledOrdersAndLines).Append("\n");
            sb.Append("  FulfillmentType: ").Append(FulfillmentType).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderFilter);
        }

        /// <summary>
        /// Returns true if OrderFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
                ) && 
                (
                    this.MerchantOrderNos == input.MerchantOrderNos ||
                    this.MerchantOrderNos != null &&
                    this.MerchantOrderNos.SequenceEqual(input.MerchantOrderNos)
                ) && 
                (
                    this.ExcludeMarketplaceFulfilledOrdersAndLines == input.ExcludeMarketplaceFulfilledOrdersAndLines ||
                    (this.ExcludeMarketplaceFulfilledOrdersAndLines != null &&
                    this.ExcludeMarketplaceFulfilledOrdersAndLines.Equals(input.ExcludeMarketplaceFulfilledOrdersAndLines))
                ) && 
                (
                    this.FulfillmentType == input.FulfillmentType ||
                    (this.FulfillmentType != null &&
                    this.FulfillmentType.Equals(input.FulfillmentType))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
                if (this.MerchantOrderNos != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNos.GetHashCode();
                if (this.ExcludeMarketplaceFulfilledOrdersAndLines != null)
                    hashCode = hashCode * 59 + this.ExcludeMarketplaceFulfilledOrdersAndLines.GetHashCode();
                if (this.FulfillmentType != null)
                    hashCode = hashCode * 59 + this.FulfillmentType.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
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
            yield break;
        }
    }

}

/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.10.0
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
    /// MerchantSingleOrderReturnLineResponse
    /// </summary>
    [DataContract(Name = "MerchantSingleOrderReturnLineResponse")]
    public partial class MerchantSingleOrderReturnLineResponse : IEquatable<MerchantSingleOrderReturnLineResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [DataMember(Name = "ShipmentStatus", EmitDefaultValue = false)]
        public ShipmentLineStatus? ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantSingleOrderReturnLineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantSingleOrderReturnLineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantSingleOrderReturnLineResponse" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku)..</param>
        /// <param name="acceptedQuantity">The accepted quantity of returned products in this orderline..</param>
        /// <param name="rejectedQuantity">The rejected quantity of returned products in this orderline..</param>
        /// <param name="orderLine">orderLine.</param>
        /// <param name="shipmentStatus">shipmentStatus.</param>
        /// <param name="quantity">Number of items of the product in this return. (required).</param>
        public MerchantSingleOrderReturnLineResponse(string merchantProductNo = default(string), int? acceptedQuantity = default(int?), int? rejectedQuantity = default(int?), MerchantOrderLineResponse orderLine = default(MerchantOrderLineResponse), ShipmentLineStatus? shipmentStatus = default(ShipmentLineStatus?), int quantity = default(int))
        {
            this.Quantity = quantity;
            this.MerchantProductNo = merchantProductNo;
            this.AcceptedQuantity = acceptedQuantity;
            this.RejectedQuantity = rejectedQuantity;
            this.OrderLine = orderLine;
            this.ShipmentStatus = shipmentStatus;
        }

        /// <summary>
        /// The unique product reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The accepted quantity of returned products in this orderline.
        /// </summary>
        /// <value>The accepted quantity of returned products in this orderline.</value>
        [DataMember(Name = "AcceptedQuantity", EmitDefaultValue = true)]
        public int? AcceptedQuantity { get; set; }

        /// <summary>
        /// The rejected quantity of returned products in this orderline.
        /// </summary>
        /// <value>The rejected quantity of returned products in this orderline.</value>
        [DataMember(Name = "RejectedQuantity", EmitDefaultValue = true)]
        public int? RejectedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets OrderLine
        /// </summary>
        [DataMember(Name = "OrderLine", EmitDefaultValue = false)]
        public MerchantOrderLineResponse OrderLine { get; set; }

        /// <summary>
        /// Number of items of the product in this return.
        /// </summary>
        /// <value>Number of items of the product in this return.</value>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantSingleOrderReturnLineResponse {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
            sb.Append("  OrderLine: ").Append(OrderLine).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as MerchantSingleOrderReturnLineResponse);
        }

        /// <summary>
        /// Returns true if MerchantSingleOrderReturnLineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantSingleOrderReturnLineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantSingleOrderReturnLineResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantProductNo == input.MerchantProductNo ||
                    (this.MerchantProductNo != null &&
                    this.MerchantProductNo.Equals(input.MerchantProductNo))
                ) && 
                (
                    this.AcceptedQuantity == input.AcceptedQuantity ||
                    (this.AcceptedQuantity != null &&
                    this.AcceptedQuantity.Equals(input.AcceptedQuantity))
                ) && 
                (
                    this.RejectedQuantity == input.RejectedQuantity ||
                    (this.RejectedQuantity != null &&
                    this.RejectedQuantity.Equals(input.RejectedQuantity))
                ) && 
                (
                    this.OrderLine == input.OrderLine ||
                    (this.OrderLine != null &&
                    this.OrderLine.Equals(input.OrderLine))
                ) && 
                (
                    this.ShipmentStatus == input.ShipmentStatus ||
                    this.ShipmentStatus.Equals(input.ShipmentStatus)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.MerchantProductNo != null)
                    hashCode = hashCode * 59 + this.MerchantProductNo.GetHashCode();
                if (this.AcceptedQuantity != null)
                    hashCode = hashCode * 59 + this.AcceptedQuantity.GetHashCode();
                if (this.RejectedQuantity != null)
                    hashCode = hashCode * 59 + this.RejectedQuantity.GetHashCode();
                if (this.OrderLine != null)
                    hashCode = hashCode * 59 + this.OrderLine.GetHashCode();
                hashCode = hashCode * 59 + this.ShipmentStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
            // Quantity (int) minimum
            if(this.Quantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 0.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}

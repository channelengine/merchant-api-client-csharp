/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.12
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
    /// MerchantReturnLineResponse
    /// </summary>
    [DataContract(Name = "MerchantReturnLineResponse")]
    public partial class MerchantReturnLineResponse : IEquatable<MerchantReturnLineResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [DataMember(Name = "ShipmentStatus", EmitDefaultValue = false)]
        public ShipmentLineStatus? ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnLineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineResponse" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku)..</param>
        /// <param name="orderLine">orderLine.</param>
        /// <param name="shipmentStatus">shipmentStatus.</param>
        /// <param name="quantity">Number of items of the product in this return. (required).</param>
        public MerchantReturnLineResponse(string merchantProductNo = default(string), MerchantOrderLineResponse orderLine = default(MerchantOrderLineResponse), ShipmentLineStatus? shipmentStatus = default(ShipmentLineStatus?), int quantity = default(int))
        {
            this.Quantity = quantity;
            this.MerchantProductNo = merchantProductNo;
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
            sb.Append("class MerchantReturnLineResponse {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
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
            return this.Equals(input as MerchantReturnLineResponse);
        }

        /// <summary>
        /// Returns true if MerchantReturnLineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnLineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnLineResponse input)
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

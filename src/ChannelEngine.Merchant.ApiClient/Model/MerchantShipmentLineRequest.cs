/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.11.0
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
    /// MerchantShipmentLineRequest
    /// </summary>
    [DataContract(Name = "MerchantShipmentLineRequest")]
    public partial class MerchantShipmentLineRequest : IEquatable<MerchantShipmentLineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentLineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantShipmentLineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentLineRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku). (required).</param>
        /// <param name="extraData">Extra data on the order. Each item must have an unqiue key.</param>
        /// <param name="quantity">Number of items of the product in the shipment. (required).</param>
        public MerchantShipmentLineRequest(string merchantProductNo = default(string), Dictionary<string, string> extraData = default(Dictionary<string, string>), int quantity = default(int))
        {
            // to ensure "merchantProductNo" is required (not null)
            if (merchantProductNo == null) {
                throw new ArgumentNullException("merchantProductNo is a required property for MerchantShipmentLineRequest and cannot be null");
            }
            this.MerchantProductNo = merchantProductNo;
            this.Quantity = quantity;
            this.ExtraData = extraData;
        }

        /// <summary>
        /// The unique product reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Extra data on the order. Each item must have an unqiue key
        /// </summary>
        /// <value>Extra data on the order. Each item must have an unqiue key</value>
        [DataMember(Name = "ExtraData", EmitDefaultValue = true)]
        public Dictionary<string, string> ExtraData { get; set; }

        /// <summary>
        /// Number of items of the product in the shipment.
        /// </summary>
        /// <value>Number of items of the product in the shipment.</value>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantShipmentLineRequest {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
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
            return this.Equals(input as MerchantShipmentLineRequest);
        }

        /// <summary>
        /// Returns true if MerchantShipmentLineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantShipmentLineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShipmentLineRequest input)
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
                    this.ExtraData == input.ExtraData ||
                    this.ExtraData != null &&
                    input.ExtraData != null &&
                    this.ExtraData.SequenceEqual(input.ExtraData)
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
                if (this.ExtraData != null)
                    hashCode = hashCode * 59 + this.ExtraData.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
            // MerchantProductNo (string) maxLength
            if(this.MerchantProductNo != null && this.MerchantProductNo.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantProductNo, length must be less than 64.", new [] { "MerchantProductNo" });
            }

            // MerchantProductNo (string) minLength
            if(this.MerchantProductNo != null && this.MerchantProductNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantProductNo, length must be greater than 0.", new [] { "MerchantProductNo" });
            }

            // Quantity (int) minimum
            if(this.Quantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 0.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}

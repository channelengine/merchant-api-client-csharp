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
    /// MerchantStockPriceUpdateRequest
    /// </summary>
    [DataContract(Name = "MerchantStockPriceUpdateRequest")]
    public partial class MerchantStockPriceUpdateRequest : IEquatable<MerchantStockPriceUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantStockPriceUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantStockPriceUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantStockPriceUpdateRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku). (required).</param>
        /// <param name="stock">The stock of the product. Should not be negative..</param>
        /// <param name="price">The price of the product. Should not be negative..</param>
        /// <param name="stockLocationId">The stock location id of updated stok.  If not provided stock from default stock location will be updated..</param>
        public MerchantStockPriceUpdateRequest(string merchantProductNo = default(string), int? stock = default(int?), decimal? price = default(decimal?), int? stockLocationId = default(int?))
        {
            // to ensure "merchantProductNo" is required (not null)
            if (merchantProductNo == null) {
                throw new ArgumentNullException("merchantProductNo is a required property for MerchantStockPriceUpdateRequest and cannot be null");
            }
            this.MerchantProductNo = merchantProductNo;
            this.Stock = stock;
            this.Price = price;
            this.StockLocationId = stockLocationId;
        }

        /// <summary>
        /// The unique product reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The stock of the product. Should not be negative.
        /// </summary>
        /// <value>The stock of the product. Should not be negative.</value>
        [DataMember(Name = "Stock", EmitDefaultValue = true)]
        public int? Stock { get; set; }

        /// <summary>
        /// The price of the product. Should not be negative.
        /// </summary>
        /// <value>The price of the product. Should not be negative.</value>
        [DataMember(Name = "Price", EmitDefaultValue = true)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The stock location id of updated stok.  If not provided stock from default stock location will be updated.
        /// </summary>
        /// <value>The stock location id of updated stok.  If not provided stock from default stock location will be updated.</value>
        [DataMember(Name = "StockLocationId", EmitDefaultValue = true)]
        public int? StockLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantStockPriceUpdateRequest {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StockLocationId: ").Append(StockLocationId).Append("\n");
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
            return this.Equals(input as MerchantStockPriceUpdateRequest);
        }

        /// <summary>
        /// Returns true if MerchantStockPriceUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantStockPriceUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantStockPriceUpdateRequest input)
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
                    this.Stock == input.Stock ||
                    (this.Stock != null &&
                    this.Stock.Equals(input.Stock))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.StockLocationId == input.StockLocationId ||
                    (this.StockLocationId != null &&
                    this.StockLocationId.Equals(input.StockLocationId))
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
                if (this.Stock != null)
                    hashCode = hashCode * 59 + this.Stock.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.StockLocationId != null)
                    hashCode = hashCode * 59 + this.StockLocationId.GetHashCode();
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

            // Stock (int?) minimum
            if(this.Stock < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Stock, must be a value greater than or equal to 0.", new [] { "Stock" });
            }

            // Price (decimal?) minimum
            if(this.Price < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Price, must be a value greater than or equal to 0.", new [] { "Price" });
            }

            yield break;
        }
    }

}

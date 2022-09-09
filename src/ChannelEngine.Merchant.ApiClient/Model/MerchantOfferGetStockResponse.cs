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
    /// MerchantOfferGetStockResponse
    /// </summary>
    [DataContract(Name = "MerchantOfferGetStockResponse")]
    public partial class MerchantOfferGetStockResponse : IEquatable<MerchantOfferGetStockResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOfferGetStockResponse" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The product SKU..</param>
        /// <param name="stockLocationId">The ChannelEngine id of the stock location..</param>
        /// <param name="stock">The quantity of products in stock at the stock location..</param>
        /// <param name="updatedAt">The timestamp of the last stock update for the stock location..</param>
        public MerchantOfferGetStockResponse(string merchantProductNo = default(string), int stockLocationId = default(int), int stock = default(int), DateTime updatedAt = default(DateTime))
        {
            this.MerchantProductNo = merchantProductNo;
            this.StockLocationId = stockLocationId;
            this.Stock = stock;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The product SKU.
        /// </summary>
        /// <value>The product SKU.</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The ChannelEngine id of the stock location.
        /// </summary>
        /// <value>The ChannelEngine id of the stock location.</value>
        [DataMember(Name = "StockLocationId", EmitDefaultValue = false)]
        public int StockLocationId { get; set; }

        /// <summary>
        /// The quantity of products in stock at the stock location.
        /// </summary>
        /// <value>The quantity of products in stock at the stock location.</value>
        [DataMember(Name = "Stock", EmitDefaultValue = false)]
        public int Stock { get; set; }

        /// <summary>
        /// The timestamp of the last stock update for the stock location.
        /// </summary>
        /// <value>The timestamp of the last stock update for the stock location.</value>
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOfferGetStockResponse {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  StockLocationId: ").Append(StockLocationId).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as MerchantOfferGetStockResponse);
        }

        /// <summary>
        /// Returns true if MerchantOfferGetStockResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOfferGetStockResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOfferGetStockResponse input)
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
                    this.StockLocationId == input.StockLocationId ||
                    this.StockLocationId.Equals(input.StockLocationId)
                ) && 
                (
                    this.Stock == input.Stock ||
                    this.Stock.Equals(input.Stock)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                hashCode = hashCode * 59 + this.StockLocationId.GetHashCode();
                hashCode = hashCode * 59 + this.Stock.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
            yield break;
        }
    }

}

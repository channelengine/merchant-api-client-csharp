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
    /// MerchantOfferStockUpdateRequest
    /// </summary>
    [DataContract(Name = "MerchantOfferStockUpdateRequest")]
    public partial class MerchantOfferStockUpdateRequest : IEquatable<MerchantOfferStockUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOfferStockUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantOfferStockUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOfferStockUpdateRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku). (required).</param>
        /// <param name="stockLocations">Stock locations data (required).</param>
        public MerchantOfferStockUpdateRequest(string merchantProductNo = default(string), List<MerchantStockLocationUpdateRequest> stockLocations = default(List<MerchantStockLocationUpdateRequest>))
        {
            // to ensure "merchantProductNo" is required (not null)
            if (merchantProductNo == null) {
                throw new ArgumentNullException("merchantProductNo is a required property for MerchantOfferStockUpdateRequest and cannot be null");
            }
            this.MerchantProductNo = merchantProductNo;
            // to ensure "stockLocations" is required (not null)
            if (stockLocations == null) {
                throw new ArgumentNullException("stockLocations is a required property for MerchantOfferStockUpdateRequest and cannot be null");
            }
            this.StockLocations = stockLocations;
        }

        /// <summary>
        /// The unique product reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Stock locations data
        /// </summary>
        /// <value>Stock locations data</value>
        [DataMember(Name = "StockLocations", IsRequired = true, EmitDefaultValue = false)]
        public List<MerchantStockLocationUpdateRequest> StockLocations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOfferStockUpdateRequest {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  StockLocations: ").Append(StockLocations).Append("\n");
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
            return this.Equals(input as MerchantOfferStockUpdateRequest);
        }

        /// <summary>
        /// Returns true if MerchantOfferStockUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOfferStockUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOfferStockUpdateRequest input)
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
                    this.StockLocations == input.StockLocations ||
                    this.StockLocations != null &&
                    input.StockLocations != null &&
                    this.StockLocations.SequenceEqual(input.StockLocations)
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
                if (this.StockLocations != null)
                    hashCode = hashCode * 59 + this.StockLocations.GetHashCode();
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

            yield break;
        }
    }

}

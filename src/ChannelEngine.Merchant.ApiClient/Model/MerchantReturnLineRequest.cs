/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.8
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
    /// MerchantReturnLineRequest
    /// </summary>
    [DataContract(Name = "MerchantReturnLineRequest")]
    public partial class MerchantReturnLineRequest : IEquatable<MerchantReturnLineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnLineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku). (required).</param>
        /// <param name="quantity">Number of items of the product in this return. (required).</param>
        public MerchantReturnLineRequest(string merchantProductNo = default(string), int quantity = default(int))
        {
            // to ensure "merchantProductNo" is required (not null)
            this.MerchantProductNo = merchantProductNo ?? throw new ArgumentNullException("merchantProductNo is a required property for MerchantReturnLineRequest and cannot be null");
            this.Quantity = quantity;
        }

        /// <summary>
        /// The unique product reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantProductNo { get; set; }

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
            sb.Append("class MerchantReturnLineRequest {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
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
            return this.Equals(input as MerchantReturnLineRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnLineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnLineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnLineRequest input)
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
            yield break;
        }
    }

}

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
    /// MerchantProductBundleResponse
    /// </summary>
    [DataContract(Name = "MerchantProductBundleResponse")]
    public partial class MerchantProductBundleResponse : IEquatable<MerchantProductBundleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantProductBundleResponse" /> class.
        /// </summary>
        /// <param name="merchantProductNo">merchantProductNo.</param>
        /// <param name="ean">ean.</param>
        /// <param name="name">name.</param>
        /// <param name="price">price.</param>
        /// <param name="parts">parts.</param>
        public MerchantProductBundleResponse(string merchantProductNo = default(string), string ean = default(string), string name = default(string), decimal price = default(decimal), List<MerchantProductBundlePartResponse> parts = default(List<MerchantProductBundlePartResponse>))
        {
            this.MerchantProductNo = merchantProductNo;
            this.Ean = ean;
            this.Name = name;
            this.Price = price;
            this.Parts = parts;
        }

        /// <summary>
        /// Gets or Sets MerchantProductNo
        /// </summary>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Gets or Sets Ean
        /// </summary>
        [DataMember(Name = "Ean", EmitDefaultValue = true)]
        public string Ean { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "Price", EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets Parts
        /// </summary>
        [DataMember(Name = "Parts", EmitDefaultValue = true)]
        public List<MerchantProductBundlePartResponse> Parts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantProductBundleResponse {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
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
            return this.Equals(input as MerchantProductBundleResponse);
        }

        /// <summary>
        /// Returns true if MerchantProductBundleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantProductBundleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantProductBundleResponse input)
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
                    this.Ean == input.Ean ||
                    (this.Ean != null &&
                    this.Ean.Equals(input.Ean))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Parts == input.Parts ||
                    this.Parts != null &&
                    input.Parts != null &&
                    this.Parts.SequenceEqual(input.Parts)
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
                if (this.Ean != null)
                    hashCode = hashCode * 59 + this.Ean.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Parts != null)
                    hashCode = hashCode * 59 + this.Parts.GetHashCode();
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

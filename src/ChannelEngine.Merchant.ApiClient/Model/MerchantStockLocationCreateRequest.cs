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
    /// MerchantStockLocationCreateRequest
    /// </summary>
    [DataContract(Name = "MerchantStockLocationCreateRequest")]
    public partial class MerchantStockLocationCreateRequest : IEquatable<MerchantStockLocationCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantStockLocationCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantStockLocationCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantStockLocationCreateRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="fallBackToDefault">If false: only use fulfillment by channel, else (also) use merchant fulfillment..</param>
        /// <param name="address">address.</param>
        public MerchantStockLocationCreateRequest(string name = default(string), bool isDefault = default(bool), bool fallBackToDefault = default(bool), MerchantStockLocationAddressRequest address = default(MerchantStockLocationAddressRequest))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for MerchantStockLocationCreateRequest and cannot be null");
            }
            this.Name = name;
            this.IsDefault = isDefault;
            this.FallBackToDefault = fallBackToDefault;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "IsDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// If false: only use fulfillment by channel, else (also) use merchant fulfillment.
        /// </summary>
        /// <value>If false: only use fulfillment by channel, else (also) use merchant fulfillment.</value>
        [DataMember(Name = "FallBackToDefault", EmitDefaultValue = true)]
        public bool FallBackToDefault { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public MerchantStockLocationAddressRequest Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantStockLocationCreateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  FallBackToDefault: ").Append(FallBackToDefault).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as MerchantStockLocationCreateRequest);
        }

        /// <summary>
        /// Returns true if MerchantStockLocationCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantStockLocationCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantStockLocationCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.FallBackToDefault == input.FallBackToDefault ||
                    this.FallBackToDefault.Equals(input.FallBackToDefault)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                hashCode = hashCode * 59 + this.FallBackToDefault.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
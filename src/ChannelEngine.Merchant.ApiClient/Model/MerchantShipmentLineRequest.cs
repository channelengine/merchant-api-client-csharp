/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.6.1
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
using SwaggerDateConverter = ChannelEngine.Merchant.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// MerchantShipmentLineRequest
    /// </summary>
    [DataContract]
    public partial class MerchantShipmentLineRequest :  IEquatable<MerchantShipmentLineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentLineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantShipmentLineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentLineRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">merchantProductNo (required).</param>
        /// <param name="quantity">quantity (required).</param>
        public MerchantShipmentLineRequest(string merchantProductNo = default(string), int? quantity = default(int?))
        {
            // to ensure "merchantProductNo" is required (not null)
            if (merchantProductNo == null)
            {
                throw new InvalidDataException("merchantProductNo is a required property for MerchantShipmentLineRequest and cannot be null");
            }
            else
            {
                this.MerchantProductNo = merchantProductNo;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for MerchantShipmentLineRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
        }
        
        /// <summary>
        /// Gets or Sets MerchantProductNo
        /// </summary>
        [DataMember(Name="MerchantProductNo", EmitDefaultValue=false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantShipmentLineRequest {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Quantity != null)
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

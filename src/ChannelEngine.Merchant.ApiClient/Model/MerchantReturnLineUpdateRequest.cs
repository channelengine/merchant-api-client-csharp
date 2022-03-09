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
    /// MerchantReturnLineUpdateRequest
    /// </summary>
    [DataContract(Name = "MerchantReturnLineUpdateRequest")]
    public partial class MerchantReturnLineUpdateRequest : IEquatable<MerchantReturnLineUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnLineUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineUpdateRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku). (required).</param>
        /// <param name="acceptedQuantity">The amount of items that have been accepted. (required).</param>
        /// <param name="rejectedQuantity">The amount of items that have been rejected. (required).</param>
        public MerchantReturnLineUpdateRequest(string merchantProductNo = default(string), int acceptedQuantity = default(int), int rejectedQuantity = default(int))
        {
            // to ensure "merchantProductNo" is required (not null)
            this.MerchantProductNo = merchantProductNo ?? throw new ArgumentNullException("merchantProductNo is a required property for MerchantReturnLineUpdateRequest and cannot be null");
            this.AcceptedQuantity = acceptedQuantity;
            this.RejectedQuantity = rejectedQuantity;
        }

        /// <summary>
        /// The unique product reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku).</value>
        [DataMember(Name = "MerchantProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The amount of items that have been accepted.
        /// </summary>
        /// <value>The amount of items that have been accepted.</value>
        [DataMember(Name = "AcceptedQuantity", IsRequired = true, EmitDefaultValue = false)]
        public int AcceptedQuantity { get; set; }

        /// <summary>
        /// The amount of items that have been rejected.
        /// </summary>
        /// <value>The amount of items that have been rejected.</value>
        [DataMember(Name = "RejectedQuantity", IsRequired = true, EmitDefaultValue = false)]
        public int RejectedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnLineUpdateRequest {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
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
            return this.Equals(input as MerchantReturnLineUpdateRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnLineUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnLineUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnLineUpdateRequest input)
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
                    this.AcceptedQuantity.Equals(input.AcceptedQuantity)
                ) && 
                (
                    this.RejectedQuantity == input.RejectedQuantity ||
                    this.RejectedQuantity.Equals(input.RejectedQuantity)
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
                hashCode = hashCode * 59 + this.AcceptedQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.RejectedQuantity.GetHashCode();
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

            // AcceptedQuantity (int) minimum
            if(this.AcceptedQuantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcceptedQuantity, must be a value greater than or equal to 0.", new [] { "AcceptedQuantity" });
            }

            // RejectedQuantity (int) minimum
            if(this.RejectedQuantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RejectedQuantity, must be a value greater than or equal to 0.", new [] { "RejectedQuantity" });
            }

            yield break;
        }
    }

}

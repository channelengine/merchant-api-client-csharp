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
    /// MerchantOrderAcknowledgementRequest
    /// </summary>
    [DataContract(Name = "MerchantOrderAcknowledgementRequest")]
    public partial class MerchantOrderAcknowledgementRequest : IEquatable<MerchantOrderAcknowledgementRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderAcknowledgementRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantOrderAcknowledgementRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderAcknowledgementRequest" /> class.
        /// </summary>
        /// <param name="merchantOrderNo">Your own order reference, this will be used in consecutive order processing API calls. (required).</param>
        /// <param name="orderId">The ChannelEngine order ID of the order you would like to acknowledge. (required).</param>
        public MerchantOrderAcknowledgementRequest(string merchantOrderNo = default(string), int orderId = default(int))
        {
            // to ensure "merchantOrderNo" is required (not null)
            if (merchantOrderNo == null) {
                throw new ArgumentNullException("merchantOrderNo is a required property for MerchantOrderAcknowledgementRequest and cannot be null");
            }
            this.MerchantOrderNo = merchantOrderNo;
            this.OrderId = orderId;
        }

        /// <summary>
        /// Your own order reference, this will be used in consecutive order processing API calls.
        /// </summary>
        /// <value>Your own order reference, this will be used in consecutive order processing API calls.</value>
        [DataMember(Name = "MerchantOrderNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The ChannelEngine order ID of the order you would like to acknowledge.
        /// </summary>
        /// <value>The ChannelEngine order ID of the order you would like to acknowledge.</value>
        [DataMember(Name = "OrderId", IsRequired = true, EmitDefaultValue = false)]
        public int OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderAcknowledgementRequest {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as MerchantOrderAcknowledgementRequest);
        }

        /// <summary>
        /// Returns true if MerchantOrderAcknowledgementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderAcknowledgementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderAcknowledgementRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
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
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                hashCode = hashCode * 59 + this.OrderId.GetHashCode();
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
            // MerchantOrderNo (string) maxLength
            if(this.MerchantOrderNo != null && this.MerchantOrderNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantOrderNo, length must be less than 50.", new [] { "MerchantOrderNo" });
            }

            // MerchantOrderNo (string) minLength
            if(this.MerchantOrderNo != null && this.MerchantOrderNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantOrderNo, length must be greater than 0.", new [] { "MerchantOrderNo" });
            }

            yield break;
        }
    }

}

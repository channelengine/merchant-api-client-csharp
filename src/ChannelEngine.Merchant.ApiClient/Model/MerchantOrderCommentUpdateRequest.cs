/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.10.0
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
    /// MerchantOrderCommentUpdateRequest
    /// </summary>
    [DataContract(Name = "MerchantOrderCommentUpdateRequest")]
    public partial class MerchantOrderCommentUpdateRequest : IEquatable<MerchantOrderCommentUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderCommentUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantOrderCommentUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderCommentUpdateRequest" /> class.
        /// </summary>
        /// <param name="merchantOrderNo">Your own order reference for the order you would like to update the comment for.  Either this field or OrderId is required.</param>
        /// <param name="orderId">The ChannelEngine order ID of the order you would like to update the comment for.  Either this field or MerchantOrderNo is required.</param>
        /// <param name="merchantComment">The merchant comment you would like add / update for the order. (required).</param>
        public MerchantOrderCommentUpdateRequest(string merchantOrderNo = default(string), int? orderId = default(int?), string merchantComment = default(string))
        {
            // to ensure "merchantComment" is required (not null)
            this.MerchantComment = merchantComment ?? throw new ArgumentNullException("merchantComment is a required property for MerchantOrderCommentUpdateRequest and cannot be null");
            this.MerchantOrderNo = merchantOrderNo;
            this.OrderId = orderId;
        }

        /// <summary>
        /// Your own order reference for the order you would like to update the comment for.  Either this field or OrderId is required
        /// </summary>
        /// <value>Your own order reference for the order you would like to update the comment for.  Either this field or OrderId is required</value>
        [DataMember(Name = "MerchantOrderNo", EmitDefaultValue = true)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The ChannelEngine order ID of the order you would like to update the comment for.  Either this field or MerchantOrderNo is required
        /// </summary>
        /// <value>The ChannelEngine order ID of the order you would like to update the comment for.  Either this field or MerchantOrderNo is required</value>
        [DataMember(Name = "OrderId", EmitDefaultValue = true)]
        public int? OrderId { get; set; }

        /// <summary>
        /// The merchant comment you would like add / update for the order.
        /// </summary>
        /// <value>The merchant comment you would like add / update for the order.</value>
        [DataMember(Name = "MerchantComment", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderCommentUpdateRequest {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
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
            return this.Equals(input as MerchantOrderCommentUpdateRequest);
        }

        /// <summary>
        /// Returns true if MerchantOrderCommentUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderCommentUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderCommentUpdateRequest input)
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
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.MerchantComment == input.MerchantComment ||
                    (this.MerchantComment != null &&
                    this.MerchantComment.Equals(input.MerchantComment))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
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

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
    /// ProductCreationResult
    /// </summary>
    [DataContract(Name = "ProductCreationResult")]
    public partial class ProductCreationResult : IEquatable<ProductCreationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCreationResult" /> class.
        /// </summary>
        /// <param name="rejectedCount">rejectedCount.</param>
        /// <param name="acceptedCount">acceptedCount.</param>
        /// <param name="productMessages">Messages about the rejected products..</param>
        public ProductCreationResult(int rejectedCount = default(int), int acceptedCount = default(int), List<ProductMessage> productMessages = default(List<ProductMessage>))
        {
            this.RejectedCount = rejectedCount;
            this.AcceptedCount = acceptedCount;
            this.ProductMessages = productMessages;
        }

        /// <summary>
        /// Gets or Sets RejectedCount
        /// </summary>
        [DataMember(Name = "RejectedCount", EmitDefaultValue = false)]
        public int RejectedCount { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedCount
        /// </summary>
        [DataMember(Name = "AcceptedCount", EmitDefaultValue = false)]
        public int AcceptedCount { get; set; }

        /// <summary>
        /// Messages about the rejected products.
        /// </summary>
        /// <value>Messages about the rejected products.</value>
        [DataMember(Name = "ProductMessages", EmitDefaultValue = true)]
        public List<ProductMessage> ProductMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductCreationResult {\n");
            sb.Append("  RejectedCount: ").Append(RejectedCount).Append("\n");
            sb.Append("  AcceptedCount: ").Append(AcceptedCount).Append("\n");
            sb.Append("  ProductMessages: ").Append(ProductMessages).Append("\n");
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
            return this.Equals(input as ProductCreationResult);
        }

        /// <summary>
        /// Returns true if ProductCreationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductCreationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductCreationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RejectedCount == input.RejectedCount ||
                    this.RejectedCount.Equals(input.RejectedCount)
                ) && 
                (
                    this.AcceptedCount == input.AcceptedCount ||
                    this.AcceptedCount.Equals(input.AcceptedCount)
                ) && 
                (
                    this.ProductMessages == input.ProductMessages ||
                    this.ProductMessages != null &&
                    input.ProductMessages != null &&
                    this.ProductMessages.SequenceEqual(input.ProductMessages)
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
                hashCode = hashCode * 59 + this.RejectedCount.GetHashCode();
                hashCode = hashCode * 59 + this.AcceptedCount.GetHashCode();
                if (this.ProductMessages != null)
                    hashCode = hashCode * 59 + this.ProductMessages.GetHashCode();
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

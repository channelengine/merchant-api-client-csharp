/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.10
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
    /// CollectionOfMerchantReturnResponse
    /// </summary>
    [DataContract(Name = "CollectionOfMerchantReturnResponse")]
    public partial class CollectionOfMerchantReturnResponse : IEquatable<CollectionOfMerchantReturnResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionOfMerchantReturnResponse" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="count">count.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="itemsPerPage">itemsPerPage.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="logId">logId.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        /// <param name="validationErrors">validationErrors.</param>
        public CollectionOfMerchantReturnResponse(List<MerchantReturnResponse> content = default(List<MerchantReturnResponse>), int count = default(int), int totalCount = default(int), int itemsPerPage = default(int), int statusCode = default(int), int? logId = default(int?), bool success = default(bool), string message = default(string), Dictionary<string, List<string>> validationErrors = default(Dictionary<string, List<string>>))
        {
            this.Content = content;
            this.Count = count;
            this.TotalCount = totalCount;
            this.ItemsPerPage = itemsPerPage;
            this.StatusCode = statusCode;
            this.LogId = logId;
            this.Success = success;
            this.Message = message;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "Content", EmitDefaultValue = true)]
        public List<MerchantReturnResponse> Content { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "Count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "TotalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets ItemsPerPage
        /// </summary>
        [DataMember(Name = "ItemsPerPage", EmitDefaultValue = false)]
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets LogId
        /// </summary>
        [DataMember(Name = "LogId", EmitDefaultValue = true)]
        public int? LogId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "Success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name = "ValidationErrors", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionOfMerchantReturnResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as CollectionOfMerchantReturnResponse);
        }

        /// <summary>
        /// Returns true if CollectionOfMerchantReturnResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionOfMerchantReturnResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionOfMerchantReturnResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    input.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.ItemsPerPage == input.ItemsPerPage ||
                    this.ItemsPerPage.Equals(input.ItemsPerPage)
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
                hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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

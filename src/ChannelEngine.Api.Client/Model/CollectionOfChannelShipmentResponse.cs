/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.4.0
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
using SwaggerDateConverter = ChannelEngine.Api.Client.Client.SwaggerDateConverter;

namespace ChannelEngine.Api.Client.Model
{
    /// <summary>
    /// CollectionOfChannelShipmentResponse
    /// </summary>
    [DataContract]
    public partial class CollectionOfChannelShipmentResponse :  IEquatable<CollectionOfChannelShipmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionOfChannelShipmentResponse" /> class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="Count">The number of items in the current response.</param>
        /// <param name="TotalCount">The total number of items.</param>
        /// <param name="ItemsPerPage">The number of items per page.</param>
        /// <param name="StatusCode">StatusCode.</param>
        /// <param name="Success">Success.</param>
        /// <param name="Message">Message.</param>
        /// <param name="ValidationErrors">ValidationErrors.</param>
        public CollectionOfChannelShipmentResponse(List<ChannelShipmentResponse> Content = default(List<ChannelShipmentResponse>), int? Count = default(int?), int? TotalCount = default(int?), int? ItemsPerPage = default(int?), int? StatusCode = default(int?), bool? Success = default(bool?), string Message = default(string), Dictionary<string, List<string>> ValidationErrors = default(Dictionary<string, List<string>>))
        {
            this.Content = Content;
            this.Count = Count;
            this.TotalCount = TotalCount;
            this.ItemsPerPage = ItemsPerPage;
            this.StatusCode = StatusCode;
            this.Success = Success;
            this.Message = Message;
            this.ValidationErrors = ValidationErrors;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public List<ChannelShipmentResponse> Content { get; set; }

        /// <summary>
        /// The number of items in the current response
        /// </summary>
        /// <value>The number of items in the current response</value>
        [DataMember(Name="Count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The total number of items
        /// </summary>
        /// <value>The total number of items</value>
        [DataMember(Name="TotalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The number of items per page
        /// </summary>
        /// <value>The number of items per page</value>
        [DataMember(Name="ItemsPerPage", EmitDefaultValue=false)]
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="StatusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionOfChannelShipmentResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
        public string ToJson()
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
            return this.Equals(input as CollectionOfChannelShipmentResponse);
        }

        /// <summary>
        /// Returns true if CollectionOfChannelShipmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionOfChannelShipmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionOfChannelShipmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.ItemsPerPage == input.ItemsPerPage ||
                    (this.ItemsPerPage != null &&
                    this.ItemsPerPage.Equals(input.ItemsPerPage))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ItemsPerPage != null)
                    hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.Success != null)
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

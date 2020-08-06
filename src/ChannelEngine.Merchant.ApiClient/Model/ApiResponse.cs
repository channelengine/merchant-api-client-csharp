/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = ChannelEngine.Merchant.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// ApiResponse
    /// </summary>
    [DataContract]
    public partial class ApiResponse :  IEquatable<ApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="logId">logId.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        /// <param name="validationErrors">validationErrors.</param>
        public ApiResponse(int statusCode = default(int), int? logId = default(int?), bool success = default(bool), string message = default(string), Dictionary<string, List<string>> validationErrors = default(Dictionary<string, List<string>>))
        {
            this.StatusCode = statusCode;
            this.LogId = logId;
            this.Success = success;
            this.Message = message;
            this.ValidationErrors = validationErrors;
        }
        
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="StatusCode", EmitDefaultValue=false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets LogId
        /// </summary>
        [DataMember(Name="LogId", EmitDefaultValue=true)]
        public int? LogId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=true)]
        public Dictionary<string, List<string>> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponse {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiResponse);
        }

        /// <summary>
        /// Returns true if ApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponse input)
        {
            if (input == null)
                return false;

            return 
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

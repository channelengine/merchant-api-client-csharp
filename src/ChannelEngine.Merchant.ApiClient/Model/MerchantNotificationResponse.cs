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
    /// MerchantNotificationResponse
    /// </summary>
    [DataContract(Name = "MerchantNotificationResponse")]
    public partial class MerchantNotificationResponse : IEquatable<MerchantNotificationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantNotificationResponse" /> class.
        /// </summary>
        /// <param name="id">Unique identifier used by ChannelEngine..</param>
        /// <param name="read">Indicating whether the notification is already read using the backoffice..</param>
        /// <param name="createdAt">Get the created date time..</param>
        /// <param name="message">message.</param>
        /// <param name="subject">subject.</param>
        /// <param name="count">count.</param>
        public MerchantNotificationResponse(int id = default(int), bool read = default(bool), DateTime createdAt = default(DateTime), string message = default(string), string subject = default(string), int count = default(int))
        {
            this.Id = id;
            this.Read = read;
            this.CreatedAt = createdAt;
            this.Message = message;
            this.Subject = subject;
            this.Count = count;
        }

        /// <summary>
        /// Unique identifier used by ChannelEngine.
        /// </summary>
        /// <value>Unique identifier used by ChannelEngine.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Indicating whether the notification is already read using the backoffice.
        /// </summary>
        /// <value>Indicating whether the notification is already read using the backoffice.</value>
        [DataMember(Name = "Read", EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Get the created date time.
        /// </summary>
        /// <value>Get the created date time.</value>
        [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "Subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "Count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantNotificationResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as MerchantNotificationResponse);
        }

        /// <summary>
        /// Returns true if MerchantNotificationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantNotificationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantNotificationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Read.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                hashCode = hashCode * 59 + this.Count.GetHashCode();
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

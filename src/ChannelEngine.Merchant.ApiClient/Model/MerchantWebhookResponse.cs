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
    /// MerchantWebhookResponse
    /// </summary>
    [DataContract(Name = "MerchantWebhookResponse")]
    public partial class MerchantWebhookResponse : IEquatable<MerchantWebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookResponse" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="events">events.</param>
        public MerchantWebhookResponse(string name = default(string), string url = default(string), bool isActive = default(bool), List<WebhookEventType> events = default(List<WebhookEventType>))
        {
            this.Name = name;
            this.Url = url;
            this.IsActive = isActive;
            this.Events = events;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "Url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "Events", EmitDefaultValue = true)]
        public List<WebhookEventType> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantWebhookResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as MerchantWebhookResponse);
        }

        /// <summary>
        /// Returns true if MerchantWebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantWebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantWebhookResponse input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
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

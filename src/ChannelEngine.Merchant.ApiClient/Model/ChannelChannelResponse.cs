/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.9
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
    /// ChannelChannelResponse
    /// </summary>
    [DataContract(Name = "ChannelChannelResponse")]
    public partial class ChannelChannelResponse : IEquatable<ChannelChannelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelChannelResponse" /> class.
        /// </summary>
        /// <param name="channelId">The ID of the Channel..</param>
        /// <param name="isEnabled">A boolean value indicating whether the Channel is enabled..</param>
        /// <param name="channelName">The name of the Channel..</param>
        public ChannelChannelResponse(int? channelId = default(int?), bool isEnabled = default(bool), string channelName = default(string))
        {
            this.ChannelId = channelId;
            this.IsEnabled = isEnabled;
            this.ChannelName = channelName;
        }

        /// <summary>
        /// The ID of the Channel.
        /// </summary>
        /// <value>The ID of the Channel.</value>
        [DataMember(Name = "ChannelId", EmitDefaultValue = true)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// A boolean value indicating whether the Channel is enabled.
        /// </summary>
        /// <value>A boolean value indicating whether the Channel is enabled.</value>
        [DataMember(Name = "IsEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The name of the Channel.
        /// </summary>
        /// <value>The name of the Channel.</value>
        [DataMember(Name = "ChannelName", EmitDefaultValue = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelChannelResponse {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
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
            return this.Equals(input as ChannelChannelResponse);
        }

        /// <summary>
        /// Returns true if ChannelChannelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelChannelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelChannelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
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
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.ChannelName != null)
                    hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
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

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
    /// ChannelGlobalChannelResponse
    /// </summary>
    [DataContract(Name = "ChannelGlobalChannelResponse")]
    public partial class ChannelGlobalChannelResponse : IEquatable<ChannelGlobalChannelResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelGlobalChannelResponse" /> class.
        /// </summary>
        /// <param name="countryCode">The country code of the Global Channel..</param>
        /// <param name="globalChannelId">The ID of the Global Channel..</param>
        /// <param name="channels">The status of the instances..</param>
        /// <param name="languageCode">The language code of the Global Channel..</param>
        /// <param name="globalChannelName">The name of the Global Channel..</param>
        public ChannelGlobalChannelResponse(string countryCode = default(string), int? globalChannelId = default(int?), List<ChannelChannelResponse> channels = default(List<ChannelChannelResponse>), string languageCode = default(string), string globalChannelName = default(string))
        {
            this.CountryCode = countryCode;
            this.GlobalChannelId = globalChannelId;
            this.Channels = channels;
            this.LanguageCode = languageCode;
            this.GlobalChannelName = globalChannelName;
        }

        /// <summary>
        /// The country code of the Global Channel.
        /// </summary>
        /// <value>The country code of the Global Channel.</value>
        [DataMember(Name = "CountryCode", EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The ID of the Global Channel.
        /// </summary>
        /// <value>The ID of the Global Channel.</value>
        [DataMember(Name = "GlobalChannelId", EmitDefaultValue = true)]
        public int? GlobalChannelId { get; set; }

        /// <summary>
        /// The status of the instances.
        /// </summary>
        /// <value>The status of the instances.</value>
        [DataMember(Name = "Channels", EmitDefaultValue = true)]
        public List<ChannelChannelResponse> Channels { get; set; }

        /// <summary>
        /// The language code of the Global Channel.
        /// </summary>
        /// <value>The language code of the Global Channel.</value>
        [DataMember(Name = "LanguageCode", EmitDefaultValue = true)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// The name of the Global Channel.
        /// </summary>
        /// <value>The name of the Global Channel.</value>
        [DataMember(Name = "GlobalChannelName", EmitDefaultValue = true)]
        public string GlobalChannelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelGlobalChannelResponse {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  GlobalChannelId: ").Append(GlobalChannelId).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  GlobalChannelName: ").Append(GlobalChannelName).Append("\n");
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
            return this.Equals(input as ChannelGlobalChannelResponse);
        }

        /// <summary>
        /// Returns true if ChannelGlobalChannelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelGlobalChannelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelGlobalChannelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.GlobalChannelId == input.GlobalChannelId ||
                    (this.GlobalChannelId != null &&
                    this.GlobalChannelId.Equals(input.GlobalChannelId))
                ) && 
                (
                    this.Channels == input.Channels ||
                    this.Channels != null &&
                    input.Channels != null &&
                    this.Channels.SequenceEqual(input.Channels)
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.GlobalChannelName == input.GlobalChannelName ||
                    (this.GlobalChannelName != null &&
                    this.GlobalChannelName.Equals(input.GlobalChannelName))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.GlobalChannelId != null)
                    hashCode = hashCode * 59 + this.GlobalChannelId.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.GlobalChannelName != null)
                    hashCode = hashCode * 59 + this.GlobalChannelName.GetHashCode();
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

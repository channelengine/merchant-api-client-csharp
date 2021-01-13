/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.4
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
    /// MerchantProductExtraDataItemRequest
    /// </summary>
    [DataContract]
    public partial class MerchantProductExtraDataItemRequest :  IEquatable<MerchantProductExtraDataItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public ExtraDataType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantProductExtraDataItemRequest" /> class.
        /// </summary>
        /// <param name="key">Name of the extra data field..</param>
        /// <param name="value">Value of the extra data field..</param>
        /// <param name="type">type.</param>
        /// <param name="isPublic">Add this field to the export of the product feed to the channel..</param>
        public MerchantProductExtraDataItemRequest(string key = default(string), string value = default(string), ExtraDataType? type = default(ExtraDataType?), bool isPublic = default(bool))
        {
            this.Key = key;
            this.Value = value;
            this.Type = type;
            this.IsPublic = isPublic;
        }
        
        /// <summary>
        /// Name of the extra data field.
        /// </summary>
        /// <value>Name of the extra data field.</value>
        [DataMember(Name="Key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Value of the extra data field.
        /// </summary>
        /// <value>Value of the extra data field.</value>
        [DataMember(Name="Value", EmitDefaultValue=true)]
        public string Value { get; set; }

        /// <summary>
        /// Add this field to the export of the product feed to the channel.
        /// </summary>
        /// <value>Add this field to the export of the product feed to the channel.</value>
        [DataMember(Name="IsPublic", EmitDefaultValue=false)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantProductExtraDataItemRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
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
            return this.Equals(input as MerchantProductExtraDataItemRequest);
        }

        /// <summary>
        /// Returns true if MerchantProductExtraDataItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantProductExtraDataItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantProductExtraDataItemRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    this.IsPublic.Equals(input.IsPublic)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
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

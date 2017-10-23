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
    /// ExtraDataItem
    /// </summary>
    [DataContract]
    public partial class ExtraDataItem :  IEquatable<ExtraDataItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum TEXT for "TEXT"
            /// </summary>
            [EnumMember(Value = "TEXT")]
            TEXT,
            
            /// <summary>
            /// Enum NUMBER for "NUMBER"
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            NUMBER,
            
            /// <summary>
            /// Enum URL for "URL"
            /// </summary>
            [EnumMember(Value = "URL")]
            URL,
            
            /// <summary>
            /// Enum IMAGEURL for "IMAGEURL"
            /// </summary>
            [EnumMember(Value = "IMAGEURL")]
            IMAGEURL
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraDataItem" /> class.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Type">Type.</param>
        /// <param name="IsPublic">IsPublic.</param>
        public ExtraDataItem(string Key = default(string), string Value = default(string), TypeEnum? Type = default(TypeEnum?), bool? IsPublic = default(bool?))
        {
            this.Key = Key;
            this.Value = Value;
            this.Type = Type;
            this.IsPublic = IsPublic;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Gets or Sets IsPublic
        /// </summary>
        [DataMember(Name="IsPublic", EmitDefaultValue=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraDataItem {\n");
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
            return this.Equals(input as ExtraDataItem);
        }

        /// <summary>
        /// Returns true if ExtraDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtraDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtraDataItem input)
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
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsPublic != null)
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

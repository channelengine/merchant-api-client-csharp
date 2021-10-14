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
    /// PatchMerchantProductDto
    /// </summary>
    [DataContract(Name = "PatchMerchantProductDto")]
    public partial class PatchMerchantProductDto : IEquatable<PatchMerchantProductDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMerchantProductDto" /> class.
        /// </summary>
        /// <param name="propertiesToUpdate">propertiesToUpdate.</param>
        /// <param name="merchantProductRequestModels">merchantProductRequestModels.</param>
        public PatchMerchantProductDto(List<string> propertiesToUpdate = default(List<string>), List<MerchantProductRequest> merchantProductRequestModels = default(List<MerchantProductRequest>))
        {
            this.PropertiesToUpdate = propertiesToUpdate;
            this.MerchantProductRequestModels = merchantProductRequestModels;
        }

        /// <summary>
        /// Gets or Sets PropertiesToUpdate
        /// </summary>
        [DataMember(Name = "PropertiesToUpdate", EmitDefaultValue = true)]
        public List<string> PropertiesToUpdate { get; set; }

        /// <summary>
        /// Gets or Sets MerchantProductRequestModels
        /// </summary>
        [DataMember(Name = "MerchantProductRequestModels", EmitDefaultValue = true)]
        public List<MerchantProductRequest> MerchantProductRequestModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchMerchantProductDto {\n");
            sb.Append("  PropertiesToUpdate: ").Append(PropertiesToUpdate).Append("\n");
            sb.Append("  MerchantProductRequestModels: ").Append(MerchantProductRequestModels).Append("\n");
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
            return this.Equals(input as PatchMerchantProductDto);
        }

        /// <summary>
        /// Returns true if PatchMerchantProductDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchMerchantProductDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchMerchantProductDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertiesToUpdate == input.PropertiesToUpdate ||
                    this.PropertiesToUpdate != null &&
                    input.PropertiesToUpdate != null &&
                    this.PropertiesToUpdate.SequenceEqual(input.PropertiesToUpdate)
                ) && 
                (
                    this.MerchantProductRequestModels == input.MerchantProductRequestModels ||
                    this.MerchantProductRequestModels != null &&
                    input.MerchantProductRequestModels != null &&
                    this.MerchantProductRequestModels.SequenceEqual(input.MerchantProductRequestModels)
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
                if (this.PropertiesToUpdate != null)
                    hashCode = hashCode * 59 + this.PropertiesToUpdate.GetHashCode();
                if (this.MerchantProductRequestModels != null)
                    hashCode = hashCode * 59 + this.MerchantProductRequestModels.GetHashCode();
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

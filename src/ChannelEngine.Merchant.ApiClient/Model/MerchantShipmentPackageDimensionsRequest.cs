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
    /// MerchantShipmentPackageDimensionsRequest
    /// </summary>
    [DataContract(Name = "MerchantShipmentPackageDimensionsRequest")]
    public partial class MerchantShipmentPackageDimensionsRequest : IEquatable<MerchantShipmentPackageDimensionsRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "Unit", EmitDefaultValue = false)]
        public PackageDimensionsUnit? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentPackageDimensionsRequest" /> class.
        /// </summary>
        /// <param name="height">height.</param>
        /// <param name="width">width.</param>
        /// <param name="length">length.</param>
        /// <param name="unit">unit.</param>
        public MerchantShipmentPackageDimensionsRequest(decimal height = default(decimal), decimal width = default(decimal), decimal length = default(decimal), PackageDimensionsUnit? unit = default(PackageDimensionsUnit?))
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "Height", EmitDefaultValue = false)]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "Width", EmitDefaultValue = false)]
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name = "Length", EmitDefaultValue = false)]
        public decimal Length { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantShipmentPackageDimensionsRequest {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as MerchantShipmentPackageDimensionsRequest);
        }

        /// <summary>
        /// Returns true if MerchantShipmentPackageDimensionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantShipmentPackageDimensionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShipmentPackageDimensionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
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
                hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Width.GetHashCode();
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
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

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
    /// VatSettingsResponse
    /// </summary>
    [DataContract(Name = "VatSettingsResponse")]
    public partial class VatSettingsResponse : IEquatable<VatSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatSettingsResponse" /> class.
        /// </summary>
        /// <param name="countryIso">countryIso.</param>
        /// <param name="no">no.</param>
        /// <param name="standardRate">standardRate.</param>
        /// <param name="reducedRate">reducedRate.</param>
        /// <param name="superReducedRate">superReducedRate.</param>
        public VatSettingsResponse(string countryIso = default(string), string no = default(string), decimal standardRate = default(decimal), decimal? reducedRate = default(decimal?), decimal? superReducedRate = default(decimal?))
        {
            this.CountryIso = countryIso;
            this.No = no;
            this.StandardRate = standardRate;
            this.ReducedRate = reducedRate;
            this.SuperReducedRate = superReducedRate;
        }

        /// <summary>
        /// Gets or Sets CountryIso
        /// </summary>
        [DataMember(Name = "CountryIso", EmitDefaultValue = true)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or Sets No
        /// </summary>
        [DataMember(Name = "No", EmitDefaultValue = true)]
        public string No { get; set; }

        /// <summary>
        /// Gets or Sets StandardRate
        /// </summary>
        [DataMember(Name = "StandardRate", EmitDefaultValue = false)]
        public decimal StandardRate { get; set; }

        /// <summary>
        /// Gets or Sets ReducedRate
        /// </summary>
        [DataMember(Name = "ReducedRate", EmitDefaultValue = true)]
        public decimal? ReducedRate { get; set; }

        /// <summary>
        /// Gets or Sets SuperReducedRate
        /// </summary>
        [DataMember(Name = "SuperReducedRate", EmitDefaultValue = true)]
        public decimal? SuperReducedRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VatSettingsResponse {\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  No: ").Append(No).Append("\n");
            sb.Append("  StandardRate: ").Append(StandardRate).Append("\n");
            sb.Append("  ReducedRate: ").Append(ReducedRate).Append("\n");
            sb.Append("  SuperReducedRate: ").Append(SuperReducedRate).Append("\n");
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
            return this.Equals(input as VatSettingsResponse);
        }

        /// <summary>
        /// Returns true if VatSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VatSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VatSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.No == input.No ||
                    (this.No != null &&
                    this.No.Equals(input.No))
                ) && 
                (
                    this.StandardRate == input.StandardRate ||
                    this.StandardRate.Equals(input.StandardRate)
                ) && 
                (
                    this.ReducedRate == input.ReducedRate ||
                    (this.ReducedRate != null &&
                    this.ReducedRate.Equals(input.ReducedRate))
                ) && 
                (
                    this.SuperReducedRate == input.SuperReducedRate ||
                    (this.SuperReducedRate != null &&
                    this.SuperReducedRate.Equals(input.SuperReducedRate))
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
                if (this.CountryIso != null)
                    hashCode = hashCode * 59 + this.CountryIso.GetHashCode();
                if (this.No != null)
                    hashCode = hashCode * 59 + this.No.GetHashCode();
                hashCode = hashCode * 59 + this.StandardRate.GetHashCode();
                if (this.ReducedRate != null)
                    hashCode = hashCode * 59 + this.ReducedRate.GetHashCode();
                if (this.SuperReducedRate != null)
                    hashCode = hashCode * 59 + this.SuperReducedRate.GetHashCode();
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

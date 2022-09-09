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
    /// MerchantStockLocationAddressRequest
    /// </summary>
    [DataContract(Name = "MerchantStockLocationAddressRequest")]
    public partial class MerchantStockLocationAddressRequest : IEquatable<MerchantStockLocationAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantStockLocationAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantStockLocationAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantStockLocationAddressRequest" /> class.
        /// </summary>
        /// <param name="countryIso">countryIso (required).</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="zipCode">zipCode.</param>
        /// <param name="houseNr">houseNr.</param>
        /// <param name="houseNrAddition">houseNrAddition.</param>
        /// <param name="city">city.</param>
        /// <param name="region">region.</param>
        public MerchantStockLocationAddressRequest(string countryIso = default(string), string streetName = default(string), string zipCode = default(string), string houseNr = default(string), string houseNrAddition = default(string), string city = default(string), string region = default(string))
        {
            // to ensure "countryIso" is required (not null)
            if (countryIso == null) {
                throw new ArgumentNullException("countryIso is a required property for MerchantStockLocationAddressRequest and cannot be null");
            }
            this.CountryIso = countryIso;
            this.StreetName = streetName;
            this.ZipCode = zipCode;
            this.HouseNr = houseNr;
            this.HouseNrAddition = houseNrAddition;
            this.City = city;
            this.Region = region;
        }

        /// <summary>
        /// Gets or Sets CountryIso
        /// </summary>
        [DataMember(Name = "CountryIso", IsRequired = true, EmitDefaultValue = false)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name = "StreetName", EmitDefaultValue = true)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name = "ZipCode", EmitDefaultValue = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets HouseNr
        /// </summary>
        [DataMember(Name = "HouseNr", EmitDefaultValue = true)]
        public string HouseNr { get; set; }

        /// <summary>
        /// Gets or Sets HouseNrAddition
        /// </summary>
        [DataMember(Name = "HouseNrAddition", EmitDefaultValue = true)]
        public string HouseNrAddition { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "City", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "Region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantStockLocationAddressRequest {\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  HouseNr: ").Append(HouseNr).Append("\n");
            sb.Append("  HouseNrAddition: ").Append(HouseNrAddition).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
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
            return this.Equals(input as MerchantStockLocationAddressRequest);
        }

        /// <summary>
        /// Returns true if MerchantStockLocationAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantStockLocationAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantStockLocationAddressRequest input)
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
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.HouseNr == input.HouseNr ||
                    (this.HouseNr != null &&
                    this.HouseNr.Equals(input.HouseNr))
                ) && 
                (
                    this.HouseNrAddition == input.HouseNrAddition ||
                    (this.HouseNrAddition != null &&
                    this.HouseNrAddition.Equals(input.HouseNrAddition))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
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
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.HouseNr != null)
                    hashCode = hashCode * 59 + this.HouseNr.GetHashCode();
                if (this.HouseNrAddition != null)
                    hashCode = hashCode * 59 + this.HouseNrAddition.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
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
            // StreetName (string) maxLength
            if(this.StreetName != null && this.StreetName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetName, length must be less than 50.", new [] { "StreetName" });
            }

            // StreetName (string) minLength
            if(this.StreetName != null && this.StreetName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetName, length must be greater than 0.", new [] { "StreetName" });
            }

            // HouseNr (string) maxLength
            if(this.HouseNr != null && this.HouseNr.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNr, length must be less than 50.", new [] { "HouseNr" });
            }

            // HouseNr (string) minLength
            if(this.HouseNr != null && this.HouseNr.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNr, length must be greater than 0.", new [] { "HouseNr" });
            }

            // HouseNrAddition (string) maxLength
            if(this.HouseNrAddition != null && this.HouseNrAddition.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNrAddition, length must be less than 50.", new [] { "HouseNrAddition" });
            }

            // HouseNrAddition (string) minLength
            if(this.HouseNrAddition != null && this.HouseNrAddition.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNrAddition, length must be greater than 0.", new [] { "HouseNrAddition" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 50.", new [] { "City" });
            }

            // City (string) minLength
            if(this.City != null && this.City.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be greater than 0.", new [] { "City" });
            }

            // Region (string) maxLength
            if(this.Region != null && this.Region.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be less than 50.", new [] { "Region" });
            }

            // Region (string) minLength
            if(this.Region != null && this.Region.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be greater than 0.", new [] { "Region" });
            }

            yield break;
        }
    }

}

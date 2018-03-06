/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.6.0
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
using SwaggerDateConverter = ChannelEngine.Merchant.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Defines Gender
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALE = 1,
            
            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALE = 2,
            
            /// <summary>
            /// Enum NOTAPPLICABLE for value: NOT_APPLICABLE
            /// </summary>
            [EnumMember(Value = "NOT_APPLICABLE")]
            NOTAPPLICABLE = 3
        }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="Gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="gender">gender.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="houseNr">houseNr.</param>
        /// <param name="houseNrAddition">houseNrAddition.</param>
        /// <param name="zipCode">zipCode.</param>
        /// <param name="city">city.</param>
        /// <param name="region">region.</param>
        /// <param name="countryIso">For example: NL, BE, FR.</param>
        /// <param name="original">original.</param>
        public Address(GenderEnum? gender = default(GenderEnum?), string companyName = default(string), string firstName = default(string), string lastName = default(string), string streetName = default(string), string houseNr = default(string), string houseNrAddition = default(string), string zipCode = default(string), string city = default(string), string region = default(string), string countryIso = default(string), string original = default(string))
        {
            this.Gender = gender;
            this.CompanyName = companyName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StreetName = streetName;
            this.HouseNr = houseNr;
            this.HouseNrAddition = houseNrAddition;
            this.ZipCode = zipCode;
            this.City = city;
            this.Region = region;
            this.CountryIso = countryIso;
            this.Original = original;
        }
        

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="CompanyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="StreetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets HouseNr
        /// </summary>
        [DataMember(Name="HouseNr", EmitDefaultValue=false)]
        public string HouseNr { get; set; }

        /// <summary>
        /// Gets or Sets HouseNrAddition
        /// </summary>
        [DataMember(Name="HouseNrAddition", EmitDefaultValue=false)]
        public string HouseNrAddition { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="ZipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// For example: NL, BE, FR
        /// </summary>
        /// <value>For example: NL, BE, FR</value>
        [DataMember(Name="CountryIso", EmitDefaultValue=false)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or Sets Original
        /// </summary>
        [DataMember(Name="Original", EmitDefaultValue=false)]
        public string Original { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  HouseNr: ").Append(HouseNr).Append("\n");
            sb.Append("  HouseNrAddition: ").Append(HouseNrAddition).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
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
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
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
                ) && 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.Original == input.Original ||
                    (this.Original != null &&
                    this.Original.Equals(input.Original))
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
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.HouseNr != null)
                    hashCode = hashCode * 59 + this.HouseNr.GetHashCode();
                if (this.HouseNrAddition != null)
                    hashCode = hashCode * 59 + this.HouseNrAddition.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CountryIso != null)
                    hashCode = hashCode * 59 + this.CountryIso.GetHashCode();
                if (this.Original != null)
                    hashCode = hashCode * 59 + this.Original.GetHashCode();
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
            // CompanyName (string) maxLength
            if(this.CompanyName != null && this.CompanyName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be less than 50.", new [] { "CompanyName" });
            }

            // CompanyName (string) minLength
            if(this.CompanyName != null && this.CompanyName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be greater than 0.", new [] { "CompanyName" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 50.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if(this.FirstName != null && this.FirstName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 0.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 50.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if(this.LastName != null && this.LastName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 0.", new [] { "LastName" });
            }

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

            // CountryIso (string) maxLength
            if(this.CountryIso != null && this.CountryIso.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryIso, length must be less than 2.", new [] { "CountryIso" });
            }

            // CountryIso (string) minLength
            if(this.CountryIso != null && this.CountryIso.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryIso, length must be greater than 0.", new [] { "CountryIso" });
            }

            // Original (string) maxLength
            if(this.Original != null && this.Original.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Original, length must be less than 256.", new [] { "Original" });
            }

            // Original (string) minLength
            if(this.Original != null && this.Original.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Original, length must be greater than 0.", new [] { "Original" });
            }

            yield break;
        }
    }

}

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
    /// EntitiesAddressModels
    /// </summary>
    [DataContract]
    public partial class EntitiesAddressModels :  IEquatable<EntitiesAddressModels>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum MALE for "MALE"
            /// </summary>
            [EnumMember(Value = "MALE")]
            MALE,
            
            /// <summary>
            /// Enum FEMALE for "FEMALE"
            /// </summary>
            [EnumMember(Value = "FEMALE")]
            FEMALE,
            
            /// <summary>
            /// Enum NOTAPPLICABLE for "NOT_APPLICABLE"
            /// </summary>
            [EnumMember(Value = "NOT_APPLICABLE")]
            NOTAPPLICABLE
        }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="Gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesAddressModels" /> class.
        /// </summary>
        /// <param name="Gender">Gender.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="StreetName">StreetName.</param>
        /// <param name="HouseNr">HouseNr.</param>
        /// <param name="HouseNrAddition">HouseNrAddition.</param>
        /// <param name="ZipCode">ZipCode.</param>
        /// <param name="City">City.</param>
        /// <param name="Region">Region.</param>
        /// <param name="CountryIso">CountryIso.</param>
        /// <param name="Original">Original.</param>
        public EntitiesAddressModels(GenderEnum? Gender = default(GenderEnum?), string CompanyName = default(string), string FirstName = default(string), string LastName = default(string), string StreetName = default(string), string HouseNr = default(string), string HouseNrAddition = default(string), string ZipCode = default(string), string City = default(string), string Region = default(string), string CountryIso = default(string), string Original = default(string))
        {
            this.Gender = Gender;
            this.CompanyName = CompanyName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StreetName = StreetName;
            this.HouseNr = HouseNr;
            this.HouseNrAddition = HouseNrAddition;
            this.ZipCode = ZipCode;
            this.City = City;
            this.Region = Region;
            this.CountryIso = CountryIso;
            this.Original = Original;
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
        /// Gets or Sets CountryIso
        /// </summary>
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
            sb.Append("class EntitiesAddressModels {\n");
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EntitiesAddressModels);
        }

        /// <summary>
        /// Returns true if EntitiesAddressModels instances are equal
        /// </summary>
        /// <param name="other">Instance of EntitiesAddressModels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitiesAddressModels other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.StreetName == other.StreetName ||
                    this.StreetName != null &&
                    this.StreetName.Equals(other.StreetName)
                ) && 
                (
                    this.HouseNr == other.HouseNr ||
                    this.HouseNr != null &&
                    this.HouseNr.Equals(other.HouseNr)
                ) && 
                (
                    this.HouseNrAddition == other.HouseNrAddition ||
                    this.HouseNrAddition != null &&
                    this.HouseNrAddition.Equals(other.HouseNrAddition)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.CountryIso == other.CountryIso ||
                    this.CountryIso != null &&
                    this.CountryIso.Equals(other.CountryIso)
                ) && 
                (
                    this.Original == other.Original ||
                    this.Original != null &&
                    this.Original.Equals(other.Original)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.StreetName != null)
                    hash = hash * 59 + this.StreetName.GetHashCode();
                if (this.HouseNr != null)
                    hash = hash * 59 + this.HouseNr.GetHashCode();
                if (this.HouseNrAddition != null)
                    hash = hash * 59 + this.HouseNrAddition.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.CountryIso != null)
                    hash = hash * 59 + this.CountryIso.GetHashCode();
                if (this.Original != null)
                    hash = hash * 59 + this.Original.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
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

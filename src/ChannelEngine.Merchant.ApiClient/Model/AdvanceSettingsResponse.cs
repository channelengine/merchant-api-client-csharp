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
    /// AdvanceSettingsResponse
    /// </summary>
    [DataContract(Name = "AdvanceSettingsResponse")]
    public partial class AdvanceSettingsResponse : IEquatable<AdvanceSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceSettingsResponse" /> class.
        /// </summary>
        /// <param name="manageStock">manageStock.</param>
        /// <param name="disableAddressValidation">disableAddressValidation.</param>
        /// <param name="skipHouseNumberValidation">skipHouseNumberValidation.</param>
        /// <param name="skipHouseNumberValidationForCountryCodes">skipHouseNumberValidationForCountryCodes.</param>
        /// <param name="setOrdersToClosedOnImport">setOrdersToClosedOnImport.</param>
        /// <param name="disableStockReservation">disableStockReservation.</param>
        /// <param name="disableAutoOrderCancellation">disableAutoOrderCancellation.</param>
        /// <param name="automaticallySetPhoneNumberIfEmpty">automaticallySetPhoneNumberIfEmpty.</param>
        /// <param name="defaultVatRate">defaultVatRate.</param>
        /// <param name="orderTooLongOnNewHoursOffset">orderTooLongOnNewHoursOffset.</param>
        public AdvanceSettingsResponse(bool manageStock = default(bool), bool disableAddressValidation = default(bool), bool skipHouseNumberValidation = default(bool), List<string> skipHouseNumberValidationForCountryCodes = default(List<string>), bool setOrdersToClosedOnImport = default(bool), bool disableStockReservation = default(bool), bool disableAutoOrderCancellation = default(bool), string automaticallySetPhoneNumberIfEmpty = default(string), decimal defaultVatRate = default(decimal), int orderTooLongOnNewHoursOffset = default(int))
        {
            this.ManageStock = manageStock;
            this.DisableAddressValidation = disableAddressValidation;
            this.SkipHouseNumberValidation = skipHouseNumberValidation;
            this.SkipHouseNumberValidationForCountryCodes = skipHouseNumberValidationForCountryCodes;
            this.SetOrdersToClosedOnImport = setOrdersToClosedOnImport;
            this.DisableStockReservation = disableStockReservation;
            this.DisableAutoOrderCancellation = disableAutoOrderCancellation;
            this.AutomaticallySetPhoneNumberIfEmpty = automaticallySetPhoneNumberIfEmpty;
            this.DefaultVatRate = defaultVatRate;
            this.OrderTooLongOnNewHoursOffset = orderTooLongOnNewHoursOffset;
        }

        /// <summary>
        /// Gets or Sets ManageStock
        /// </summary>
        [DataMember(Name = "ManageStock", EmitDefaultValue = true)]
        public bool ManageStock { get; set; }

        /// <summary>
        /// Gets or Sets DisableAddressValidation
        /// </summary>
        [DataMember(Name = "DisableAddressValidation", EmitDefaultValue = true)]
        public bool DisableAddressValidation { get; set; }

        /// <summary>
        /// Gets or Sets SkipHouseNumberValidation
        /// </summary>
        [DataMember(Name = "SkipHouseNumberValidation", EmitDefaultValue = true)]
        public bool SkipHouseNumberValidation { get; set; }

        /// <summary>
        /// Gets or Sets SkipHouseNumberValidationForCountryCodes
        /// </summary>
        [DataMember(Name = "SkipHouseNumberValidationForCountryCodes", EmitDefaultValue = true)]
        public List<string> SkipHouseNumberValidationForCountryCodes { get; set; }

        /// <summary>
        /// Gets or Sets SetOrdersToClosedOnImport
        /// </summary>
        [DataMember(Name = "SetOrdersToClosedOnImport", EmitDefaultValue = true)]
        public bool SetOrdersToClosedOnImport { get; set; }

        /// <summary>
        /// Gets or Sets DisableStockReservation
        /// </summary>
        [DataMember(Name = "DisableStockReservation", EmitDefaultValue = true)]
        public bool DisableStockReservation { get; set; }

        /// <summary>
        /// Gets or Sets DisableAutoOrderCancellation
        /// </summary>
        [DataMember(Name = "DisableAutoOrderCancellation", EmitDefaultValue = true)]
        public bool DisableAutoOrderCancellation { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticallySetPhoneNumberIfEmpty
        /// </summary>
        [DataMember(Name = "AutomaticallySetPhoneNumberIfEmpty", EmitDefaultValue = true)]
        public string AutomaticallySetPhoneNumberIfEmpty { get; set; }

        /// <summary>
        /// Gets or Sets DefaultVatRate
        /// </summary>
        [DataMember(Name = "DefaultVatRate", EmitDefaultValue = false)]
        public decimal DefaultVatRate { get; set; }

        /// <summary>
        /// Gets or Sets OrderTooLongOnNewHoursOffset
        /// </summary>
        [DataMember(Name = "OrderTooLongOnNewHoursOffset", EmitDefaultValue = false)]
        public int OrderTooLongOnNewHoursOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvanceSettingsResponse {\n");
            sb.Append("  ManageStock: ").Append(ManageStock).Append("\n");
            sb.Append("  DisableAddressValidation: ").Append(DisableAddressValidation).Append("\n");
            sb.Append("  SkipHouseNumberValidation: ").Append(SkipHouseNumberValidation).Append("\n");
            sb.Append("  SkipHouseNumberValidationForCountryCodes: ").Append(SkipHouseNumberValidationForCountryCodes).Append("\n");
            sb.Append("  SetOrdersToClosedOnImport: ").Append(SetOrdersToClosedOnImport).Append("\n");
            sb.Append("  DisableStockReservation: ").Append(DisableStockReservation).Append("\n");
            sb.Append("  DisableAutoOrderCancellation: ").Append(DisableAutoOrderCancellation).Append("\n");
            sb.Append("  AutomaticallySetPhoneNumberIfEmpty: ").Append(AutomaticallySetPhoneNumberIfEmpty).Append("\n");
            sb.Append("  DefaultVatRate: ").Append(DefaultVatRate).Append("\n");
            sb.Append("  OrderTooLongOnNewHoursOffset: ").Append(OrderTooLongOnNewHoursOffset).Append("\n");
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
            return this.Equals(input as AdvanceSettingsResponse);
        }

        /// <summary>
        /// Returns true if AdvanceSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvanceSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvanceSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ManageStock == input.ManageStock ||
                    this.ManageStock.Equals(input.ManageStock)
                ) && 
                (
                    this.DisableAddressValidation == input.DisableAddressValidation ||
                    this.DisableAddressValidation.Equals(input.DisableAddressValidation)
                ) && 
                (
                    this.SkipHouseNumberValidation == input.SkipHouseNumberValidation ||
                    this.SkipHouseNumberValidation.Equals(input.SkipHouseNumberValidation)
                ) && 
                (
                    this.SkipHouseNumberValidationForCountryCodes == input.SkipHouseNumberValidationForCountryCodes ||
                    this.SkipHouseNumberValidationForCountryCodes != null &&
                    input.SkipHouseNumberValidationForCountryCodes != null &&
                    this.SkipHouseNumberValidationForCountryCodes.SequenceEqual(input.SkipHouseNumberValidationForCountryCodes)
                ) && 
                (
                    this.SetOrdersToClosedOnImport == input.SetOrdersToClosedOnImport ||
                    this.SetOrdersToClosedOnImport.Equals(input.SetOrdersToClosedOnImport)
                ) && 
                (
                    this.DisableStockReservation == input.DisableStockReservation ||
                    this.DisableStockReservation.Equals(input.DisableStockReservation)
                ) && 
                (
                    this.DisableAutoOrderCancellation == input.DisableAutoOrderCancellation ||
                    this.DisableAutoOrderCancellation.Equals(input.DisableAutoOrderCancellation)
                ) && 
                (
                    this.AutomaticallySetPhoneNumberIfEmpty == input.AutomaticallySetPhoneNumberIfEmpty ||
                    (this.AutomaticallySetPhoneNumberIfEmpty != null &&
                    this.AutomaticallySetPhoneNumberIfEmpty.Equals(input.AutomaticallySetPhoneNumberIfEmpty))
                ) && 
                (
                    this.DefaultVatRate == input.DefaultVatRate ||
                    this.DefaultVatRate.Equals(input.DefaultVatRate)
                ) && 
                (
                    this.OrderTooLongOnNewHoursOffset == input.OrderTooLongOnNewHoursOffset ||
                    this.OrderTooLongOnNewHoursOffset.Equals(input.OrderTooLongOnNewHoursOffset)
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
                hashCode = hashCode * 59 + this.ManageStock.GetHashCode();
                hashCode = hashCode * 59 + this.DisableAddressValidation.GetHashCode();
                hashCode = hashCode * 59 + this.SkipHouseNumberValidation.GetHashCode();
                if (this.SkipHouseNumberValidationForCountryCodes != null)
                    hashCode = hashCode * 59 + this.SkipHouseNumberValidationForCountryCodes.GetHashCode();
                hashCode = hashCode * 59 + this.SetOrdersToClosedOnImport.GetHashCode();
                hashCode = hashCode * 59 + this.DisableStockReservation.GetHashCode();
                hashCode = hashCode * 59 + this.DisableAutoOrderCancellation.GetHashCode();
                if (this.AutomaticallySetPhoneNumberIfEmpty != null)
                    hashCode = hashCode * 59 + this.AutomaticallySetPhoneNumberIfEmpty.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultVatRate.GetHashCode();
                hashCode = hashCode * 59 + this.OrderTooLongOnNewHoursOffset.GetHashCode();
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

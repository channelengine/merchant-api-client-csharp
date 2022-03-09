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
    /// SettingsResponse
    /// </summary>
    [DataContract(Name = "SettingsResponse")]
    public partial class SettingsResponse : IEquatable<SettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsResponse" /> class.
        /// </summary>
        /// <param name="shipment">shipment.</param>
        /// <param name="advanced">advanced.</param>
        public SettingsResponse(ShipmentSettingsResponse shipment = default(ShipmentSettingsResponse), AdvanceSettingsResponse advanced = default(AdvanceSettingsResponse))
        {
            this.Shipment = shipment;
            this.Advanced = advanced;
        }

        /// <summary>
        /// Gets or Sets Shipment
        /// </summary>
        [DataMember(Name = "Shipment", EmitDefaultValue = false)]
        public ShipmentSettingsResponse Shipment { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "Advanced", EmitDefaultValue = false)]
        public AdvanceSettingsResponse Advanced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsResponse {\n");
            sb.Append("  Shipment: ").Append(Shipment).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
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
            return this.Equals(input as SettingsResponse);
        }

        /// <summary>
        /// Returns true if SettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Shipment == input.Shipment ||
                    (this.Shipment != null &&
                    this.Shipment.Equals(input.Shipment))
                ) && 
                (
                    this.Advanced == input.Advanced ||
                    (this.Advanced != null &&
                    this.Advanced.Equals(input.Advanced))
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
                if (this.Shipment != null)
                    hashCode = hashCode * 59 + this.Shipment.GetHashCode();
                if (this.Advanced != null)
                    hashCode = hashCode * 59 + this.Advanced.GetHashCode();
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

/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.11
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
    /// ShipmentSettingsResponse
    /// </summary>
    [DataContract(Name = "ShipmentSettingsResponse")]
    public partial class ShipmentSettingsResponse : IEquatable<ShipmentSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentSettingsResponse" /> class.
        /// </summary>
        /// <param name="defaultTrackedShipmentMethod">defaultTrackedShipmentMethod.</param>
        /// <param name="defaultUntrackedShipmentMethod">defaultUntrackedShipmentMethod.</param>
        /// <param name="automaticallySetShipmentMethodAfterMinutes">automaticallySetShipmentMethodAfterMinutes.</param>
        public ShipmentSettingsResponse(string defaultTrackedShipmentMethod = default(string), string defaultUntrackedShipmentMethod = default(string), int? automaticallySetShipmentMethodAfterMinutes = default(int?))
        {
            this.DefaultTrackedShipmentMethod = defaultTrackedShipmentMethod;
            this.DefaultUntrackedShipmentMethod = defaultUntrackedShipmentMethod;
            this.AutomaticallySetShipmentMethodAfterMinutes = automaticallySetShipmentMethodAfterMinutes;
        }

        /// <summary>
        /// Gets or Sets DefaultTrackedShipmentMethod
        /// </summary>
        [DataMember(Name = "DefaultTrackedShipmentMethod", EmitDefaultValue = true)]
        public string DefaultTrackedShipmentMethod { get; set; }

        /// <summary>
        /// Gets or Sets DefaultUntrackedShipmentMethod
        /// </summary>
        [DataMember(Name = "DefaultUntrackedShipmentMethod", EmitDefaultValue = true)]
        public string DefaultUntrackedShipmentMethod { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticallySetShipmentMethodAfterMinutes
        /// </summary>
        [DataMember(Name = "AutomaticallySetShipmentMethodAfterMinutes", EmitDefaultValue = true)]
        public int? AutomaticallySetShipmentMethodAfterMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentSettingsResponse {\n");
            sb.Append("  DefaultTrackedShipmentMethod: ").Append(DefaultTrackedShipmentMethod).Append("\n");
            sb.Append("  DefaultUntrackedShipmentMethod: ").Append(DefaultUntrackedShipmentMethod).Append("\n");
            sb.Append("  AutomaticallySetShipmentMethodAfterMinutes: ").Append(AutomaticallySetShipmentMethodAfterMinutes).Append("\n");
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
            return this.Equals(input as ShipmentSettingsResponse);
        }

        /// <summary>
        /// Returns true if ShipmentSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultTrackedShipmentMethod == input.DefaultTrackedShipmentMethod ||
                    (this.DefaultTrackedShipmentMethod != null &&
                    this.DefaultTrackedShipmentMethod.Equals(input.DefaultTrackedShipmentMethod))
                ) && 
                (
                    this.DefaultUntrackedShipmentMethod == input.DefaultUntrackedShipmentMethod ||
                    (this.DefaultUntrackedShipmentMethod != null &&
                    this.DefaultUntrackedShipmentMethod.Equals(input.DefaultUntrackedShipmentMethod))
                ) && 
                (
                    this.AutomaticallySetShipmentMethodAfterMinutes == input.AutomaticallySetShipmentMethodAfterMinutes ||
                    (this.AutomaticallySetShipmentMethodAfterMinutes != null &&
                    this.AutomaticallySetShipmentMethodAfterMinutes.Equals(input.AutomaticallySetShipmentMethodAfterMinutes))
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
                if (this.DefaultTrackedShipmentMethod != null)
                    hashCode = hashCode * 59 + this.DefaultTrackedShipmentMethod.GetHashCode();
                if (this.DefaultUntrackedShipmentMethod != null)
                    hashCode = hashCode * 59 + this.DefaultUntrackedShipmentMethod.GetHashCode();
                if (this.AutomaticallySetShipmentMethodAfterMinutes != null)
                    hashCode = hashCode * 59 + this.AutomaticallySetShipmentMethodAfterMinutes.GetHashCode();
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

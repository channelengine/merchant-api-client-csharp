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
    /// MerchantReturnUpdateRequest
    /// </summary>
    [DataContract(Name = "MerchantReturnUpdateRequest")]
    public partial class MerchantReturnUpdateRequest : IEquatable<MerchantReturnUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnUpdateRequest" /> class.
        /// </summary>
        /// <param name="returnId">The ChannelEngine return ID of the return you would like to update. (required).</param>
        /// <param name="lines">lines (required).</param>
        public MerchantReturnUpdateRequest(int returnId = default(int), List<MerchantReturnLineUpdateRequest> lines = default(List<MerchantReturnLineUpdateRequest>))
        {
            this.ReturnId = returnId;
            // to ensure "lines" is required (not null)
            if (lines == null) {
                throw new ArgumentNullException("lines is a required property for MerchantReturnUpdateRequest and cannot be null");
            }
            this.Lines = lines;
        }

        /// <summary>
        /// The ChannelEngine return ID of the return you would like to update.
        /// </summary>
        /// <value>The ChannelEngine return ID of the return you would like to update.</value>
        [DataMember(Name = "ReturnId", IsRequired = true, EmitDefaultValue = false)]
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", IsRequired = true, EmitDefaultValue = false)]
        public List<MerchantReturnLineUpdateRequest> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnUpdateRequest {\n");
            sb.Append("  ReturnId: ").Append(ReturnId).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(input as MerchantReturnUpdateRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnId == input.ReturnId ||
                    this.ReturnId.Equals(input.ReturnId)
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                hashCode = hashCode * 59 + this.ReturnId.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
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
            yield break;
        }
    }

}

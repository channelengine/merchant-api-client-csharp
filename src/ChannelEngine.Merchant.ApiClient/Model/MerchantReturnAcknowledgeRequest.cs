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
    /// MerchantReturnAcknowledgeRequest
    /// </summary>
    [DataContract(Name = "MerchantReturnAcknowledgeRequest")]
    public partial class MerchantReturnAcknowledgeRequest : IEquatable<MerchantReturnAcknowledgeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnAcknowledgeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnAcknowledgeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnAcknowledgeRequest" /> class.
        /// </summary>
        /// <param name="returnId">returnId.</param>
        /// <param name="merchantReturnNo">merchantReturnNo (required).</param>
        public MerchantReturnAcknowledgeRequest(int returnId = default(int), string merchantReturnNo = default(string))
        {
            // to ensure "merchantReturnNo" is required (not null)
            if (merchantReturnNo == null) {
                throw new ArgumentNullException("merchantReturnNo is a required property for MerchantReturnAcknowledgeRequest and cannot be null");
            }
            this.MerchantReturnNo = merchantReturnNo;
            this.ReturnId = returnId;
        }

        /// <summary>
        /// Gets or Sets ReturnId
        /// </summary>
        [DataMember(Name = "ReturnId", EmitDefaultValue = false)]
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantReturnNo
        /// </summary>
        [DataMember(Name = "MerchantReturnNo", IsRequired = true, EmitDefaultValue = false)]
        public string MerchantReturnNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnAcknowledgeRequest {\n");
            sb.Append("  ReturnId: ").Append(ReturnId).Append("\n");
            sb.Append("  MerchantReturnNo: ").Append(MerchantReturnNo).Append("\n");
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
            return this.Equals(input as MerchantReturnAcknowledgeRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnAcknowledgeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnAcknowledgeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnAcknowledgeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnId == input.ReturnId ||
                    this.ReturnId.Equals(input.ReturnId)
                ) && 
                (
                    this.MerchantReturnNo == input.MerchantReturnNo ||
                    (this.MerchantReturnNo != null &&
                    this.MerchantReturnNo.Equals(input.MerchantReturnNo))
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
                if (this.MerchantReturnNo != null)
                    hashCode = hashCode * 59 + this.MerchantReturnNo.GetHashCode();
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
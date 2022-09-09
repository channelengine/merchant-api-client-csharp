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
    /// MerchantShipmentLabelCarrierResponse
    /// </summary>
    [DataContract(Name = "MerchantShipmentLabelCarrierResponse")]
    public partial class MerchantShipmentLabelCarrierResponse : IEquatable<MerchantShipmentLabelCarrierResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Recommendation
        /// </summary>
        [DataMember(Name = "Recommendation", EmitDefaultValue = false)]
        public ChannelCarrierRecommendationApi? Recommendation { get; set; }

        /// <summary>
        /// Gets or Sets CollectionMethod
        /// </summary>
        [DataMember(Name = "CollectionMethod", EmitDefaultValue = false)]
        public ChannelCarrierCollectionMethodApi? CollectionMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShipmentLabelCarrierResponse" /> class.
        /// </summary>
        /// <param name="name">The channel&#39;s name for the shipping label carrier.</param>
        /// <param name="code">The channel&#39;s code for the shipping label carrier.</param>
        /// <param name="restrictions">Optional. Any restrictions on this carriers, e.g. weight and/or dimensions.</param>
        /// <param name="price">Optional. Price for this shipping label.</param>
        /// <param name="recommendation">recommendation.</param>
        /// <param name="collectionMethod">collectionMethod.</param>
        /// <param name="handoverDateTime">Optional. When to handover the package to the carrier  It is in the ISO format including the timezone offset.  E.g. 2020-10-03T18:00:00+02:00  which is 3rd Oct 2020, at 18:00 PM in Amsterdam (Summer Time aka CEST: UTC +2:00 ).</param>
        public MerchantShipmentLabelCarrierResponse(string name = default(string), string code = default(string), string restrictions = default(string), decimal? price = default(decimal?), ChannelCarrierRecommendationApi? recommendation = default(ChannelCarrierRecommendationApi?), ChannelCarrierCollectionMethodApi? collectionMethod = default(ChannelCarrierCollectionMethodApi?), DateTime? handoverDateTime = default(DateTime?))
        {
            this.Name = name;
            this.Code = code;
            this.Restrictions = restrictions;
            this.Price = price;
            this.Recommendation = recommendation;
            this.CollectionMethod = collectionMethod;
            this.HandoverDateTime = handoverDateTime;
        }

        /// <summary>
        /// The channel&#39;s name for the shipping label carrier
        /// </summary>
        /// <value>The channel&#39;s name for the shipping label carrier</value>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The channel&#39;s code for the shipping label carrier
        /// </summary>
        /// <value>The channel&#39;s code for the shipping label carrier</value>
        [DataMember(Name = "Code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Optional. Any restrictions on this carriers, e.g. weight and/or dimensions
        /// </summary>
        /// <value>Optional. Any restrictions on this carriers, e.g. weight and/or dimensions</value>
        [DataMember(Name = "Restrictions", EmitDefaultValue = true)]
        public string Restrictions { get; set; }

        /// <summary>
        /// Optional. Price for this shipping label
        /// </summary>
        /// <value>Optional. Price for this shipping label</value>
        [DataMember(Name = "Price", EmitDefaultValue = true)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Optional. When to handover the package to the carrier  It is in the ISO format including the timezone offset.  E.g. 2020-10-03T18:00:00+02:00  which is 3rd Oct 2020, at 18:00 PM in Amsterdam (Summer Time aka CEST: UTC +2:00 )
        /// </summary>
        /// <value>Optional. When to handover the package to the carrier  It is in the ISO format including the timezone offset.  E.g. 2020-10-03T18:00:00+02:00  which is 3rd Oct 2020, at 18:00 PM in Amsterdam (Summer Time aka CEST: UTC +2:00 )</value>
        [DataMember(Name = "HandoverDateTime", EmitDefaultValue = true)]
        public DateTime? HandoverDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantShipmentLabelCarrierResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Recommendation: ").Append(Recommendation).Append("\n");
            sb.Append("  CollectionMethod: ").Append(CollectionMethod).Append("\n");
            sb.Append("  HandoverDateTime: ").Append(HandoverDateTime).Append("\n");
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
            return this.Equals(input as MerchantShipmentLabelCarrierResponse);
        }

        /// <summary>
        /// Returns true if MerchantShipmentLabelCarrierResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantShipmentLabelCarrierResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShipmentLabelCarrierResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Restrictions == input.Restrictions ||
                    (this.Restrictions != null &&
                    this.Restrictions.Equals(input.Restrictions))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Recommendation == input.Recommendation ||
                    this.Recommendation.Equals(input.Recommendation)
                ) && 
                (
                    this.CollectionMethod == input.CollectionMethod ||
                    this.CollectionMethod.Equals(input.CollectionMethod)
                ) && 
                (
                    this.HandoverDateTime == input.HandoverDateTime ||
                    (this.HandoverDateTime != null &&
                    this.HandoverDateTime.Equals(input.HandoverDateTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Restrictions != null)
                    hashCode = hashCode * 59 + this.Restrictions.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Recommendation.GetHashCode();
                hashCode = hashCode * 59 + this.CollectionMethod.GetHashCode();
                if (this.HandoverDateTime != null)
                    hashCode = hashCode * 59 + this.HandoverDateTime.GetHashCode();
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

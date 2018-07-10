/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ChannelEngine.Merchant.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// OrderAcknowledgement
    /// </summary>
    [DataContract]
    public partial class OrderAcknowledgement :  IEquatable<OrderAcknowledgement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAcknowledgement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderAcknowledgement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAcknowledgement" /> class.
        /// </summary>
        /// <param name="merchantOrderNo">Your own order reference, this will be used in consecutive order processing API calls (required).</param>
        /// <param name="orderId">The ChannelEngine order ID of the order you would like to acknowledge (required).</param>
        public OrderAcknowledgement(string merchantOrderNo = default(string), int? orderId = default(int?))
        {
            // to ensure "merchantOrderNo" is required (not null)
            if (merchantOrderNo == null)
            {
                throw new InvalidDataException("merchantOrderNo is a required property for OrderAcknowledgement and cannot be null");
            }
            else
            {
                this.MerchantOrderNo = merchantOrderNo;
            }
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for OrderAcknowledgement and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
        }
        
        /// <summary>
        /// Your own order reference, this will be used in consecutive order processing API calls
        /// </summary>
        /// <value>Your own order reference, this will be used in consecutive order processing API calls</value>
        [DataMember(Name="MerchantOrderNo", EmitDefaultValue=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The ChannelEngine order ID of the order you would like to acknowledge
        /// </summary>
        /// <value>The ChannelEngine order ID of the order you would like to acknowledge</value>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderAcknowledgement {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as OrderAcknowledgement);
        }

        /// <summary>
        /// Returns true if OrderAcknowledgement instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderAcknowledgement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderAcknowledgement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                return hashCode;
            }
        }
    }

}

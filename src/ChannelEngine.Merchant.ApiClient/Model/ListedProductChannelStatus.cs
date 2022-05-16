/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.11.0
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
    /// Defines ListedProductChannelStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListedProductChannelStatus
    {
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 1,

        /// <summary>
        /// Enum PUBLISHED for value: PUBLISHED
        /// </summary>
        [EnumMember(Value = "PUBLISHED")]
        PUBLISHED = 2,

        /// <summary>
        /// Enum NOTPUBLISHED for value: NOT_PUBLISHED
        /// </summary>
        [EnumMember(Value = "NOT_PUBLISHED")]
        NOT_PUBLISHED = 3,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,

        /// <summary>
        /// Enum UNDERREVIEW for value: UNDER_REVIEW
        /// </summary>
        [EnumMember(Value = "UNDER_REVIEW")]
        UNDER_REVIEW = 5,

        /// <summary>
        /// Enum INVALIDONCREATE for value: INVALID_ON_CREATE
        /// </summary>
        [EnumMember(Value = "INVALID_ON_CREATE")]
        INVALID_ON_CREATE = 6

    }
}

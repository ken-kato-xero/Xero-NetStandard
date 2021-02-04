/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.4
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Defines PaymentFrequencyType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum PaymentFrequencyType
    {
        /// <summary>
        /// Enum WEEKLY for value: WEEKLY
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY = 1,

        /// <summary>
        /// Enum MONTHLY for value: MONTHLY
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY = 2,

        /// <summary>
        /// Enum FORTNIGHTLY for value: FORTNIGHTLY
        /// </summary>
        [EnumMember(Value = "FORTNIGHTLY")]
        FORTNIGHTLY = 3,

        /// <summary>
        /// Enum QUARTERLY for value: QUARTERLY
        /// </summary>
        [EnumMember(Value = "QUARTERLY")]
        QUARTERLY = 4,

        /// <summary>
        /// Enum TWICEMONTHLY for value: TWICEMONTHLY
        /// </summary>
        [EnumMember(Value = "TWICEMONTHLY")]
        TWICEMONTHLY = 5,

        /// <summary>
        /// Enum FOURWEEKLY for value: FOURWEEKLY
        /// </summary>
        [EnumMember(Value = "FOURWEEKLY")]
        FOURWEEKLY = 6,

        /// <summary>
        /// Enum YEARLY for value: YEARLY
        /// </summary>
        [EnumMember(Value = "YEARLY")]
        YEARLY = 7

    }

}

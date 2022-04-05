/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
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
    /// Defines AllowanceType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum AllowanceType
    {
        /// <summary>
        /// Enum CAR for value: CAR
        /// </summary>
        [EnumMember(Value = "CAR")]
        CAR = 1,

        /// <summary>
        /// Enum TRANSPORT for value: TRANSPORT
        /// </summary>
        [EnumMember(Value = "TRANSPORT")]
        TRANSPORT = 2,

        /// <summary>
        /// Enum LAUNDRY for value: LAUNDRY
        /// </summary>
        [EnumMember(Value = "LAUNDRY")]
        LAUNDRY = 3,

        /// <summary>
        /// Enum MEALS for value: MEALS
        /// </summary>
        [EnumMember(Value = "MEALS")]
        MEALS = 4,

        /// <summary>
        /// Enum TRAVEL for value: TRAVEL
        /// </summary>
        [EnumMember(Value = "TRAVEL")]
        TRAVEL = 5,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 6,

        /// <summary>
        /// Enum JOBKEEPER for value: JOBKEEPER
        /// </summary>
        [EnumMember(Value = "JOBKEEPER")]
        JOBKEEPER = 7,

        /// <summary>
        /// Enum TOOLS for value: TOOLS
        /// </summary>
        [EnumMember(Value = "TOOLS")]
        TOOLS = 8,

        /// <summary>
        /// Enum TASKS for value: TASKS
        /// </summary>
        [EnumMember(Value = "TASKS")]
        TASKS = 9,

        /// <summary>
        /// Enum QUALIFICATIONS for value: QUALIFICATIONS
        /// </summary>
        [EnumMember(Value = "QUALIFICATIONS")]
        QUALIFICATIONS = 10

    }

}

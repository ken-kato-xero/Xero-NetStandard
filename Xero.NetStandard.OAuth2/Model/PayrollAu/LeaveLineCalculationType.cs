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
    /// Calculation type for leave line for Opening Balance on Employee
    /// </summary>
    /// <value>Calculation type for leave line for Opening Balance on Employee</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum LeaveLineCalculationType
    {
        /// <summary>
        /// Enum NOCALCULATIONREQUIRED for value: NOCALCULATIONREQUIRED
        /// </summary>
        [EnumMember(Value = "NOCALCULATIONREQUIRED")]
        NOCALCULATIONREQUIRED = 1,

        /// <summary>
        /// Enum FIXEDAMOUNTEACHPERIOD for value: FIXEDAMOUNTEACHPERIOD
        /// </summary>
        [EnumMember(Value = "FIXEDAMOUNTEACHPERIOD")]
        FIXEDAMOUNTEACHPERIOD = 2,

        /// <summary>
        /// Enum ENTERRATEINPAYTEMPLATE for value: ENTERRATEINPAYTEMPLATE
        /// </summary>
        [EnumMember(Value = "ENTERRATEINPAYTEMPLATE")]
        ENTERRATEINPAYTEMPLATE = 3,

        /// <summary>
        /// Enum BASEDONORDINARYEARNINGS for value: BASEDONORDINARYEARNINGS
        /// </summary>
        [EnumMember(Value = "BASEDONORDINARYEARNINGS")]
        BASEDONORDINARYEARNINGS = 4,

        /// <summary>
        /// Enum Empty for value: 
        /// </summary>
        [EnumMember(Value = "")]
        Empty = 5

    }

}

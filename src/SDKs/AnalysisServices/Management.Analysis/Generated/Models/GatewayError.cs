// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Detail of gateway errors.
    /// </summary>
    public partial class GatewayError
    {
        /// <summary>
        /// Initializes a new instance of the GatewayError class.
        /// </summary>
        public GatewayError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayError class.
        /// </summary>
        /// <param name="code">Error code of list gateway.</param>
        /// <param name="message">Error message of list gateway.</param>
        public GatewayError(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code of list gateway.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message of list gateway.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}

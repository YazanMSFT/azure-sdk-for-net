// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.AnomalyDetector.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error information returned by the API.
    /// </summary>
    public partial class APIError
    {
        /// <summary>
        /// Initializes a new instance of the APIError class.
        /// </summary>
        public APIError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the APIError class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">A message explaining the error reported by
        /// the service.</param>
        public APIError(object code = default(object), string message = default(string))
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
        /// Gets or sets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public object Code { get; set; }

        /// <summary>
        /// Gets or sets a message explaining the error reported by the
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}

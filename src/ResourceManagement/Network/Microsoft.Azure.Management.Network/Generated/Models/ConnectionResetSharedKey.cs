// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class ConnectionResetSharedKey
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionResetSharedKey class.
        /// </summary>
        public ConnectionResetSharedKey() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionResetSharedKey class.
        /// </summary>
        public ConnectionResetSharedKey(int keyLength)
        {
            KeyLength = keyLength;
        }

        /// <summary>
        /// The virtual network connection reset shared key length, should
        /// between 1 and 128.
        /// </summary>
        [JsonProperty(PropertyName = "keyLength")]
        public int KeyLength { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.KeyLength > 128)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "KeyLength", 128);
            }
            if (this.KeyLength < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "KeyLength", 1);
            }
        }
    }
}
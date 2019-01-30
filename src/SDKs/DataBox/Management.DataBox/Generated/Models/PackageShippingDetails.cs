// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Shipping details.
    /// </summary>
    public partial class PackageShippingDetails
    {
        /// <summary>
        /// Initializes a new instance of the PackageShippingDetails class.
        /// </summary>
        public PackageShippingDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PackageShippingDetails class.
        /// </summary>
        /// <param name="carrierName">Name of the carrier.</param>
        /// <param name="trackingId">Tracking Id of shipment.</param>
        /// <param name="trackingUrl">Url where shipment can be
        /// tracked.</param>
        public PackageShippingDetails(string carrierName = default(string), string trackingId = default(string), string trackingUrl = default(string))
        {
            CarrierName = carrierName;
            TrackingId = trackingId;
            TrackingUrl = trackingUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the carrier.
        /// </summary>
        [JsonProperty(PropertyName = "carrierName")]
        public string CarrierName { get; private set; }

        /// <summary>
        /// Gets tracking Id of shipment.
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string TrackingId { get; private set; }

        /// <summary>
        /// Gets url where shipment can be tracked.
        /// </summary>
        [JsonProperty(PropertyName = "trackingUrl")]
        public string TrackingUrl { get; private set; }

    }
}
// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the Event Subscription update
    /// </summary>
    public partial class EventSubscriptionUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the EventSubscriptionUpdateParameters
        /// class.
        /// </summary>
        public EventSubscriptionUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSubscriptionUpdateParameters
        /// class.
        /// </summary>
        /// <param name="destination">Information about the destination where
        /// events have to be delivered for the event subscription.</param>
        /// <param name="filter">Information about the filter for the event
        /// subscription.</param>
        /// <param name="labels">List of user defined labels.</param>
        /// <param name="retryPolicy">The retry policy for events. This can be
        /// used to configure maximum number of delivery attempts and time to
        /// live for events.</param>
        /// <param name="deadLetterDestination">The DeadLetter destination of
        /// the event subscription.</param>
        public EventSubscriptionUpdateParameters(EventSubscriptionDestination destination = default(EventSubscriptionDestination), EventSubscriptionFilter filter = default(EventSubscriptionFilter), IList<string> labels = default(IList<string>), RetryPolicy retryPolicy = default(RetryPolicy), DeadLetterDestination deadLetterDestination = default(DeadLetterDestination))
        {
            Destination = destination;
            Filter = filter;
            Labels = labels;
            RetryPolicy = retryPolicy;
            DeadLetterDestination = deadLetterDestination;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about the destination where events have to
        /// be delivered for the event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public EventSubscriptionDestination Destination { get; set; }

        /// <summary>
        /// Gets or sets information about the filter for the event
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public EventSubscriptionFilter Filter { get; set; }

        /// <summary>
        /// Gets or sets list of user defined labels.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// Gets or sets the retry policy for events. This can be used to
        /// configure maximum number of delivery attempts and time to live for
        /// events.
        /// </summary>
        [JsonProperty(PropertyName = "retryPolicy")]
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Gets or sets the DeadLetter destination of the event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "deadLetterDestination")]
        public DeadLetterDestination DeadLetterDestination { get; set; }

    }
}
// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cluster monitoring extensions
    /// </summary>
    public partial class Extension
    {
        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        public Extension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        /// <param name="workspaceId">The workspace ID for the cluster
        /// monitoring extension.</param>
        /// <param name="primaryKey">The certificate for the cluster monitoring
        /// extensions.</param>
        public Extension(string workspaceId = default(string), string primaryKey = default(string))
        {
            WorkspaceId = workspaceId;
            PrimaryKey = primaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workspace ID for the cluster monitoring extension.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets the certificate for the cluster monitoring extensions.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

    }
}
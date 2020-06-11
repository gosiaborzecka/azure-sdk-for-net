// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> SKU parameters particular to a cluster instance. </summary>
    public partial class ClusterSku
    {
        /// <summary> Initializes a new instance of ClusterSku. </summary>
        public ClusterSku()
        {
            Name = "Dedicated";
        }

        /// <summary> Initializes a new instance of ClusterSku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="capacity"> The quantity of Event Hubs Cluster Capacity Units contained in this cluster. </param>
        internal ClusterSku(string name, int? capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        /// <summary> Name of this SKU. </summary>
        public string Name { get; set; }
        /// <summary> The quantity of Event Hubs Cluster Capacity Units contained in this cluster. </summary>
        public int? Capacity { get; set; }
    }
}

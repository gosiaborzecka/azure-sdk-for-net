// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Azure;
    using Management;
    using Network;
    using Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AddressSpace contains an array of IP address ranges that can be used by
    /// subnets of the virtual network.
    /// </summary>
    public partial class AddressSpace
    {
        /// <summary>
        /// Initializes a new instance of the AddressSpace class.
        /// </summary>
        public AddressSpace() { }

        /// <summary>
        /// Initializes a new instance of the AddressSpace class.
        /// </summary>
        /// <param name="addressPrefixes">A list of address blocks reserved for
        /// this virtual network in CIDR notation.</param>
        public AddressSpace(IList<string> addressPrefixes = default(IList<string>))
        {
            AddressPrefixes = addressPrefixes;
        }

        /// <summary>
        /// Gets or sets a list of address blocks reserved for this virtual
        /// network in CIDR notation.
        /// </summary>
        [JsonProperty(PropertyName = "addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

    }
}


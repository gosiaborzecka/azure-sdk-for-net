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
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VPN client root certificate of virtual network gateway
    /// </summary>
    [JsonTransformation]
    public partial class VpnClientRootCertificateInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientRootCertificateInner
        /// class.
        /// </summary>
        public VpnClientRootCertificateInner() { }

        /// <summary>
        /// Initializes a new instance of the VpnClientRootCertificateInner
        /// class.
        /// </summary>
        /// <param name="publicCertData">The certificate public data.</param>
        /// <param name="provisioningState">The provisioning state of the VPN
        /// client root certificate resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VpnClientRootCertificateInner(string publicCertData, string id = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PublicCertData = publicCertData;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the certificate public data.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicCertData")]
        public string PublicCertData { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VPN client root certificate
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublicCertData == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicCertData");
            }
        }
    }
}


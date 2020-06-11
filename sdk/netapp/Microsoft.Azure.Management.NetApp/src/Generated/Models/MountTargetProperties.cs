// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Mount target properties
    /// </summary>
    public partial class MountTargetProperties
    {
        /// <summary>
        /// Initializes a new instance of the MountTargetProperties class.
        /// </summary>
        public MountTargetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MountTargetProperties class.
        /// </summary>
        /// <param name="fileSystemId">fileSystemId</param>
        /// <param name="mountTargetId">mountTargetId</param>
        /// <param name="ipAddress">ipAddress</param>
        /// <param name="subnet">subnet</param>
        /// <param name="startIp">startIp</param>
        /// <param name="endIp">endIp</param>
        /// <param name="gateway">gateway</param>
        /// <param name="netmask">netmask</param>
        /// <param name="smbServerFqdn">smbServerFQDN</param>
        public MountTargetProperties(string fileSystemId, string mountTargetId = default(string), string ipAddress = default(string), string subnet = default(string), string startIp = default(string), string endIp = default(string), string gateway = default(string), string netmask = default(string), string smbServerFqdn = default(string))
        {
            MountTargetId = mountTargetId;
            FileSystemId = fileSystemId;
            IpAddress = ipAddress;
            Subnet = subnet;
            StartIp = startIp;
            EndIp = endIp;
            Gateway = gateway;
            Netmask = netmask;
            SmbServerFqdn = smbServerFqdn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets mountTargetId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the MountTarget
        /// </remarks>
        [JsonProperty(PropertyName = "mountTargetId")]
        public string MountTargetId { get; private set; }

        /// <summary>
        /// Gets or sets fileSystemId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the MountTarget
        /// </remarks>
        [JsonProperty(PropertyName = "fileSystemId")]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Gets ipAddress
        /// </summary>
        /// <remarks>
        /// The mount target's IPv4 address
        /// </remarks>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; private set; }

        /// <summary>
        /// Gets or sets subnet
        /// </summary>
        /// <remarks>
        /// The subnet
        /// </remarks>
        [JsonProperty(PropertyName = "subnet")]
        public string Subnet { get; set; }

        /// <summary>
        /// Gets or sets startIp
        /// </summary>
        /// <remarks>
        /// The start of IPv4 address range to use when creating a new mount
        /// target
        /// </remarks>
        [JsonProperty(PropertyName = "startIp")]
        public string StartIp { get; set; }

        /// <summary>
        /// Gets or sets endIp
        /// </summary>
        /// <remarks>
        /// The end of IPv4 address range to use when creating a new mount
        /// target
        /// </remarks>
        [JsonProperty(PropertyName = "endIp")]
        public string EndIp { get; set; }

        /// <summary>
        /// Gets or sets gateway
        /// </summary>
        /// <remarks>
        /// The gateway of the IPv4 address range to use when creating a new
        /// mount target
        /// </remarks>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Gets or sets netmask
        /// </summary>
        /// <remarks>
        /// The netmask of the IPv4 address range to use when creating a new
        /// mount target
        /// </remarks>
        [JsonProperty(PropertyName = "netmask")]
        public string Netmask { get; set; }

        /// <summary>
        /// Gets or sets smbServerFQDN
        /// </summary>
        /// <remarks>
        /// The SMB server's Fully Qualified Domain Name, FQDN
        /// </remarks>
        [JsonProperty(PropertyName = "smbServerFqdn")]
        public string SmbServerFqdn { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileSystemId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileSystemId");
            }
            if (MountTargetId != null)
            {
                if (MountTargetId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "MountTargetId", 36);
                }
                if (MountTargetId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "MountTargetId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(MountTargetId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "MountTargetId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (FileSystemId != null)
            {
                if (FileSystemId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FileSystemId", 36);
                }
                if (FileSystemId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FileSystemId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(FileSystemId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FileSystemId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
        }
    }
}

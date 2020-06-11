﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// An Azure Storage blob.
    /// </summary>
    public class BlobItem
    {
        internal BlobItem() { }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Deleted.
        /// </summary>
        public bool Deleted { get; internal set; }

        /// <summary>
        /// Snapshot.
        /// </summary>
        public string Snapshot { get; internal set; }

        /// <summary>
        /// VersionId.
        /// </summary>
        public string VersionId { get; internal set; }

        /// <summary>
        /// IsCurrentVersion.
        /// </summary>
        public bool? IsCurrentVersion { get; internal set; }

        /// <summary>
        /// Properties of a blob.
        /// </summary>
        public BlobItemProperties Properties { get; internal set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        public IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// Tags.
        /// </summary>
        public IDictionary<string, string> Tags { get; internal set; }
    }
}

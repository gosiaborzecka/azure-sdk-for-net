// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Gallery Image version operation response. </summary>
    public partial class GalleryImageVersionList
    {
        /// <summary> Initializes a new instance of GalleryImageVersionList. </summary>
        /// <param name="value"> A list of gallery Image Versions. </param>
        internal GalleryImageVersionList(IEnumerable<GalleryImageVersion> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of GalleryImageVersionList. </summary>
        /// <param name="value"> A list of gallery Image Versions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of gallery Image Versions. Call ListNext() with this to fetch the next page of gallery Image Versions. </param>
        internal GalleryImageVersionList(IReadOnlyList<GalleryImageVersion> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of gallery Image Versions. </summary>
        public IReadOnlyList<GalleryImageVersion> Value { get; }
        /// <summary> The uri to fetch the next page of gallery Image Versions. Call ListNext() with this to fetch the next page of gallery Image Versions. </summary>
        public string NextLink { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    internal partial class GalleryImageVersionsRestClient
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of GalleryImageVersionsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public GalleryImageVersionsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(galleryImageVersion);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be created. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the create or update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be created. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the create or update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(galleryImageVersion);
            request.Content = content;
            return message;
        }

        /// <summary> Update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be updated. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> UpdateAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var message = CreateUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be updated. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Update(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var message = CreateUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("$expand", "ReplicationStatus", true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Retrieves information about a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryImageVersion>> GetAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateGetRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryImageVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = GalleryImageVersion.DeserializeGalleryImageVersion(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information about a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryImageVersion> Get(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateGetRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryImageVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = GalleryImageVersion.DeserializeGalleryImageVersion(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByGalleryImageRequest(string resourceGroupName, string galleryName, string galleryImageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List gallery Image Versions in a gallery Image Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the Shared Image Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryImageVersionList>> ListByGalleryImageAsync(string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListByGalleryImageRequest(resourceGroupName, galleryName, galleryImageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryImageVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = GalleryImageVersionList.DeserializeGalleryImageVersionList(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List gallery Image Versions in a gallery Image Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the Shared Image Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryImageVersionList> ListByGalleryImage(string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListByGalleryImageRequest(resourceGroupName, galleryName, galleryImageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryImageVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = GalleryImageVersionList.DeserializeGalleryImageVersionList(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByGalleryImageNextPageRequest(string nextLink, string resourceGroupName, string galleryName, string galleryImageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> List gallery Image Versions in a gallery Image Definition. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the Shared Image Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryImageVersionList>> ListByGalleryImageNextPageAsync(string nextLink, string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListByGalleryImageNextPageRequest(nextLink, resourceGroupName, galleryName, galleryImageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryImageVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = GalleryImageVersionList.DeserializeGalleryImageVersionList(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List gallery Image Versions in a gallery Image Definition. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the Shared Image Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryImageVersionList> ListByGalleryImageNextPage(string nextLink, string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            using var message = CreateListByGalleryImageNextPageRequest(nextLink, resourceGroupName, galleryName, galleryImageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryImageVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = GalleryImageVersionList.DeserializeGalleryImageVersionList(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

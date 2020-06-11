// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The ExpressRouteCircuitConnections service client. </summary>
    public partial class ExpressRouteCircuitConnectionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExpressRouteCircuitConnectionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionsClient for mocking. </summary>
        protected ExpressRouteCircuitConnectionsClient()
        {
        }
        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ExpressRouteCircuitConnectionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ExpressRouteCircuitConnectionsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuitConnection>> GetAsync(string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, circuitName, peeringName, connectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitConnection> Get(string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, circuitName, peeringName, connectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all global reach connections associated with a private peering in an express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRouteCircuitConnection> ListAsync(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            async Task<Page<ExpressRouteCircuitConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, circuitName, peeringName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCircuitConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, circuitName, peeringName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all global reach connections associated with a private peering in an express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRouteCircuitConnection> List(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            Page<ExpressRouteCircuitConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, circuitName, peeringName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCircuitConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, circuitName, peeringName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCircuitConnectionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, circuitName, peeringName, connectionName, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCircuitConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, circuitName, peeringName, connectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCircuitConnectionsDeleteOperation StartDelete(string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, circuitName, peeringName, connectionName, cancellationToken);
                return new ExpressRouteCircuitConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, circuitName, peeringName, connectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Express Route Circuit Connection in the specified express route circuits. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="expressRouteCircuitConnectionParameters"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ExpressRouteCircuitConnectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnection expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (expressRouteCircuitConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCircuitConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Express Route Circuit Connection in the specified express route circuits. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="connectionName"> The name of the express route circuit connection. </param>
        /// <param name="expressRouteCircuitConnectionParameters"> Parameters supplied to the create or update express route circuit connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCircuitConnectionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnection expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (expressRouteCircuitConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitConnectionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters, cancellationToken);
                return new ExpressRouteCircuitConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

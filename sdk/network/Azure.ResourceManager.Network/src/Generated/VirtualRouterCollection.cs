// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualRouter and their operations over its parent. </summary>
    public partial class VirtualRouterCollection : ArmCollection, IEnumerable<VirtualRouter>, IAsyncEnumerable<VirtualRouter>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualRoutersRestOperations _virtualRoutersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterCollection"/> class for mocking. </summary>
        protected VirtualRouterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualRouterCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualRouter.ResourceType, out string apiVersion);
            _virtualRoutersRestClient = new VirtualRoutersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates the specified Virtual Router. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualRouterCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualRouterName, VirtualRouterData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualRoutersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, parameters, cancellationToken);
                var operation = new VirtualRouterCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualRoutersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Virtual Router. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualRouterCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualRouterName, VirtualRouterData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualRoutersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualRouterCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualRoutersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Virtual Router. </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual Response<VirtualRouter> Get(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualRoutersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Virtual Router. </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public async virtual Task<Response<VirtualRouter>> GetAsync(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualRoutersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualRouter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual Response<VirtualRouter> GetIfExists(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualRoutersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualRouter>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualRouter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public async virtual Task<Response<VirtualRouter>> GetIfExistsAsync(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualRoutersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualRouterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualRouter>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualRouter(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualRouterName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualRouterName"> The name of the Virtual Router. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualRouterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualRouterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualRouterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualRouterName, nameof(virtualRouterName));

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualRouterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Virtual Routers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualRouter" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualRouter> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualRouter> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualRoutersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouter(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualRouter> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualRoutersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouter(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Virtual Routers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualRouter" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualRouter> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualRouter>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualRoutersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouter(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualRouter>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualRoutersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouter(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualRouter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualRouter.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualRouter" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualRouter.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualRouter> IEnumerable<VirtualRouter>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualRouter> IAsyncEnumerable<VirtualRouter>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualRouter, VirtualRouterData> Construct() { }
    }
}

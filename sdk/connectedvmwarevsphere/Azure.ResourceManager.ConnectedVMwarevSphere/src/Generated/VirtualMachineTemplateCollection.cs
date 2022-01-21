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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VirtualMachineTemplate and their operations over its parent. </summary>
    public partial class VirtualMachineTemplateCollection : ArmCollection, IEnumerable<VirtualMachineTemplate>, IAsyncEnumerable<VirtualMachineTemplate>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineTemplatesRestOperations _virtualMachineTemplatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineTemplateCollection"/> class for mocking. </summary>
        protected VirtualMachineTemplateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineTemplateCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineTemplateCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualMachineTemplate.ResourceType, out string apiVersion);
            _virtualMachineTemplatesRestClient = new VirtualMachineTemplatesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineTemplates_Create
        /// <summary> Create Or Update virtual machine template. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual VirtualMachineTemplateCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualMachineTemplateName, VirtualMachineTemplateData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineTemplatesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, body, cancellationToken);
                var operation = new VirtualMachineTemplateCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualMachineTemplatesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineTemplates_Create
        /// <summary> Create Or Update virtual machine template. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public async virtual Task<VirtualMachineTemplateCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualMachineTemplateName, VirtualMachineTemplateData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineTemplatesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, body, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualMachineTemplateCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualMachineTemplatesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineTemplates_Get
        /// <summary> Implements virtual machine template GET method. </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<VirtualMachineTemplate> Get(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineTemplate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineTemplates_Get
        /// <summary> Implements virtual machine template GET method. </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineTemplate>> GetAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineTemplate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<VirtualMachineTemplate> GetIfExists(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineTemplate>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineTemplate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineTemplate>> GetIfExistsAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineTemplate>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineTemplate(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualMachineTemplateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualMachineTemplateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineTemplates_ListByResourceGroup
        /// <summary> List of virtualMachineTemplates in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineTemplate" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineTemplate> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineTemplate> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineTemplatesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineTemplate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineTemplate> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineTemplatesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineTemplate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VirtualMachineTemplates_ListByResourceGroup
        /// <summary> List of virtualMachineTemplates in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineTemplate" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineTemplate> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineTemplate>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineTemplatesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineTemplate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineTemplate>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineTemplatesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineTemplate(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualMachineTemplate" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineTemplate.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineTemplate" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineTemplateCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineTemplate.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineTemplate> IEnumerable<VirtualMachineTemplate>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineTemplate> IAsyncEnumerable<VirtualMachineTemplate>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualMachineTemplate, VirtualMachineTemplateData> Construct() { }
    }
}

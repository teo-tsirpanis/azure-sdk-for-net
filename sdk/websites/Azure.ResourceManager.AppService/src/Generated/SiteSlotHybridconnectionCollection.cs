// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of RelayServiceConnectionEntity and their operations over its parent. </summary>
    public partial class SiteSlotHybridconnectionCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnectionCollection"/> class for mocking. </summary>
        protected SiteSlotHybridconnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridconnectionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotHybridconnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteSlotHybridconnection.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateRelayServiceConnectionSlot
        /// <summary> Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="connectionEnvelope"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual SiteSlotHybridconnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string entityName, RelayServiceConnectionEntityData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, connectionEnvelope, cancellationToken);
                var operation = new SiteSlotHybridconnectionCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_CreateOrUpdateRelayServiceConnectionSlot
        /// <summary> Description for Creates a new hybrid connection configuration (PUT), or updates an existing one (PATCH). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="entityName"> Name of the hybrid connection configuration. </param>
        /// <param name="connectionEnvelope"> Details of the hybrid connection configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<SiteSlotHybridconnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string entityName, RelayServiceConnectionEntityData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotHybridconnectionCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetRelayServiceConnectionSlot
        /// <summary> Description for Gets a hybrid connection configuration by its name. </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<SiteSlotHybridconnection> Get(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridconnection/{entityName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetRelayServiceConnectionSlot
        /// <summary> Description for Gets a hybrid connection configuration by its name. </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridconnection>> GetAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<SiteSlotHybridconnection> GetIfExists(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetRelayServiceConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHybridconnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotHybridconnection>> GetIfExistsAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetRelayServiceConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, entityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHybridconnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridconnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public virtual Response<bool> Exists(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(entityName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="entityName"> Name of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="entityName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="entityName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string entityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(entityName, nameof(entityName));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotHybridconnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(entityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteSlotHybridconnection, RelayServiceConnectionEntityData> Construct() { }
    }
}

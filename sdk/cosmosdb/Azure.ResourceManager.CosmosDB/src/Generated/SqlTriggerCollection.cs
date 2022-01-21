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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of SqlTrigger and their operations over its parent. </summary>
    public partial class SqlTriggerCollection : ArmCollection, IEnumerable<SqlTrigger>, IAsyncEnumerable<SqlTrigger>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlTriggerCollection"/> class for mocking. </summary>
        protected SqlTriggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlTriggerCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlTriggerCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SqlTrigger.ResourceType, out string apiVersion);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlContainer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlContainer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB SQL trigger. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="createUpdateSqlTriggerParameters"> The parameters to provide for the current SQL trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="createUpdateSqlTriggerParameters"/> is null. </exception>
        public virtual SqlTriggerCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string triggerName, SqlTriggerCreateUpdateOptions createUpdateSqlTriggerParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            if (createUpdateSqlTriggerParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlTriggerParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.CreateUpdateSqlTrigger(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, createUpdateSqlTriggerParameters, cancellationToken);
                var operation = new SqlTriggerCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlTriggerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, createUpdateSqlTriggerParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB SQL trigger. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="createUpdateSqlTriggerParameters"> The parameters to provide for the current SQL trigger. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="createUpdateSqlTriggerParameters"/> is null. </exception>
        public async virtual Task<SqlTriggerCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string triggerName, SqlTriggerCreateUpdateOptions createUpdateSqlTriggerParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            if (createUpdateSqlTriggerParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlTriggerParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.CreateUpdateSqlTriggerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, createUpdateSqlTriggerParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlTriggerCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlTriggerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, createUpdateSqlTriggerParameters).Request, response);
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

        /// <summary> Gets the SQL trigger under an existing Azure Cosmos DB database account. </summary>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<SqlTrigger> Get(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlTrigger(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTrigger(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL trigger under an existing Azure Cosmos DB database account. </summary>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public async virtual Task<Response<SqlTrigger>> GetAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlTriggerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlTrigger(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<SqlTrigger> GetIfExists(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlTrigger(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlTrigger>(null, response.GetRawResponse());
                return Response.FromValue(new SqlTrigger(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public async virtual Task<Response<SqlTrigger>> GetIfExistsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlTriggerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, triggerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlTrigger>(null, response.GetRawResponse());
                return Response.FromValue(new SqlTrigger(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<bool> Exists(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(triggerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="triggerName"> Cosmos DB trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(triggerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL trigger under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlTrigger" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlTrigger> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlTrigger> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlResourcesRestClient.ListSqlTriggers(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTrigger(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL trigger under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlTrigger" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlTrigger> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlTrigger>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlTriggerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlResourcesRestClient.ListSqlTriggersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTrigger(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<SqlTrigger> IEnumerable<SqlTrigger>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlTrigger> IAsyncEnumerable<SqlTrigger>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SqlTrigger, SqlTriggerData> Construct() { }
    }
}

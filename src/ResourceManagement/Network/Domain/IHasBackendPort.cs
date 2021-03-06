// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    /// <summary>
    /// An interface representing a model's ability to reference a backend port.
    /// </summary>
    public interface IHasBackendPort
    {
        /// <summary>
        /// Gets the backend port number the network traffic is sent to.
        /// </summary>
        int BackendPort { get; }
    }
}
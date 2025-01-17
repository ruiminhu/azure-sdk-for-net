// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list VirtualHubs. It contains a list of VirtualHubs and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVirtualHubsResult
    {
        /// <summary> Initializes a new instance of ListVirtualHubsResult. </summary>
        internal ListVirtualHubsResult()
        {
            Value = new ChangeTrackingList<VirtualHub>();
        }

        /// <summary> Initializes a new instance of ListVirtualHubsResult. </summary>
        /// <param name="value"> List of VirtualHubs. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVirtualHubsResult(IReadOnlyList<VirtualHub> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of VirtualHubs. </summary>
        public IReadOnlyList<VirtualHub> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}

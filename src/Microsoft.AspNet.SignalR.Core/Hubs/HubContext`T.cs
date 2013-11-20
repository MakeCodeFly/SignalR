﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

namespace Microsoft.AspNet.SignalR.Hubs
{
    class HubContext<T> : IHubContext<T>
    {
        public HubContext(IHubContext<dynamic> dynamicContext)
        {
            Clients = new TypedHubConnectionContext<T>(dynamicContext.Clients);
            Groups = dynamicContext.Groups;
        }

        public IHubConnectionContext<T> Clients { get; private set; }

        public IGroupManager Groups { get; private set; }
    }
}

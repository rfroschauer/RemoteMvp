﻿using System.Net.Sockets;

namespace RemoteMvpLib
{
    public interface IActionEndpoint
    {
        event EventHandler<RemoteActionRequest> OnActionPerformed;
        void RunActionEndpoint();
        void PerformActionResponse(Socket handler, RemoteActionResponse response);
    }
}
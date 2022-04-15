using GayHub.Services.ApiConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace GayHub.Services
{
    public class GayHubServiceBase
    {
        public readonly GayhubClient Api;

        public GayHubServiceBase(GayhubClient client)
        {
            this.Api = client;
        }
    }
}

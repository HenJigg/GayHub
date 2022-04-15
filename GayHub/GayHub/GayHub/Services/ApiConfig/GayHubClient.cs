using Octokit;
using Octokit.GraphQL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GayHub.Services.ApiConfig
{
    public class GayhubClient
    {
        public GayhubClient()
        {
            Client = new GitHubClient(new Octokit.ProductHeaderValue(GayHubConfig.Name));
            Client.Credentials = new Credentials(GayHubConfig.Token);
        }

        public GitHubClient Client;
    }
}

using AutoMapper;
using GayHub.Models;
using GayHub.Models.User;
using GayHub.Services.ApiConfig;
using Octokit.GraphQL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GayHub.Services.User
{
    public class UserService : GayHubServiceBase, IUserService
    {
        private readonly IMapper mapper;

        public UserService(GayhubClient client, IMapper mapper) : base(client)
        {
            this.mapper = mapper;
        }

        public async Task<IReadOnlyList<UserModel>> GetAllFollowersAsync()
        {
            var result = await Api.Client.User.Followers.GetAllForCurrent();
            return mapper.Map<List<UserModel>>(result);
        }

        public async Task<IReadOnlyList<Notification>> GetAllNotificationsAsync()
        {
            var result = await Api.Client.Activity.Notifications.GetAllForCurrent();
            return mapper.Map<List<Notification>>(result);
        }

        public async Task<OrganizationModel> GetAllOrganizationAsync()
        {
            var result = await Api.Client.Organization.GetAllForCurrent();
            return mapper.Map<OrganizationModel>(result);
        }

        public async Task<RepositoryModel> GetAllRepositoryAsync()
        {
            var result = await Api.Client.Repository.GetAllForCurrent();

            return mapper.Map<RepositoryModel>(result);
        }

        public async Task<IReadOnlyList<RepositoryModel>> GetAllStarringAsync()
        {
            var result = await Api.Client.Activity.Starring.GetAllForCurrent();
            return mapper.Map<List<RepositoryModel>>(result);
        }

        public async Task<IReadOnlyList<RepositoryModel>> GetAllWatchingAsync()
        {
            var result = await Api.Client.Activity.Watching.GetAllForCurrent();
            return mapper.Map<List<RepositoryModel>>(result);
        }

        public async Task<UserModel> GetUserByNameAsync(string name)
        {
            var result = await Api.Client.User.Get(name);
            return mapper.Map<UserModel>(result);
        }

        public async Task<UserModel> GetUserInfoAsync()
        {
            var result = await Api.Client.User.Current();
            return mapper.Map<UserModel>(result);
        }

        public async Task<string> GetUserName()
        {
            var user = await Api.Client.User.Current();
            return user.Name;
        }
    }
}

using GayHub.Models;
using GayHub.Models.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GayHub.Services.User
{
    /// <summary>
    /// GitHub 用户接口
    /// 说明: 访问授权用户的个人账号相关信息。不限于:用户信息、仓库、组织、项目、提交等信息...
    /// </summary>
    public interface IUserService
    {
        //获取当前用户名称
        Task<string> GetUserName();

        //获取授权用户资料
        Task<UserModel> GetUserInfoAsync();

        //根据名称获取指定用户的资料
        Task<UserModel> GetUserByNameAsync(string name);

        //获取所有仓库列表
        Task<RepositoryModel> GetAllRepositoryAsync();

        //获取所有组织
        Task<OrganizationModel> GetAllOrganizationAsync();

        //获取所有关注用户
        Task<IReadOnlyList<UserModel>> GetAllFollowersAsync();

        //获取所有点赞项目列表
        Task<IReadOnlyList<RepositoryModel>> GetAllStarringAsync();

        //获取所有订阅项目列表
        Task<IReadOnlyList<RepositoryModel>> GetAllWatchingAsync();

        //获取所有通知信息
        Task<IReadOnlyList<Notification>> GetAllNotificationsAsync();
    }
}

using AutoMapper;
using GayHub.Models.User;
using Octokit;
using System;
using System.Collections.Generic;
using System.Text;

namespace GayHub
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<UserModel, User>().ReverseMap();
        }
    }
}

using GayHub.Services.User;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace GayHub.ViewModels
{
    internal class IndexViewModel
    {
        private readonly IUserService userService;

        public DelegateCommand TestCommand { get; set; }

        public IndexViewModel(IUserService userService)
        {
            TestCommand = new DelegateCommand(GetAll);
            this.userService = userService;
        }

        private async void GetAll()
        {
            await userService.GetAllFollowersAsync();
        }
    }
}

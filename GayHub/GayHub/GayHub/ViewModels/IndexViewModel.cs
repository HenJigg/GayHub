using GayHub.Models.User;
using GayHub.Services.User;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace GayHub.ViewModels
{
    internal class IndexViewModel : BindableBase
    {
        private readonly IUserService userService;

        public DelegateCommand TestCommand { get; set; }

        public IndexViewModel(IUserService userService)
        {
            TestCommand = new DelegateCommand(GetAll);
            this.userService = userService;
        }

        private UserModel user;

        public UserModel User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged(); }
        }

        private async void GetAll()
        {
            User = await userService.GetUserInfoAsync();
        }
    }
}

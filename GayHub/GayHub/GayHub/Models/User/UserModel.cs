using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace GayHub.Models.User
{
    public class UserModel : BindableBase
    {
        public string AvatarUrl { get; set; }
        public string Bio { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class UserService
    {
        private UserRespository repos;
        public UserService()
        {
            repos = new UserRespository();
        }

        public string FindUser(string username, string pass)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                return "Không được để trống";
            }
            if (repos.UserFound(username, pass))
            {
                return "Đăng Nhập Thành Công";
            }
            return "Đăng nhập thất bại";
        }
    }
}

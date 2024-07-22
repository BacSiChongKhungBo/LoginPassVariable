using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Context;

namespace WinFormsApp2
{
    internal class UserRespository
    {
        private DBContext dbContext;
        public UserRespository()
        {
            dbContext = new DBContext();
        }

        //Khi dang nhap =>
        //1. tìm xem user có tồn tại hay ko
        //2. đúng cả username và password hay ko
        public bool UserFound(string username, string pass)
        {
            //kiểm tra
            if(dbContext.Myusers.Any(x => x.Username.Equals(username) && x.Matkhau.Equals(pass)))
            {
                return true;
            }
            return false;
        }
    }
}

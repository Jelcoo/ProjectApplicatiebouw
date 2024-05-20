using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class LoginService
    {
        private LoginDao _loginDao;

        public LoginService()
        {
            _loginDao = new LoginDao();
        }

        public bool ValidLogin(int userId, string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            Employee user = _loginDao.GetLogin(userId, password);

            if (user != null && user.CheckPassword(password))
            {
                return true;
            }

            return false;
        }
    }
}

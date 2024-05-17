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
                throw new ArgumentNullException(nameof(password), "Password cannot be null or empty.");
            }

            Login user = _loginDao.GetLogin(userId, password);

            if (user != null)
            {
                if (user.Id == userId && user.Password == password)
                {
                    return true; 
                }
            }

            return false; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ChapeauModel
{
    public class Login
    {
        public int Id { get; set; }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = HashPassword(value); }
        }

        public Login(int id, string password)
        {
            Id = id;
            Password = password;
        }

        public Login()
        {
            _password = HashPassword(Password);
        }

        
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }



}

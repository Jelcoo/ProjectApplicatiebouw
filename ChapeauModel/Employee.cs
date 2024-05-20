using System.Text;
using System.Security.Cryptography;

namespace ChapeauModel
{
    public class Employee
    {
        private int _employeeId;
        public int EmployeeId { get { return _employeeId; } }

        private string _name;
        public string Name { get { return _name; } }

        private string _password;

        private DateTime _employedAt;
        public DateTime EmployedAt { get { return _employedAt; } }

        private int _roleId;
        public int RoleId { get { return _roleId; } }
        public Role? Role;

        public Employee(string name, string password, DateTime employedAt, int roleId)
        {
            _name = name;
            _password = password;
            _employedAt = employedAt;
            _roleId = roleId;
        }

        public Employee(int employeeId, string name, string password, DateTime employedAt, int roleId)
            : this(name, password, employedAt, roleId)
        {
            _employeeId = employeeId;
        }
        public Employee SetRole(Role role)
        {
            Role = role;
            return this;
        }


        public bool CheckPassword(string password)
        {
            string hash = HashPassword(password);
            return _password == hash;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}

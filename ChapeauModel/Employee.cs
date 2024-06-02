using ChapeauModel.Enums;

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

        public ERole Role { get; private set; }

        public Employee(string name, string password, DateTime employedAt, ERole role)
        {
            _name = name;
            _password = password;
            _employedAt = employedAt;
            Role = role;
        }

        public Employee(int employeeId, string name, string password, DateTime employedAt, ERole role)
            : this(name, password, employedAt, role)
        {
            _employeeId = employeeId;
        }

        public void SetRole(ERole role)
        {
            Role = role;
        }
    }
}

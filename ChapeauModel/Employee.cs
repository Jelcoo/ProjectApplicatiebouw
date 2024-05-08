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

        public Role Role;
    }
}

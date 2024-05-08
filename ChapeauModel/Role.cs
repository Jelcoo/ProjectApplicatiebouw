namespace ChapeauModel
{
    public class Role
    {
        private int _roleId;
        public int RoleId { get { return _roleId; } }

        private string _name;
        public string Name { get { return _name; } }

        public Role(int roleId, string name)
        {
            _roleId = roleId;
            _name = name;
        }
    }
}

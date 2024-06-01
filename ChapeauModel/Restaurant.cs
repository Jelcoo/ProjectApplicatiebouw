namespace ChapeauModel
{
    public class Restaurant
    {
        private static Restaurant _instance;

        private List<Menu> _menus;
        public List<Menu> Menus { get { return _menus; } }
        
        private List<Table> _tables;
        public List<Table> Tables { get { return _tables; } }

        private Table? _selectedTable;
        public Table? SelectedTable { get { return _selectedTable; } }

        private Employee _loggedInEmployee;
        public Employee LoggedInEmployee { get { return _loggedInEmployee; } }

        private Restaurant() { }

        public static Restaurant GetInstance()
        {
            if (_instance == null)
                _instance = new Restaurant();

            return _instance;
        }

        public void SetMenus(List<Menu> menus)
        {
            _menus = menus;
        }
        public void SetTables(List<Table> tables)
        {
            _tables = tables;
        }
        public void SetSelectedTable(Table? selectedTable)
        {
            _selectedTable = selectedTable;
        }
        public void SetLoggedInEmployee(Employee employee)
        {
            _loggedInEmployee = employee;
        }

        public void DecreaseStock(MenuItem menuItem, int quantity)
        {
            foreach (Menu menu in _menus)
            {
                foreach (MenuItem mI in menu.MenuItems)
                {
                    if (mI.MenuItemId == menuItem.MenuItemId)
                    {
                        menuItem.Stock.Decrease(quantity);
                    }
                }
            }
        }
        public void IncreaseStock(MenuItem menuItem, int quantity)
        {
            foreach (Menu menu in _menus)
            {
                foreach (MenuItem mI in menu.MenuItems)
                {
                    if (mI.MenuItemId == menuItem.MenuItemId)
                    {
                        menuItem.Stock.Increase(quantity);
                    }
                }
            }
        }
    }
}

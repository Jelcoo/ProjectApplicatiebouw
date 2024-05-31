using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Restaurant
    {
        private static Restaurant _instance;

        private List<Menu> _menus;
        public List<Menu> Menus { get { return _menus; } }

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
        public void SetSelectedTable(Table? selectedTable)
        {
            _selectedTable = selectedTable;
        }
        public void SetLoggedInEmployee(Employee employee)
        {
            _loggedInEmployee = employee;
        }

        public void ModifyStock(OrderLine orderLine)
        {
            foreach (Menu menu in _menus)
            {
                foreach (MenuItem menuItem in menu.MenuItems)
                {
                    if (menuItem.MenuItemId == orderLine.MenuItem.MenuItemId)
                    {
                        menuItem.Stock.Decrease(orderLine.Quantity);
                    }
                }
            }
        }
    }
}

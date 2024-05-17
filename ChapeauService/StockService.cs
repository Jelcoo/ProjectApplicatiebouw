using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class StockService
    {
        private StockDao _stockDao;

        public StockService()
        {
            _stockDao = new StockDao();
        }

        public Dictionary<int, (string name, int stock)> GetStock()
        {
            return _stockDao.GetStock();
        }

        public List<MenuType> GetMenuTypes()
        {
            return _stockDao.GetMenuTypes();
        }

        public List<Menu> GetMenus()
        {
            return _stockDao.GetMenus();
        }
        public List<Double> GetVATRates()
        {
            return _stockDao.GetVATRates();
        }

        //Add Item

        public int AddItemStock(int stockAmount)
        {
            return _stockDao.AddItemStock(stockAmount);
        }

        public void AddMenuItem(MenuItem menuItem) 
        {
            _stockDao.AddMenuItem(menuItem);
        }
    }
}
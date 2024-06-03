using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class StockDisplayItem
    {
        private int _stockId;
        public int StockId { get { return _stockId; } }

        private int _menuItemId;
        public int MenuItemId { get { return _menuItemId; } }

        private string _itemName;
        public string ItemName { get { return _itemName; } }

        private int _stockCount;
        public int StockCount { get { return _stockCount; } }

        public StockDisplayItem(int stockCount, int menuItemId, string itemName)
        {
            _stockCount = stockCount;
            _menuItemId = menuItemId;
            _itemName = itemName;
        }

        public StockDisplayItem(int stockId, int stockCount, int menuItemId, string itemName)
            : this(stockCount, menuItemId, itemName)
        {
            _stockId = stockId;
        }
    }
}

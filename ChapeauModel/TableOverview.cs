using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class TableOverview
    {
        private int _tableId;
        public int TableId { get { return _tableId; } }

        private bool _occupied;
        public bool Occupied { get { return _occupied; } }

        public TableOverview()
        {

        }

        public TableOverview(bool occupied)
        {
            _occupied = occupied;
        }

        public TableOverview(int tableId, bool occupied)
            : this(occupied)
        {
            _tableId = tableId;
        }
    }

}

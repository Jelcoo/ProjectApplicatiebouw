using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class TableOverviewService
    {
        private OverviewDao _overviewDao;

        public TableOverviewService()
        {
            _overviewDao = new OverviewDao();
        }

        public List<Table> GetAllTables()
        {
            return _overviewDao.GetTables();
        }

        public Table GetTableById(int tableId)
        {
            return _overviewDao.GetTableById(tableId);
        }
    }
}

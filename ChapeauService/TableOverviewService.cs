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
        private readonly OverviewDao _overviewDao;

        public TableOverviewService()
        {
            _overviewDao = new OverviewDao();
        }

        public List<TableOverview> GetAllTables()
        {
            return _overviewDao.GetTables();
        }

        public TableOverview GetTableById(int tableId)
        {
            var tables = _overviewDao.GetTables();
            return tables.FirstOrDefault(table => table.TableId == tableId);
        }

        public void UpdateTableStatus(int tableId, bool isOccupied)
        {
            // Code om de tabelstatus bij te werken in de database
            string query = "UPDATE [tables] SET isOccupied = @isOccupied WHERE tableId = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@isOccupied", isOccupied ? 1 : 0),
                new SqlParameter("@tableId", tableId)
            };

            _overviewDao.ExecuteEditQuery(query, sqlParameters);
        }
    }


}

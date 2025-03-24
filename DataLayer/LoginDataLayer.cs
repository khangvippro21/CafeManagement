using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;

namespace DataLayer
{
    public class LoginDataLayer:DataProvider
    {
        public bool Login(Account account)
        {
            string sql = "SELECT COUNT(USERNAME) FROM Users WHERE Username = '"
                + account.Username + "'AND Password = '" + account.Password + "'";
            try
            {
                return ((int)MyExecuteScalar(sql, CommandType.Text) > 0);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}

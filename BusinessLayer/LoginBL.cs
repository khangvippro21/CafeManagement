using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class LoginBL
    {
        public bool Login(Account acc)
        {
            try
            {
                return (new LoginDataLayer().Login(acc));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

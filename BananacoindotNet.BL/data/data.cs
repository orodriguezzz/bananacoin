using BananacoindotNet.BL.dapper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananacoindotNet.BL.data
{
    public static class data
    {
        /// <summary>
        /// Dummy method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static object getdata(string id)
        {
            //result
            try
            {
                using (var con = config.GetOpenConnection())
                {
                    con.Query<object>("spBananacoin_get_data",
                        new { id = id },
                        commandType: CommandType.StoredProcedure
                    ).ToList();
                    con.Close();
                }
                return null;
            }
            catch (Exception e)
            {
                //Save the logs!
                return null;
            }
        }
    }
}

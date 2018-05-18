using BananacoindotNet.BL.dapper;
using BananacoindotNet.BL.model;
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

        /// <summary>
        /// Verifico existencia de cuenta según parámetro dirección y si no existe la creo
        /// En el caso de que exista retorno los datos asociados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static BC_CuentaSaldoViewModel getCreateCuenta(string direccion)
        {
            BC_CuentaSaldoViewModel result = new BC_CuentaSaldoViewModel();
            try
            {
                using (var con = config.GetOpenConnection())
                {
                    result = con.Query<BC_CuentaSaldoViewModel>("BC_spBananacoin_getcreate_direccion",
                        new { direccion = direccion },
                        commandType: CommandType.StoredProcedure
                    ).FirstOrDefault();
                    con.Close();
                }
                return result;
            }
            catch (Exception e)
            {
                //Save the logs!
                return null;
            }
        }

        /// <summary>
        /// Obtengo las transacciones de una cuenta
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public static List<BC_TransaccionViewModel> getTransacciones(string direccion)
        {
            List<BC_TransaccionViewModel> result = new List<BC_TransaccionViewModel>();
            try
            {
                using (var con = config.GetOpenConnection())
                {
                    result = con.Query<BC_TransaccionViewModel>("BC_spBananacoin_get_transaccion",
                        new { direccion = direccion },
                        commandType: CommandType.StoredProcedure
                    ).ToList();
                    con.Close();
                }
                return result;
            }
            catch (Exception e)
            {
                //Save the logs!
                return null;
            }
        }

        /// <summary>
        /// Obtengo el listado de tipos de transacciones
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public static List<BC_tipoInstruccionViewModel> getTipoTransaccion()
        {
            List<BC_tipoInstruccionViewModel> result = new List<BC_tipoInstruccionViewModel>();
            try
            {
                using (var con = config.GetOpenConnection())
                {
                    result = con.Query<BC_tipoInstruccionViewModel>("BC_spBananacoin_get_tipoInstruccion",
                        new {  },
                        commandType: CommandType.StoredProcedure
                    ).ToList();
                    con.Close();
                }
                return result;
            }
            catch (Exception e)
            {
                //Save the logs!
                return null;
            }
        }
    }
}

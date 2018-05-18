using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananacoindotNet.BL.model
{
    public class BC_CuentaSaldoViewModel
    {
        public int id { get; set; }
        public string direccion { get; set; }
        public int saldo { get; set; }
        public List<BC_TransaccionViewModel> transacciones { get; set; }
        public List<BC_tipoInstruccionViewModel> tipoTransacciones { get; set; }
    }

    public class BC_TransaccionViewModel
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int monto { get; set; }
        public string tipoInstruccion { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string _fechaRegistro
        {
            get
            {
                return string.Format("{0} {1}", fechaRegistro.ToShortDateString(), fechaRegistro.ToShortTimeString());
            }
        }
    }

    public class BC_tipoInstruccionViewModel
    {
        public int id { get; set; }
        public string tipoInstruccion { get; set; }
    }
}

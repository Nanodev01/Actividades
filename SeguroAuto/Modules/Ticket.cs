using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAuto
{
    [Serializable]
    abstract class Ticket
    {
        protected int nroOrden;
        protected DateTime fechaHora;

        public int verNumero() 
        {
            return nroOrden;
        }

        public DateTime verFechaHora()
        {
            return fechaHora;
        }
    }
}

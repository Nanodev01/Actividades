using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAuto
{
    [Serializable]
    class Denuncia : Ticket
    {
        private Vehiculo dominio;
        static int numero = 0;

        public Denuncia(Vehiculo asegurado)
        { 
            dominio = asegurado;
            numero++;
        }


    }
}

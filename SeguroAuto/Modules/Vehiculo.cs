using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAuto
{
    [Serializable]
    class Vehiculo : IComparable<Vehiculo>
    {
        private string nroPatente;
        private Cliente owner;

        public Vehiculo(string nroPatente, Cliente owner)
        { 
            this.nroPatente = nroPatente;
            this.owner= owner;
        }

        public Cliente verOwner()
        {
            
            return owner;
        }

        private string VerPatente()
        { return nroPatente; }

        public int CompareTo(Vehiculo otro)
        {
            if (otro == null) return 1;
            else return nroPatente.CompareTo(otro.nroPatente);
        }

        public override string ToString()
        {
            return owner.ToString() + " Patente: " + nroPatente;
        }
    }
}

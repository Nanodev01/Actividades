using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAuto
{
    class DniException : ApplicationException
    {
        public DniException() : base("Formato invalido en el documento")
        { }
        public DniException(string mensaje) : base(mensaje) 
        { }
        public DniException(string mensaje, Exception e):base(mensaje,e) 
        { }
    }
}

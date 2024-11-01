using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAuto
{
    [Serializable]
    class Cliente : Ticket
    {
        long dni;
        static int numero = 0;

        public Cliente(string dni)
        {
            fechaHora = DateTime.Now;
            try
            {
                long aux = Convert.ToInt64(dni);
                if (aux < 5000000) throw new DniException();
                for (int i = 0; i < dni.Length; i++)
                {
                    if (char.IsLetter(dni[i]))
                    {
                        throw new DniException($"El DNI tiene la letra {dni[i]} en la posicion {i} ");
                    }
                }
                this.dni = Convert.ToInt64(dni);

            }
            catch (FormatException)
            {
                throw;
            }
            catch (DniException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }           
        }
        public override string ToString()
        {
            return fechaHora.ToString() +"|| Cliente: " + dni.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAuto
{
    [Serializable]
    class Agencia
    {
        public List<Ticket> Atendidos = new List<Ticket>();
        
        private List<Vehiculo> listVehiculos = new List<Vehiculo>();
        

        //  Colas clientes 
        private Queue<Denuncia> Denuncias = new Queue<Denuncia>();
        //  --- public Queue<Denuncia> denuncias { get { return Denuncias; } } -- No es necesario por que de eso se encarga atender ticket

        private Queue<Cliente> NuevosClientes = new Queue<Cliente>();

        public void AgregarTicket(Ticket turno)
        {
            if (turno is Denuncia) Denuncias.Enqueue((Denuncia)turno);
            if (turno is Cliente) NuevosClientes.Enqueue((Cliente)turno);
            
        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket atendido = null;
            
            switch (tipo)
            {
                case 1:
                    if (Denuncias.Count > 0)
                        atendido = Denuncias.Dequeue();
                    break;
                case 2:
                    if (NuevosClientes.Count > 0)
                        atendido = NuevosClientes.Dequeue(); 
                    break;
                
            }
            if (atendido != null)
                Atendidos.Add(atendido);     
            
            return atendido;
        }
    }
}

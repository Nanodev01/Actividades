using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguroAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Inicializacion
        Agencia agencia;
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
           Ticket ticket = agencia.AtenderTicket(2);
            if (ticket != null)
            { 
                lbxTurnos.Items.Remove(ticket);
            }
        }

        private void btnAtenderDenuncias_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(1);
            if (ticket != null)
                lbxTurnos.Items.Remove(ticket);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket nuevo = null;
                if (rbDenuncia.Checked) // Iniciar una denuncia
                {
                    Cliente cliente = new Cliente(tbDni.Text);
                    Vehiculo a = new Vehiculo(tbPatente.Text, cliente);
                    nuevo = agencia.AgregarTicket(new Denuncia(a));

                    agencia.agregarVehiculo(a);
                    lbxTurnos.Items.Add(nuevo);
                    rbDenuncia.Checked = false;
                }
                else if (rbNCliente.Checked)// gestionar Nuevo Cliente
                {
                    Ticket ticket = new Cliente(tbDni.Text);
                    nuevo = agencia.AgregarTicket(ticket);

                    lbxTurnos.Items.Add(nuevo);
                    tbDni.Clear();
                    rbNCliente.Checked = false;
                }
                else
                { 
                    agencia.listVehiculos.Sort();
                    Vehiculo buscado = new Vehiculo(tbPatente.Text, new Cliente("5000000"));
                    int i = agencia.listVehiculos.BinarySearch(buscado);
                    if (i > 0)
                    {
                        MessageBox.Show($"La patente buscada es {agencia.listVehiculos[i]}");
                    }
                    
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Datos.bin"))
            { 
                fs = new FileStream("Datos.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf =  new BinaryFormatter();
                agencia = (Agencia)bf.Deserialize(fs);
                fs.Close();
            }
            else
                agencia = new Agencia();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fs = new FileStream("Datos.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, agencia);
            fs.Close();
        }
    }
}

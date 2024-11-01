using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Agencia agencia = new Agencia();
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
                if (rbDenuncia.Checked)
                {
                    Cliente cliente = new Cliente(tbDni.Text);
                    Vehiculo a = new Vehiculo(tbPatente.Text, cliente);
                    Ticket ticket = agencia.AgregarTicket(new Denuncia(a));
                    lbxTurnos.Items.Add(ticket);
                }
                else
                {
                    Cliente cliente = new  Cliente(tbDni.Text);
                    Vehiculo b = new Vehiculo(tbPatente.Text, cliente);
                    Ticket ticket = agencia.AgregarTicket(cliente);
                    
                    agencia.AgregarTicket(ticket);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

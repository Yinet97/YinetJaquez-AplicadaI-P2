using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAL;
using BLL;

namespace Yinet_Jaquez__AplicadaI_P2.UI
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            Clientes client = new Clientes();
            client.Nombres = NombreTextBox.Text;
            client.LimiteCredito = Convert.ToInt32(LimiteTextBox.Text);
            client.FechaNacimiento = FechaDateTimePicker.Value.Date;

            if(ClientesBll.Guardar(client))
            {
                MessageBox.Show("Guardado");
            }
            Limpiar();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            var c = ClientesBll.Buscar(Convert.ToInt32(IDTextBox.Text));
            if (c != null)
            {
                NombreTextBox.Text = c.Nombres;
                LimiteTextBox.Text = c.LimiteCredito.ToString();
                FechaDateTimePicker.Text = c.FechaNacimiento.ToString();
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);

            ClientesBll.Eliminar(id);
            MessageBox.Show("Eliminado !");

            Limpiar();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            IDTextBox.Clear();
            NombreTextBox.Clear();
            LimiteTextBox.Clear();
        }
    }
}

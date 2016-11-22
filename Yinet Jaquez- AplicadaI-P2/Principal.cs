using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Entidades;

namespace Yinet_Jaquez__AplicadaI_P2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.RegistroCliente rc = new UI.RegistroCliente();
            rc.Show();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            var tel = ClientesBll.Buscar(Convert.ToInt32(IdTextBox.Text));
            if (tel != null)
            {
                ClienteTextBox.Text = tel.Nombres;
                ListaDataGridView.DataSource = null;
                ListaDataGridView.DataSource = tel.Telefono;
            }
        }

        private void LlenarComboBox()
        {
            ClientesComboBox.DataSource = TiposTelefonosBll.GetLista();
            ClientesComboBox.ValueMember = "TipoId";
            ClientesComboBox.DisplayMember = "Descripcion";
            
        }

        Clientes client = new Clientes();
        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            client.Telefono.Add(new TiposTelefonos((int)ClientesComboBox.SelectedValue, ClientesComboBox.Text  ));
            ListaDataGridView.DataSource = null;
            ListaDataGridView.DataSource = client.Telefono ;
        }

        private void InsertarBoton_Click(object sender, EventArgs e)
        {
            TiposTelefonos tel = new TiposTelefonos();
            tel.Descripcion = "Iphone";
            TiposTelefonosBll.Guardar(tel);
            LlenarComboBox();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.ConsultaCliente cc = new UI.ConsultaCliente();
            cc.Show();
        }
    }
}

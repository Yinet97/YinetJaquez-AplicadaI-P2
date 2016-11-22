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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        List<Clientes> lista = new List<Clientes>();
        private void ConsultarBoton_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(CampoTextBox.Text))
            {
                lista = ClientesBll.GetLista(Utilidades.stringToInt(CampoTextBox.Text));
            }
            else
            {
                lista = ClientesBll.GetLista();

            }
            ConsultaDataGridView.DataSource = lista;
        }
    }
}

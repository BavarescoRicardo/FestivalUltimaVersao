using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Festival.listagens
{
    public partial class ListaPrincipal : Form
    {
        public ListaPrincipal()
        {
            InitializeComponent();
        }

        // Construtor que recebe lista dinamica de objetos
        public ListaPrincipal(string descricao)
        {
            InitializeComponent();
            this.Name = descricao;
        }
        public void definirGrid(DataTable dt)
        {
            grdviewListaPrincipal.DataSource = dt;
            grdviewListaPrincipal.Refresh();

        }

        private void grdviewListaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using Festival.bo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Festival.listagens
{
    public partial class ListaCategoria : Form
    {
        public ListaCategoria()
        {
            InitializeComponent();

            CategoriaBo bo = new CategoriaBo();
            IList<Festival.or.Categoria> lista = bo.Listar();
            gridControl.RefreshDataSource();

            this.bindingSource.Clear();
            bindingSource.DataSource = lista;
            this.bindingSource.ResetBindings(true);
            gridControl.Refresh();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

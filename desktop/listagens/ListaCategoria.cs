using Festival.bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

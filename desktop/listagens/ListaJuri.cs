using Festival.bo;
using Festival.or;
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
    public partial class ListaJuri : Form
    {
        public ListaJuri()
        {
            InitializeComponent();

            JuradoBo bo = new JuradoBo();
            Jurado j = new Jurado();
            IList<Festival.or.Jurado> lista = bo.Listar();
            gridControl.RefreshDataSource();
            this.bindingSource.Clear();
            bindingSource.DataSource = lista;
            this.bindingSource.ResetBindings(true);
            gridControl.Refresh();
        }
    }
}

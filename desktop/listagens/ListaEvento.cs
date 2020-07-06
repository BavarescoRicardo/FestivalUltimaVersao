namespace Festival.listagens
{
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

    public partial class ListaEvento : Form
    {
        public ListaEvento()
        {
            InitializeComponent();
            EventoBo bo = new EventoBo();
            IList<Festival.or.Evento> lista = bo.Listar();
            gridControl.RefreshDataSource();
 
            this.fonteDadosBinding.Clear();
            fonteDadosBinding.DataSource = lista;
            this.fonteDadosBinding.ResetBindings(true);
            gridControl.Refresh();
        }
    }
}

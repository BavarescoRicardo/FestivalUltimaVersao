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
    public partial class ListaNotas : Form
    {
        public ListaNotas()
        {
            InitializeComponent();

            NotasBo bo = new NotasBo();
            IList<Festival.or.Notas> lista = bo.Listar();
            gridControl.RefreshDataSource();

            this.bindingSource.Clear();
            bindingSource.DataSource = lista;
            this.bindingSource.ResetBindings(true);
            gridControl.Refresh();
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "cantor")
            {
                // Inicia objeto do banco caso esteja na coluna certa
                CantorBo bo = new CantorBo();
                // Localize objeto pelo id e substitui na coluna
                e.DisplayText = bo.RetornePeloId((int)e.Value).nome;
            }

            if (e.Column.FieldName == "categoria")
            {
                CategoriaBo bo = new CategoriaBo();
                e.DisplayText = bo.RetornePeloId((int)e.Value).categoria;
            }

            if (e.Column.FieldName == "apresentacao")
            {
                // Inicia objeto do banco caso esteja na coluna certa
                ApresentacaoBo bo = new ApresentacaoBo();
                // Localize objeto pelo id e substitui na coluna
                e.DisplayText = bo.RetornePeloId((int)e.Value).musica;
            }

            if (e.Column.FieldName == "jurado")
            {
                JuradoBo bo = new JuradoBo();
                e.DisplayText = bo.RetornePeloId((int)e.Value).nome;
            }
        }
    }
}

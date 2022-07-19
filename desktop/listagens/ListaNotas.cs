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
    public partial class ListaNotas : Form
    {
        IList<Festival.or.Notas> lista;
        public ListaNotas()
        {
            InitializeComponent();

            NotasBo bo = new NotasBo();
            lista = bo.Listar();
            gridControl.RefreshDataSource();

            this.bindingSource.Clear();
            bindingSource.DataSource = lista;
            // bindingSource.DataSource = lista.Where(x => x.categoria == 6);
            this.bindingSource.ResetBindings(true);
            gridControl.Refresh();

            // Carregar filtro
            CategoriaBo catBo = new CategoriaBo();
            foreach (Categoria cat in catBo.Listar())
            {
                this.cmbFiltro.Properties.Items.Add(cat);
            }
            this.cmbFiltro.Properties.Items.Add(new Categoria() {categoria = "Todos" });
        }


        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Filtro não pode ser realizado");
                //return;
                throw;
            }
            
        }

        private void cmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString.Equals(cmbFiltro.SelectedText);

            Categoria cat = (Categoria)cmbFiltro.SelectedItem;
            if (lista.Where(x => x.categoria == cat.id_categoria).Count() > 0)
            {
                bindingSource.DataSource = lista.Where(x => x.categoria == cat.id_categoria);
            }
            else
            {
                bindingSource.DataSource = lista;
            }
            
        }
    }
}

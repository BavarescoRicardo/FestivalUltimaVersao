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
    public partial class ListaClassifica : Form
    {
        IList<Festival.or.Classificacao> lista;
        int idApresentacao = 0;
        public ListaClassifica()
        {
            InitializeComponent();

            ClassificacaoBo bo = new ClassificacaoBo();
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

        private void gridView1_CustomColumnDisplayText_1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "apresentacao.id_apresentacao")
                {
                    // Guarda o id atual da classificacao mostrada na tabela
                    idApresentacao = (int)e.Value;

                }

                if (e.Column.FieldName == "apresentacao.categoria")
                {
                    ApresentacaoBo bo = new ApresentacaoBo();
                    CategoriaBo categoriaBo = new CategoriaBo();
                    e.DisplayText = 
                           categoriaBo.RetornePeloId(bo.RetornePeloId(idApresentacao).categoria.id_categoria).categoria;
                }

                if (e.Column.FieldName == "apresentacao.musica")
                {
                    // Inicia objeto do banco caso esteja na coluna certa
                    ApresentacaoBo bo = new ApresentacaoBo();
                    // Localize objeto pelo id e substitui na coluna
                    e.DisplayText = bo.RetornePeloId(idApresentacao).musica;
                }

                if (e.Column.FieldName == "apresentacao.cantor")
                {
                    ApresentacaoBo bo = new ApresentacaoBo();
                    CantorBo categoriaBo = new CantorBo();
                    e.DisplayText =
                           categoriaBo.RetornePeloId(bo.RetornePeloId(idApresentacao).cantor.id_cantor).nome;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Filtro não pode ser realizado");
                //return;
                throw;
            }
        }

        /*        private void cmbFiltro_SelectedValueChanged(object sender, EventArgs e)
                {
                    Categoria cat = (Categoria)cmbFiltro.SelectedItem;
                    if (lista.Where(x => x.categoria == cat.id_categoria).Count() > 0)
                    {
                        bindingSource.DataSource = lista.Where(x => x.categoria == cat.id_categoria);
                    }
                    else
                    {
                        bindingSource.DataSource = lista;
                    }*/

    }
}


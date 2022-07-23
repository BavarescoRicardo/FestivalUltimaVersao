using Festival.bo;
using Festival.or;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Festival.listagens
{
    public partial class ListaClassifica : Form
    {
        public int[] IdsSelecionados;
        public ListaClassifica()
        {
            InitializeComponent();
            IList<Festival.or.Classificacao> lista;

            ClassificacaoBo bo = new ClassificacaoBo();
            lista = bo.Listar();
            IdsSelecionados = new int[lista.Count];
            gridControl.RefreshDataSource();

            this.bindingSource.Clear();
            bindingSource.DataSource = lista;
            
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
                if (e.Column.FieldName == "categoria.id_categoria")
                {
                    CategoriaBo categoriaBo = new CategoriaBo();
                    e.DisplayText =
                           categoriaBo.RetornePeloId((int)e.Value).categoria;
                }
                
                if (e.Column.FieldName == "apresentacao.id_apresentacao")
                {
                    // Inicia objeto do banco caso esteja na coluna certa
                    ApresentacaoBo bo = new ApresentacaoBo();
                    // Localize objeto pelo id e substitui na coluna
                    e.DisplayText = bo.RetornePeloId((int)e.Value).musica;
                }

                if (e.Column.FieldName == "cantor.id_cantor")
                {
                    CantorBo categoriaBo = new CantorBo();
                    e.DisplayText =
                            categoriaBo.RetornePeloId((int)e.Value).nome;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ClassificacaoBo bo = new ClassificacaoBo();
            Classificacao c = new Classificacao();
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                // code when checked
                if (IdsSelecionados[i] == 1) 
                {
                    c = (Classificacao)gridView1.GetRow(i);

                    DialogResult dr = MessageBox.Show("Deseja remover a classificação: " + c.id_classificacao,
                      "Código ", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            bo.Excluir(c);
                            bindingSource.DataSource = bo.Listar();
                            gridView1.RefreshData();
                            break;
                        case DialogResult.No:
                            break;
                    }

                }
                                    

            }
            
        }

        private void repositoryItemCheckEdit4_CheckStateChanged(object sender, EventArgs e)
        {
            if (IdsSelecionados[gridView1.GetSelectedRows().First()] == 0)
            {
                IdsSelecionados[gridView1.GetSelectedRows().First()] = 1;
            } else
            {
                IdsSelecionados[gridView1.GetSelectedRows().First()] = 0;
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


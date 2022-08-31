using DevExpress.XtraGrid.Views.Grid;
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
    public partial class ListaEnsaio : Form
    {
        private int[] IdsSelecionados;
        private IList<Festival.or.Apresentacao> lista;
        public ListaEnsaio()
        {
            InitializeComponent();

            ApresentacaoBo bo = new ApresentacaoBo();
            lista = bo.Listar();
            IdsSelecionados = new int[lista.Count];
            gridControl.RefreshDataSource();

            this.bindingSource1.Clear();
            bindingSource1.DataSource = lista;
            gridControl.Refresh();

            // Carregar filtro
            CategoriaBo catBo = new CategoriaBo();
            foreach (Categoria cat in catBo.Listar())
            {
                this.cmbFiltro.Properties.Items.Add(cat);
            }
            this.cmbFiltro.Properties.Items.Add(new Categoria() { categoria = "Todos" });
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if ((e.Column.FieldName == "cantor.id_cantor") && (e.Column.Name == "colCidade"))
                {
                    // Inicia objeto do banco caso esteja na coluna certa
                    CantorBo bo = new CantorBo();
                    // Localize objeto pelo id e substitui na coluna
                    e.DisplayText = bo.RetornePeloId((int)e.Value).cidade;

                }

                if ((e.Column.FieldName == "cantor.id_cantor") && (e.Column.Name == "colEstado"))
                {
                    // Inicia objeto do banco caso esteja na coluna certa
                    CantorBo bo = new CantorBo();
                    // Localize objeto pelo id e substitui na coluna
                    e.DisplayText = bo.RetornePeloId((int)e.Value).estado;

                }

                if (e.Column.FieldName == "categoria.id_categoria")
                {
                    CategoriaBo bo = new CategoriaBo();
                    e.DisplayText = bo.RetornePeloId((int)e.Value).categoria;
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
            Categoria cat = (Categoria)cmbFiltro.SelectedItem;
            if (lista.Where(x => x.categoria.id_categoria == cat.id_categoria).Count() > 0)
            {
                bindingSource1.DataSource = lista.Where(x => x.categoria.id_categoria == cat.id_categoria);
                gridControl.Refresh();
            }
            else
            {
                bindingSource1.DataSource = lista;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (IdsSelecionados[gridView1.GetSelectedRows().First()] == 0)
            {
                IdsSelecionados[gridView1.GetSelectedRows().First()] = 1;
            }
            else
            {
                IdsSelecionados[gridView1.GetSelectedRows().First()] = 0;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Salvar presença para as apresentacoes marcadas
            ApresentacaoBo bo = new ApresentacaoBo();
            //lista = bo.Listar();
            foreach (Apresentacao a in lista.Where(x => x.presenca == true || (x.ativo == 'A')))
            {
                if ((a.ativo == 'A') && (a.presenca == true))
                {
                    a.ativo = ' ';
                }
                else if (a.presenca == true)
                {
                    a.ativo = 'A';
                }

                MessageBox.Show("Atualizado: " + a.nomeartistico);
                bo.Atualizar(a);
            }

            // Atualizar lista
            this.bindingSource1.Clear();
            lista = bo.Listar();
            bindingSource1.DataSource = lista;
            gridControl.Refresh();
        }

    }
}

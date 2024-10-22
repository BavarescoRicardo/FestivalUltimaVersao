﻿using Festival.bo;
using Festival.desktop;
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
    public partial class ListaCantores : Form
    {
        IList<Festival.or.Apresentacao> lista;
        public ListaCantores()
        {
            InitializeComponent();

            ApresentacaoBo bo = new ApresentacaoBo();
            lista = bo.Listar();
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
            this.cmbFiltro.Properties.Items.Add(new Categoria() {categoria = "Todos" });
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "cantor.id_cantor")
                {
                    // Inicia objeto do banco caso esteja na coluna certa
                    CantorBo bo = new CantorBo();
                    // Localize objeto pelo id e substitui na coluna
                    e.DisplayText = bo.RetornePeloId((int)e.Value).nome;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int[] idApr = this.gridView1.GetSelectedRows();
            Apresentacao apr = (Apresentacao)this.gridView1.GetRow(idApr[0]);

            EditarCantorFrm editar = new EditarCantorFrm(apr.id_apresentacao, apr.cantor.id_cantor);
            editar.ShowDialog();
            this.Close();
        }

    }
}

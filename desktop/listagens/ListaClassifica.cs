﻿using Festival.bo;
using Festival.desktop.Formularios;
using Festival.mapeamento;
using Festival.or;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Festival.listagens
{
    public partial class ListaClassifica : Form
    {
        private int[] IdsSelecionados;
        private int[] idsApresentacao;
        private IList<Festival.or.Classificacao> lista;
        public ListaClassifica()
        {
            InitializeComponent();            

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
            this.cmbFiltro.Properties.Items.Add(new Categoria() { categoria = "Todos" });
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

                if (e.Column.Name == "colMusica")
                {
                    // Inicia objeto do banco caso esteja na coluna certa
                    ApresentacaoBo bo = new ApresentacaoBo();
                    // Localize objeto pelo id e substitui na coluna
                    e.DisplayText = bo.RetornePeloId((int)e.Value).musica;
                }

                if (e.Column.Name == "colCantor")
                {
                    ApresentacaoBo bo = new ApresentacaoBo();
                    e.DisplayText =
                            bo.RetornePeloId((int)e.Value).nomeartistico;
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
                    try
                    {
                        c = (Classificacao)gridView1.GetRow(i);

                        DialogResult dr = MessageBox.Show("Deseja remover a classificação: " + c.id_classificacao,
                          "Código ", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                removerNotas(c);
                                bo.Excluir(c);                                
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Não foi possivel remover a classificação ou as notas.. ");
                    }
                }
            }
            
            // Atualizar lista
            gridView1.RefreshData();
            bindingSource.DataSource = bo.Listar();

        }

        private void repositoryItemCheckEdit4_CheckStateChanged(object sender, EventArgs e)
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

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            NotasBo notabo = new NotasBo();
            List<Classificacao> c = new List<Classificacao>();
            List<Notas> listaNotas = new List<Notas>();
            listaNotas = (List<Notas>)notabo.Listar();

            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                // code when checked
                if (IdsSelecionados[i] == 1)
                {
                    c.Add((Classificacao)gridView1.GetRow(i));
                }
            }
            idsApresentacao = (int[])listaNotas.FindAll
                (p => c.Any(p2 => p2.apresentacao.id_apresentacao == p.apresentacao))
                    .Select(x => x.apresentacao).Distinct().ToArray();
            


            //idsApresentacao = listaNotas.Select(x => x.apresentacao).Distinct().ToArray();

            Aprovar aprovaForm = new Aprovar();
            aprovaForm.idApresentacao = idsApresentacao;
            aprovaForm.ShowDialog();
        }

        private void removerNotas(Classificacao c)
        {
            NotasBo notabo = new NotasBo();
            List<Notas> listaNotas = new List<Notas>();
            listaNotas = (List<Notas>)notabo.Listar();

            int antigaContagem = listaNotas.Where(x => x.apresentacao == c.apresentacao.id_apresentacao).ToList().Count;
            for (int i = 0; i < antigaContagem; i++)
            {
                // Remove notas se forem da apresentacao igual a classificacao
                if (listaNotas.Where(x => x.apresentacao == c.apresentacao.id_apresentacao).ToList().Count > 0)
                {
                    notabo.Excluir(listaNotas.Where(x => x.apresentacao == c.apresentacao.id_apresentacao).ToList().First());
                    listaNotas.Remove(listaNotas.Where(x => x.apresentacao == c.apresentacao.id_apresentacao).ToList().First());
                }

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Categoria cat = (Categoria)cmbFiltro.SelectedItem;
                if (lista.Where(x => x.categoria.id_categoria == cat.id_categoria).Count() > 0)
                {
                    bindingSource.DataSource = lista.Where(x => x.categoria.id_categoria == cat.id_categoria);
                }
                else
                {
                    bindingSource.DataSource = lista;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível filtrar por esta categoria");
            }

        }

    }
}


﻿using DevExpress.XtraEditors;
using Festival.bo;
using Festival.or;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Festival.desktop
{
    public partial class EditarCantorFrm : Form
    {
        private Categoria categoriaTemp = null;

        public EditarCantorFrm(int idApr, int idCantor)
        {
            InitializeComponent();
            ApresentacaoBo bo = new ApresentacaoBo();
            CantorBo cantorBo = new CantorBo();
            bindingSourceApresentacao.Add(bo.RetornePeloId(idApr));
            bindingSourceCantor.Add(cantorBo.RetornePeloId(idCantor));
            
            CategoriaBo catBo = new CategoriaBo();
            IList<Festival.or.Categoria> listaCategoria = catBo.Listar();

            // popular combox do grid
            foreach (Categoria cat in listaCategoria)
            {
                this.cmbCategoriaRepositorioGrid.Items.Add(cat);
            }            
        }

        // Gravar Tudo cantor e apresentação
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar objeto Cantor
                Festival.or.Cantor cantor= new Festival.or.Cantor();
                cantor = (Festival.or.Cantor)bindingSourceCantor.Current;
                
                // Gravar cantor no banco
                var crud = new RepositorioCrud<Cantor>();
                bindingSourceCantor.EndEdit();
                crud.Atualizar(cantor);

                // Montar objeto Apresentação
                Festival.or.Apresentacao apresentacao = new Festival.or.Apresentacao();
                apresentacao = (Festival.or.Apresentacao)bindingSourceApresentacao.Current;                

                // Gravar Apresentação no banco
                try
                {
                    Festival.bo.ApresentacaoBo apresentacaoBo = new Festival.bo.ApresentacaoBo();
                    bindingSourceApresentacao.EndEdit();
                    apresentacao.cantor = cantor;
                    apresentacao.categoria = (Categoria)categoriaTemp;
                    apresentacaoBo.Atualizar(apresentacao);
                    MessageBox.Show("Atualizado com sucesso");
                }
                catch (Exception eap)
                {
                    MessageBox.Show("Erro ao atualizar apresentação  "+eap.Message);
                }

                // Limpar campos
                this.txtNome.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar ");
                throw new Exception("Erro ao atualizar  " + ex);
            }
        }

        private void cmbCategoriaRepositorioGrid_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = (sender as ComboBoxEdit);
            this.categoriaTemp = (Categoria)cb.EditValue;
        }

    }

}

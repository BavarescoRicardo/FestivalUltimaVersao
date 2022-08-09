using DevExpress.XtraEditors;
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
        private int idCantor { get; set; }
        private int idApr { get; set; }

        public EditarCantorFrm(int idApr, int idCantor)
        {
            InitializeComponent();
            this.idApr = idApr;
            this.idCantor = idCantor;
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

            // Verifica se existem mais cantores ai então abre novos dialogos
            if (cantorBo.RetornePeloId(idCantor).id_apresentacao != 0)
                return;
            foreach (Cantor c in cantorBo.Listar())
            {
                if (c.id_apresentacao == idApr)
                {
                    EditarCantorFrm editar = new EditarCantorFrm(idApr, c.id_cantor);
                    editar.ShowDialog();
                }
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
                    if (categoriaTemp != null)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Deseja realmente excluir este cantor e apresentação?", "Confirmar exclusão", buttons);
                if (result == DialogResult.No)
                    return;
                    ApresentacaoBo bo = new ApresentacaoBo();
                CantorBo cantorBo = new CantorBo();
                bo.Excluir(bo.RetornePeloId(idApr));
                cantorBo.Excluir(cantorBo.RetornePeloId(idCantor));

                MessageBox.Show("Removido com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível remover este cantor");
                return;
            }
        }
    }

}

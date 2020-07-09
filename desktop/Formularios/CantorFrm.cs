using DevExpress.Data.Helpers;
using DevExpress.Utils.Extensions;
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

namespace Festival.desktop
{
    public partial class CantorFrm : Form
    {
        private long categoriaTemp = 0;

        public CantorFrm()
        {
            InitializeComponent();
            bindingSourceCantor.DataSource = new Festival.or.Cantor();
            //bindingSourceApresentacao.DataSource = new Festival.or.Apresentacao();
            CategoriaBo catBo = new CategoriaBo();
            IList<Festival.or.Categoria> listaCategoria = catBo.Listar();

            // popular combox do grid
            foreach (Categoria cat in listaCategoria)
            {
                this.cmbCategoriaRepositorioGrid.Items.Add(cat);
                // Testes
               // this.cmbCategoriaRepositorioGrid.Items.Insert((int)n, cat.categoria);
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
                Festival.bo.CantorBo bo = new Festival.bo.CantorBo();
                bindingSourceCantor.EndEdit();
                bo.Inserir(cantor);

                // Montar objeto Apresentação
                Festival.or.Apresentacao apresentacao = new Festival.or.Apresentacao();
                apresentacao = (Festival.or.Apresentacao)bindingSourceApresentacao.Current;                

                // Gravar Apresentação no banco
                try
                {
                    Festival.bo.ApresentacaoBo apresentacaoBo = new Festival.bo.ApresentacaoBo();
                    bindingSourceApresentacao.EndEdit();
                    apresentacao.cantor = cantor.id_cantor;
                    apresentacao.categoria = (int)categoriaTemp;
                    apresentacaoBo.Inserir(apresentacao);
                    MessageBox.Show("Inserido com sucesso");
                }
                catch (Exception eap)
                {
                    MessageBox.Show("Erro ao gravar apresentação  "+eap.Message);
                }


                // Deveria fazer isto 
                // INSERT INTO `evento`.`apresentacao` (`musica`, `artista`, `cantor`, `categoria`) VALUES ('simfonia da noite', 'cleiton rasta', '1', '3'); 



                // Limpar campos
                this.txtNome.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ");
                throw new Exception("Erro ao inserir  " + ex);
            }
        }
    }
    
}

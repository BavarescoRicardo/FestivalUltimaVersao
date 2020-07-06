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
        public CantorFrm()
        {
            InitializeComponent();
            bindingSourceCantor.DataSource = new Festival.or.Cantor();
            bindingSourceApresentacao.DataSource = new Festival.or.Apresentacao();
        }

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
                Festival.bo.ApresentacaoBo apresentacaoBo = new Festival.bo.ApresentacaoBo();
                bindingSourceApresentacao.EndEdit();
                apresentacao.cantor = cantor.id_cantor;
                apresentacao.categoria = 4;
                apresentacaoBo.Inserir(apresentacao);
                MessageBox.Show("Inserido com sucesso");

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

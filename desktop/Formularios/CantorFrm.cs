using DevExpress.Data.Helpers;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Festival.bo;
using Festival.or;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festival.desktop
{
    public partial class CantorFrm : Form
    {
        private Categoria categoriaTemp = null;

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
                crud.Inserir(cantor);

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
                    apresentacaoBo.Inserir(apresentacao);
                    MessageBox.Show("Inserido com sucesso");
                }
                catch (Exception eap)
                {
                    MessageBox.Show("Erro ao gravar apresentação  "+eap.Message);
                }

                // Limpar campos
                this.txtNome.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ");
                throw new Exception("Erro ao inserir  " + ex);
            }
        }

        private void cmbCategoriaRepositorioGrid_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = (sender as ComboBoxEdit);
            this.categoriaTemp = (Categoria)cb.EditValue;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\Ninguem\Downloads\inscrifm.csv"))
            {
                int cont = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string[] subs = line.Split(',');

                    foreach (var sub in subs)
                    {
                        MessageBox.Show($"Substring: {sub}");
                    }



                    cont++;
                }
/*                MessageBox.Show(listA += "A ");
                MessageBox.Show(listB += "B ");*/
            }
        }
    }
    
}

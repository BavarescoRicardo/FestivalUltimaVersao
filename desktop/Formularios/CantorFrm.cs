using DevExpress.XtraEditors;
using Festival.bo;
using Festival.or;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
                Festival.or.Cantor cantor = new Festival.or.Cantor();
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
                    MessageBox.Show("Erro ao gravar apresentação  " + eap.Message);
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
            int cont = 0;
            // File import botao
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var values = line.Split(',');

                        // Chama função para insersão
                        if (cont > 0)
                            montarObjetos(line.Split(','));
                        cont++;
                    }
                    MessageBox.Show("Importado com sucesso dados dos cantores, total: " + cont.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir arquivo");
                }
            }
            
        }


        private void montarObjetos(string[] csv)
        {
            //csv[0] - nome artitisco       -- Apresentacao
            //csv[1] - nome(Primeiro)                 -- Cantor
            //csv[2] - nome(Segundo)                 -- Cantor
            //csv[3] - data nascimento                 -- Cantor
            //csv[4] - documento rg                 -- Cantor
            //csv[5] - email                  -- Cantor
            //csv[6] - telefone                  -- Cantor

            // Para mais cantores (Dupla)
            //csv[7] - nome(Primeiro)                 -- Cantor
            //csv[8] - nome(Segundo)                 -- Cantor
            //csv[9] - email                 -- Cantor
            //csv[10] - telefone                 -- Cantor
            //csv[11] - nascimento                 -- Cantor

            // Para mais cantores (Trio)
            //csv[12] - nome(Primeiro)                 -- Cantor
            //csv[13] - nome(Segundo)                 -- Cantor
            //csv[14] - email                 -- Cantor
            //csv[15] - telefone                 -- Cantor
            //csv[16] - nascimento                 -- Cantor

            // Para mais cantores (Grupo)
            //csv[17] - nome(Primeiro)                 -- Cantor
            //csv[18] - nome(Segundo)                 -- Cantor
            //csv[19] - email                 -- Cantor
            //csv[20] - telefone                 -- Cantor
            //csv[21] - nascimento                 -- Cantor

            //csv[22] - bairro                  -- Cantor
            //csv[23] - rua                  -- Cantor
            //csv[24] - cidade                  -- Cantor
            //csv[25] - estado                  -- Cantor
            //csv[26] - cep                  -- Cantor
            //csv[27] - pais                  -- Cantor
            //csv[28] - obs                  -- Cantor

            // Dados objeto apresentacao
            //csv[29] - musica                  -- Apresentacao
            //csv[30] - gravacao                  -- Apresentacao
            //csv[31] - tom                  -- Apresentacao
            //csv[32] - autor                  -- Apresentacao

            //csv[33] - categoria em string fazer case                  -- Apresentacao
            //csv[34] - participacao                  -- Apresentacao


            //  Objeto Cantor
            //            string nome, string email, string contato, string cpf, 
            //                string rg, string observacao, string cidade, string estado, string idade

            //            csv[1] + csv[2], csv[5], csv[6], null, csv[4], csv[28], csv[24], csv[25], string idade =(date hoje - csv[3])
            try
            {
                // Conversõees para transformar a data csv para idade em int
                DateTime nasc = DateTime.ParseExact(csv[3], "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                // Verifica se nasceu antes do mes atual ai reduz um ano
                int idade = DateTime.Now.Year - nasc.Year;
                if (DateTime.Now.Month > nasc.Month)
                    idade--;

                // MessageBox.Show(nasc.Day.ToString() + " " + nasc.Month.ToString() + " " + nasc.Year.ToString());
                Cantor cantor = new Cantor(
                        csv[1] + " " + csv[2], csv[5], csv[6], null, csv[4], csv[28], csv[24], csv[25], idade.ToString(),
                            nasc.Day.ToString() + "/" + nasc.Month.ToString() + "/" + nasc.Year.ToString());

                //  Objeto Apresentacao
                //      string tom, string gravacao, string musica, string artista, Cantor cantor, Categoria categoria, string nomeartistico
                //      csv[31], csv[30], csv[29], csv[32], Cantor, Categoria csv[32], csv[0]

                Apresentacao apresentacao = new Apresentacao(
                    csv[31], csv[30], csv[29], csv[32], cantor, selecionarCategoria(csv[33]), csv[0]);

                CantorBo cantorBo = new CantorBo();
                cantorBo.Inserir(cantor);

                ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
                apresentacaoBo.Inserir(apresentacao);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível importar dados");
                return;
            }
        }

        private Categoria selecionarCategoria(string descricaoCat)
        {
            try
            {
                CategoriaBo bo = new CategoriaBo();
                int idCat = 0;
                switch (descricaoCat)
                {
                    case "Infantil":
                        idCat = 7;
                        break;
                    case "Gospel":
                        idCat = 8;
                        break;
                    case "Sertanejo":
                        idCat = 9;
                        break;
                    case "Juvenil":
                        idCat = 13;
                        break;
                    case "Popular":
                        idCat = 14;
                        break;

                    default:
                        break;
                }

                return bo.RetornePeloId(idCat);
            }
            catch (Exception)
            {

                return null;
            }

        }
    }

}

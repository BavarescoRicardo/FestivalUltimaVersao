﻿using DevExpress.XtraEditors;
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

                        // Chama função para insersão
                        if (cont > 0)
                            montarObjetos(line.Split(';'));
                        cont++;
                    }
                    cont--;
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
            string espec = " ";
            //csv[0] - nome artitisco       -- Apresentacao
            //csv[1] - nome(Primeiro)                 -- Cantor
            //csv[2] - nome(Segundo)                 -- Cantor
            //csv[3] - data nascimento                 -- Cantor
            //csv[4] - documento rg                 -- Cantor
            //csv[5] - email                  -- Cantor
            //csv[6] - telefone                  -- Cantor

            // Para mais cantores (Dupla)
            //csv[9] - nome(Primeiro)                 -- Cantor
            //csv[10] - nome(Segundo)                 -- Cantor
            //csv[11] - email                 -- Cantor
            //csv[12] - telefone                 -- Cantor
            //csv[13] - nascimento                 -- Cantor

            // Para mais cantores (Trio)
            //csv[14] - nome(Primeiro)                 -- Cantor
            //csv[15] - nome(Segundo)                 -- Cantor
            //csv[16] - email                 -- Cantor
            //csv[17] - telefone                 -- Cantor
            //csv[18] - nascimento                 -- Cantor

            // Para mais cantores (Grupo)
            //csv[19] - nome(Primeiro)                 -- Cantor
            //csv[20] - nome(Segundo)                 -- Cantor
            //csv[21] - email                 -- Cantor
            //csv[22] - telefone                 -- Cantor
            //csv[23] - nascimento                 -- Cantor

            //csv[24] - bairro                  -- Cantor
            //csv[25] - rua                  -- Cantor
            //csv[26] - cidade                  -- Cantor
            //csv[27] - estado                  -- Cantor
            //csv[28] - cep                  -- Cantor
            //csv[29] - pais                  -- Cantor
            //csv[30] - obs                  -- Cantor

            // Dados objeto apresentacao
            //csv[31] - musica                  -- Apresentacao
            //csv[32] - gravacao                  -- Apresentacao
            //csv[33] - tom                  -- Apresentacao
            //csv[34] - autor                  -- Apresentacao

            //csv[37] - categoria em string fazer case                  -- Apresentacao
            //csv[38] - participacao                  -- Apresentacao


            //  Objeto Cantor
            //            string nome, string email, string contato, string cpf, 
            //                string rg, string observacao, string cidade, string estado, string idade

            //            csv[1] + csv[2], csv[5], csv[6], null, csv[4], csv[30], csv[26], csv[27], string idade =(date hoje - csv[3])
            try
            {
                // Conversõees para transformar a data csv para idade em int
                DateTime nasc = DateTime.ParseExact(csv[3], "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                // Verifica se nasceu antes do mes atual ai reduz um ano
                int idade = DateTime.Now.Year - nasc.Year;
                if (DateTime.Now.Month > nasc.Month)
                    idade--;

                // Adiciona a variavel espec observacoes e necessidades especiais do Arquivo csv 
                espec = csv[30] + " Possui necessidades:  " + csv[7] + " : " + csv[8];

                Cantor cantor = new Cantor(
                        csv[1] + " " + csv[2], csv[5], csv[6], null, csv[4], espec, csv[26], csv[27], idade.ToString(),
                            nasc.Day.ToString() + "/" + nasc.Month.ToString() + "/" + nasc.Year.ToString());

                //  Objeto Apresentacao
                //      string tom, string gravacao, string musica, string artista, Cantor cantor, Categoria categoria, string nomeartistico
                //      csv[33], csv[32], csv[31], csv[34], Cantor, Categoria csv[34], csv[0]

                Apresentacao apresentacao = new Apresentacao(
                    csv[33], csv[32], csv[31], csv[34], cantor, selecionarCategoria(csv[35]), csv[0], csv[36]);

                CantorBo cantorBo = new CantorBo();
                cantorBo.Inserir(cantor);

                ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
                apresentacaoBo.Inserir(apresentacao);

                // Verifica se tem outros cantores e monta objetos dupla
                if (!string.IsNullOrEmpty(csv[9]))
                {
                    nasc = DateTime.ParseExact(csv[11], "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    // Verifica se nasceu antes do mes atual ai reduz um ano
                    idade = DateTime.Now.Year - nasc.Year;
                    if (DateTime.Now.Month > nasc.Month)
                        idade--;
                    cantor = new Cantor(csv[9] + " " + csv[10], csv[12], csv[13], null, null, null, csv[26], csv[27], idade.ToString(),
                            nasc.Day.ToString() + "/" + nasc.Month.ToString() + "/" + nasc.Year.ToString());
                    cantor.id_apresentacao = apresentacao.id_apresentacao;
                    cantorBo.Inserir(cantor);
                }

                // Verifica se tem outros cantores e monta objetos trio
                if (!string.IsNullOrEmpty(csv[14]))
                {
                    nasc = DateTime.ParseExact(csv[18], "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    // Verifica se nasceu antes do mes atual ai reduz um ano
                    idade = DateTime.Now.Year - nasc.Year;
                    if (DateTime.Now.Month > nasc.Month)
                        idade--;
                    cantor = new Cantor(csv[14] + " " + csv[15], csv[16], csv[18], null, null, null, csv[26], csv[27], idade.ToString(),
                            nasc.Day.ToString() + "/" + nasc.Month.ToString() + "/" + nasc.Year.ToString());
                    cantor.id_apresentacao = apresentacao.id_apresentacao;
                    cantorBo.Inserir(cantor);
                }

                // Verifica se tem outros cantores e monta objetos grupo
                if (!string.IsNullOrEmpty(csv[19]))
                {
                    nasc = DateTime.ParseExact(csv[23], "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    // Verifica se nasceu antes do mes atual ai reduz um ano
                    idade = DateTime.Now.Year - nasc.Year;
                    if (DateTime.Now.Month > nasc.Month)
                        idade--;
                    cantor = new Cantor(csv[19] + " " + csv[20], csv[21], csv[23], null, null, null, csv[26], csv[27], idade.ToString(),
                            nasc.Day.ToString() + "/" + nasc.Month.ToString() + "/" + nasc.Year.ToString());
                    cantor.id_apresentacao = apresentacao.id_apresentacao;
                    cantorBo.Inserir(cantor);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Não foi possível importar dados de: " +csv[0] + " motivo: "+ exc.Message);
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
                        idCat = 1;
                        break;
                    case "Juvenil":
                        idCat = 2;
                        break;
                    case "Popular":
                        idCat = 3;
                        break;
                    case "Sertanejo":
                        idCat = 4;
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

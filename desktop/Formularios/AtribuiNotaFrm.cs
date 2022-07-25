using Festival.bo;
using Festival.or;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Festival.desktop
{
    public partial class AtribuiNotaFrm : Form
    {
        List<Cantor> listaCantores = new List<Cantor>();
        List<Apresentacao> listaApresentacao = new List<Apresentacao>();
        CantorBo cantorBo = new CantorBo();
        ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
        Festival.or.Notas notas = new Festival.or.Notas();
        double[] notaJurados = new double[5];

        public AtribuiNotaFrm()
        {
            InitializeComponent();            

            CategoriaBo categoriaBo = new CategoriaBo();

            // Inserir cantor todos
            this.cmbCantor.Properties.Items.Add(new Cantor() { nome = "Todos", id_cantor = 0 });
            foreach (Cantor cantor in cantorBo.Listar())
            {
                listaCantores.Add(cantor);
                this.cmbCantor.Properties.Items.Add(cantor);
            }

            foreach (Categoria categoria in categoriaBo.Listar())
            {
                this.cmbCategoria.Properties.Items.Add(categoria);
            }

            foreach (Apresentacao apresentacao in apresentacaoBo.Listar())
            {
                listaApresentacao.Add(apresentacao);
                this.cmbApresentacao.Properties.Items.Add(apresentacao);
            }
        }

        private void txtInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Cantor ctr = (Cantor)cmbCantor.SelectedItem;
                Categoria cat = (Categoria)cmbCategoria.SelectedItem;
                Apresentacao ap = (Apresentacao)cmbApresentacao.SelectedItem;

                notas.cantor = ctr.id_cantor;
                notas.categoria = cat.id_categoria;
                notas.apresentacao = ap.id_apresentacao;

                // Gravar no banco
                bindingSource.EndEdit();
                if (notas == null)
                {
                    MessageBox.Show("Erro ao inserir: Nota nula  ");
                    return;
                }

                // Chama o metodo para inserir notas
                inserirNota();
                MessageBox.Show("Inseridas notas com sucesso");
                inserirClassificacao();
                MessageBox.Show("Gravada classificação com sucesso");

                // Limpar campos
                txtNota1J1.Text = " ";
                txtNota2J1.Text = " ";
                txtNota3J1.Text = " ";
                txtNota4J1.Text = " ";

                txtNota1J2.Text = " ";
                txtNota2J2.Text = " ";
                txtNota3J2.Text = " ";
                txtNota4J2.Text = " ";

                txtNota1J3.Text = " ";
                txtNota2J3.Text = " ";
                txtNota3J3.Text = " ";
                txtNota4J3.Text = " ";

                txtNota1J4.Text = " ";
                txtNota2J4.Text = " ";
                txtNota3J4.Text = " ";
                txtNota4J4.Text = " ";

                txtNota1J5.Text = " ";
                txtNota2J5.Text = " ";
                txtNota3J5.Text = " ";
                txtNota4J5.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ");
                throw new Exception("Erro ao inserir  " + ex);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCantor_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Carrega combo apresentações filtrando pelo cantor selecionado neste combo box
                this.cmbApresentacao.Properties.Items.Clear();
                Cantor ctr = (Cantor)cmbCantor.SelectedItem;
                foreach (Apresentacao apr in apresentacaoBo.Listar())
                {
                    if ((apr.cantor.id_cantor == ctr.id_cantor) || (ctr.id_cantor == 0))
                    {
                        this.cmbApresentacao.Properties.Items.Add(apr);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível filtrar");
                this.Close();
            }

        }

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Carrega combo apresentações filtrando pelo cantor selecionado neste combo box
                this.cmbCantor.Properties.Items.Clear();
                this.cmbApresentacao.Properties.Items.Clear();
                // Reseta as listas para todos os resultados
                listaApresentacao = (List<Apresentacao>)apresentacaoBo.Listar();
                listaCantores = (List<Cantor>)cantorBo.Listar();
                // Inserir cantor todos
                this.cmbCantor.Properties.Items.Add(new Cantor() { nome = "Todos", id_cantor = 0 });

                Categoria cat = (Categoria)cmbCategoria.SelectedItem;
                listaApresentacao = listaApresentacao.FindAll(x => x.categoria.id_categoria == cat.id_categoria);
                //listaCantores =
                listaCantores = (List<Cantor>)listaCantores.FindAll(p => listaApresentacao.Any(p2 => p2.cantor.id_cantor == p.id_cantor));

                foreach (Cantor cantor in listaCantores)
                {
                    this.cmbCantor.Properties.Items.Add(cantor);
                }

                foreach (Apresentacao apr in listaApresentacao)
                {
                    this.cmbApresentacao.Properties.Items.Add(apr);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível filtrar");
                return;
            }            
        }

        private void inserirNota()
        {
            NotasBo bo = new NotasBo();
            Calculos calc = new Calculos();

            // Notas do primeiro jurado
            notas.jurado = 1;
            notas.nota1 = double.Parse(txtNota1J1.Text);
            notas.nota2 = double.Parse(txtNota2J1.Text);
            notas.nota3 = double.Parse(txtNota3J1.Text);
            notas.nota4 = double.Parse(txtNota4J1.Text);
            notas.notafinal = calc.mediaNota(notas.nota1, notas.nota2, notas.nota3, notas.nota4);
            
            notaJurados[0] = notas.notafinal;
            bo.Inserir(notas);


            // Notas do segundo jurado
            notas.jurado = 2;
            notas.nota1 = double.Parse(txtNota1J2.Text);
            notas.nota2 = double.Parse(txtNota2J2.Text);
            notas.nota3 = double.Parse(txtNota3J2.Text);
            notas.nota4 = double.Parse(txtNota4J2.Text);
            notas.notafinal = calc.mediaNota(notas.nota1, notas.nota2, notas.nota3, notas.nota4);

            notaJurados[1] = notas.notafinal;
            bo.Inserir(notas);


            // Notas do terceiro jurado
            notas.jurado = 3;
            notas.nota1 = double.Parse(txtNota1J3.Text);
            notas.nota2 = double.Parse(txtNota2J3.Text);
            notas.nota3 = double.Parse(txtNota3J3.Text);
            notas.nota4 = double.Parse(txtNota4J3.Text);
            notas.notafinal = calc.mediaNota(notas.nota1, notas.nota2, notas.nota3, notas.nota4);

            notaJurados[2] = notas.notafinal;
            bo.Inserir(notas);


            // Notas do quarto jurado
            notas.jurado = 4;
            notas.nota1 = double.Parse(txtNota1J4.Text);
            notas.nota2 = double.Parse(txtNota2J4.Text);
            notas.nota3 = double.Parse(txtNota3J4.Text);
            notas.nota4 = double.Parse(txtNota4J4.Text);
            notas.notafinal = calc.mediaNota(notas.nota1, notas.nota2, notas.nota3, notas.nota4);

            notaJurados[3] = notas.notafinal;
            bo.Inserir(notas);


            // Notas do quinto jurado
            notas.jurado = 5;
            notas.nota1 = double.Parse(txtNota1J5.Text);
            notas.nota2 = double.Parse(txtNota2J5.Text);
            notas.nota3 = double.Parse(txtNota3J5.Text);
            notas.nota4 = double.Parse(txtNota4J5.Text);
            notas.notafinal = calc.mediaNota(notas.nota1, notas.nota2, notas.nota3, notas.nota4);

            notaJurados[4] = notas.notafinal;
            bo.Inserir(notas);
        }

        private void inserirClassificacao()
        {
            NotasBo bo = new NotasBo();
            Calculos calc = new Calculos();

            // Monta objeto classificacao e salva no banco
            Classificacao classificacao = new Classificacao();
            
            classificacao.apresentacao = (Apresentacao)this.cmbApresentacao.SelectedItem;
            classificacao .cantor= (Cantor)cmbCantor.SelectedItem;
            classificacao.categoria = (Categoria)cmbCategoria.SelectedItem;

            classificacao.notafinal = calc.mediaNotaMediana(notaJurados[0], notaJurados[1], notaJurados[2], notaJurados[3], notaJurados[4]);

            ClassificacaoBo classificacaoBo = new ClassificacaoBo();
            classificacaoBo.Inserir(classificacao);
        }
    }
}

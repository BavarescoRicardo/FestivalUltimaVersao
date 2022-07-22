using DevExpress.Utils.Behaviors;
using DevExpress.Utils.MVVM;
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
    public partial class AtribuiNotaFrm : Form
    {
        List<Cantor> listaCantores = new List<Cantor>();
        List<Apresentacao> listaApresentacao = new List<Apresentacao>();
        CantorBo cantorBo = new CantorBo();
        ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
        public AtribuiNotaFrm()
        {
            InitializeComponent();
            bindingSource.DataSource = new Festival.or.Notas();

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
                // Montar objeto
                Festival.or.Notas notas = new Festival.or.Notas();
                NotasBo bo = new NotasBo();
                notas = (Festival.or.Notas)bindingSource.Current;

                // Encontrando identificadores
                /* 
                 notas.cantor = cmbCantor.SelectedItem;
                 notas.categoria = cmbCategoria.SelectedItem;
                 notas.jurado = cmbJurado.SelectedItem;
                 notas.apresentacao = cmbApresentacao.SelectedItem;
                */

                Cantor ctr = (Cantor)cmbCantor.SelectedItem;
                Categoria cat = (Categoria)cmbCategoria.SelectedItem;
                Apresentacao ap = (Apresentacao)cmbApresentacao.SelectedItem;
                Calculos calc = new Calculos();

                notas.cantor = ctr.id_cantor;
                notas.categoria = cat.id_categoria;
                notas.apresentacao = ap.id_apresentacao;

                // Faz media das notas e desconta maxima e minima
                notas.notafinal = calc.mediaNota(notas.nota1, notas.nota2, notas.nota3, notas.nota4);

                // Gravar no banco
                bindingSource.EndEdit();
                if (notas == null)
                {
                    MessageBox.Show("Erro ao inserir: Nota nula  ");
                    return;
                }
                    
                bo.Inserir(notas);
                MessageBox.Show("Inserido com sucesso");

                // Limpar campos
                txtNota1J1.Text = " ";
                txtNota2J1.Text = " ";
                txtNota3J1.Text = " ";
                txtNota4J1.Text = " ";
                notas.jurado = 1;

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

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
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
    }
}

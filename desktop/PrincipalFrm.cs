using DevExpress.XtraReports.UI;
using Festival.bo;
using Festival.desktop.Formularios;
using Festival.desktop.impressao;
using Festival.listagens;
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
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();

            //Maximizar Tela Principal

            WindowState = FormWindowState.Maximized;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventoFrm eventoFrm = new EventoFrm();
            eventoFrm.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEvento listar = new ListaEvento();
            listar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriaFrm categoriaFrm = new CategoriaFrm();
            categoriaFrm.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaCategoria listaCategoria = new ListaCategoria();
            listaCategoria.ShowDialog();
        }

        private void mnuCadastrarCantor_Click(object sender, EventArgs e)
        {
            CantorFrm cantor = new CantorFrm();
            cantor.ShowDialog();
        }

        private void mnuCadastrarJurado_Click(object sender, EventArgs e)
        {
            JuradoFrm juradoF = new JuradoFrm();
            juradoF.ShowDialog();
        }

        private void mnuListarJurado_Click(object sender, EventArgs e)
        {
            ListaJuri listaJurado = new ListaJuri();
            listaJurado.ShowDialog();
        }

        private void atribuirNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtribuiNotaFrm nota = new AtribuiNotaFrm();
            nota.ShowDialog();
        }

        private void mnuListarCantor_Click(object sender, EventArgs e)
        {
            ListaCantores listaDinamica = new ListaCantores();
            listaDinamica.Show();
        }

        private void testarListaDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaNotas listar = new ListaNotas();
            listar.ShowDialog();
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListaClassifica listar = new ListaClassifica();
            listar.ShowDialog();
        }

        private void cantoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CantorReport report = new CantorReport();
            //report.DataSource = CreateData();

            // Carregar dados no relatório
            try
            {
                ApresentacaoBo bo = new ApresentacaoBo();
                List<ApresentacaoDtoReport> listaDto = new List<ApresentacaoDtoReport>();
                foreach (Apresentacao apr in bo.Listar())
                {
                    listaDto.Add(new ApresentacaoDtoReport(apr.id_apresentacao, apr.tom, apr.gravacao, apr.musica, apr.artista, apr.cantor.id_cantor, apr.categoria.id_categoria));
                }
                report.DataSource = listaDto;
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível carregar este relatório");
            }


            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            // Carregar dados no relatório
            try
            {
                PreImpressoNota aprovaForm = new PreImpressoNota();
                aprovaForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar este relatório");
            }
        }

        private void listarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ListaApresentacoes listar = new ListaApresentacoes();
            listar.ShowDialog();
        }
    }
}

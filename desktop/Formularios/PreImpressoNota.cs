using DevExpress.XtraReports.UI;
using Festival.bo;
using Festival.desktop.impressao;
using Festival.or;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Festival.desktop.Formularios
{
    public partial class PreImpressoNota : Form
    {
        private Categoria cat = new Categoria();
        private Apresentacao apre = new Apresentacao();
        public PreImpressoNota()
        {
            InitializeComponent();
            CategoriaBo bo = new CategoriaBo();
            ApresentacaoBo aprBo = new ApresentacaoBo();
            foreach (Categoria cat in bo.Listar())
            {
                this.cmbCat.Properties.Items.Add(cat);
            }

            foreach (Apresentacao apre in aprBo.Listar())
            {
                this.cmbApresentacao.Properties.Items.Add(apre);
            }



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                JuradoNotaReport report = new JuradoNotaReport();
                JuradoBo juradoBo = new JuradoBo();
                apre = (Apresentacao)this.cmbApresentacao.SelectedItem;
                

                // Criar lista para atribuir ao binding do relatorio
                List<NotasDtoReport> listaDto = new List<NotasDtoReport>();

                listaDto.Add(new NotasDtoReport(apre.id_apresentacao, apre.cantor.id_cantor, apre.categoria.id_categoria, apre.id_apresentacao));
                report.DataSource = listaDto;
//                foreach (Jurado jur in juradoBo.Listar())
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
                    //listaDto.Clear();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nâo foi possível classificar a apresentação");
                MessageBox.Show("Motivo:  "+ex.Message);
            }

        }

        private void cmbCat_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Carrega combo apresentações filtrando pelo cantor selecionado neste combo box
                List<Apresentacao> listaapre = new List<Apresentacao>();
                ApresentacaoBo apreBo = new ApresentacaoBo();

                this.cmbApresentacao.Properties.Items.Clear();
                // Reseta as listas para todos os resultados
                listaapre = (List<Apresentacao>)apreBo.Listar();
                // Inserir cantor todos
                this.cmbApresentacao.Properties.Items.Add(new Cantor() { nome = "Todos", id_cantor = 0 });

                Categoria cat = (Categoria)cmbCat.SelectedItem;
                listaapre = listaapre.FindAll(x => x.categoria.id_categoria == cat.id_categoria);

                foreach (Apresentacao apr in listaapre)
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
    }
}

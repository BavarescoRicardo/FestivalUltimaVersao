using DevExpress.XtraReports.UI;
using Festival.bo;
using Festival.desktop.impressao;
using Festival.or;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Festival.desktop.Formularios
{
    public partial class PreImpressoApr : Form
    {        
        private Apresentacao apre = new Apresentacao();
        public PreImpressoApr()
        {
            InitializeComponent();
            CategoriaBo bo = new CategoriaBo();
            ApresentacaoBo aprBo = new ApresentacaoBo();
            foreach (Categoria cat in bo.Listar())
            {
                this.cmbCat.Properties.Items.Add(cat);
            }
            this.cmbCat.Properties.Items.Add(new Categoria(0, "Todos"));


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CantorReport report = new CantorReport();

                // Carregar dados no relatório
                try
                {
                    ApresentacaoBo bo = new ApresentacaoBo();
                    Categoria categoria = (Categoria)this.cmbCat.SelectedItem;
                    List<ApresentacaoDtoReport> listaDto = new List<ApresentacaoDtoReport>();
                    foreach (Apresentacao apr in bo.Listar())
                    {
                        if((apr.categoria.id_categoria == categoria.id_categoria) || (categoria.id_categoria == 0))
                            listaDto.Add(new ApresentacaoDtoReport(apr.id_apresentacao, apr.tom, apr.gravacao, apr.musica, apr.artista, apr.cantor.id_cantor, apr.categoria.id_categoria));
                    }
                    report.DataSource = listaDto.OrderBy(x => x.cantor.nome);
                }
                catch (Exception)
                {

                    MessageBox.Show("Não foi possível carregar este relatório");
                }


                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nâo foi possível classificar a apresentação");
                MessageBox.Show("Motivo:  "+ex.Message);
            }

        }

    }
}

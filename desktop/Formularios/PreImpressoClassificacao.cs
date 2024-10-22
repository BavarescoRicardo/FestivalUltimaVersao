﻿using DevExpress.XtraReports.UI;
using Festival.bo;
using Festival.desktop.impressao;
using Festival.or;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Festival.desktop.Formularios
{
    public partial class PreImpressoClassificacao : Form
    {        
        public PreImpressoClassificacao()
        {
            InitializeComponent();
            CategoriaBo bo = new CategoriaBo();
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
                ClassificacaoReport report = new ClassificacaoReport();


                // Carregar dados no relatório
                try
                {
                    ClassificacaoBo bo = new ClassificacaoBo();
                    Categoria categoria = (Categoria)this.cmbCat.SelectedItem;
                    List<ClassificacaoDtoReport> listaDto = new List<ClassificacaoDtoReport>();
                    List<Classificacao> listaBo = new List<Classificacao>();
                    listaBo = bo.Listar().ToList();

                    foreach (Classificacao apr in listaBo)
                    {
                        if((apr.categoria.id_categoria == categoria.id_categoria) || (categoria.id_categoria == 0))
                            listaDto.Add(new ClassificacaoDtoReport(apr.id_classificacao, apr.notafinal, apr.apresentacao.id_apresentacao, apr.categoria.id_categoria, apr.cantor.id_cantor));
                    }
                    
                    if (chkAlfabeto.Checked)
                    {
                        report.DataSource = listaDto.OrderBy(x => x.cantor.nome);
                    } else
                    {
                        report.DataSource = listaDto.OrderByDescending(x => x.notafinal);
                    }
                    

                }
                catch (Exception)
                {

                    MessageBox.Show("Não foi possível carregar este relatório");
                }

                ReportPrintTool tool;
                tool = new ReportPrintTool(report);  
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

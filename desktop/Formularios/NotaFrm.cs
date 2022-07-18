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
    public partial class NotaFrm : Form
    {
        public NotaFrm()
        {
            InitializeComponent();
            bindingSource.DataSource = new Festival.or.Notas();

            ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
            CantorBo cantorBo = new CantorBo();
            JuradoBo juradoBo = new JuradoBo();
            CategoriaBo categoriaBo = new CategoriaBo();

            foreach (Jurado jurado in juradoBo.Listar())
            {
                this.cmbJurado.Properties.Items.Add(jurado);
            }

            foreach (Cantor cantor in cantorBo.Listar())
            {
                this.cmbCantor.Properties.Items.Add(cantor);
            }

            foreach (Categoria categoria in categoriaBo.Listar())
            {
                this.cmbCategoria.Properties.Items.Add(categoria);
            }

            foreach (Apresentacao apresentacao in apresentacaoBo.Listar())
            {
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

                // Gravar no banco
                bindingSource.EndEdit();
                if ((notas == null) || (notas.id_nota <= 0))
                {
                    MessageBox.Show("Erro ao inserir: Nota nula  ");
                    return;
                }
                    
                bo.Inserir(notas);
                MessageBox.Show("Inserido com sucesso");

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

    }
}

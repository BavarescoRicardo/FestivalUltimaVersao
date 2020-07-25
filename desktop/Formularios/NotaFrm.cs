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
            //bindingSource.DataSource = new Festival.or.Notas();
            CantorBo cantorBo = new CantorBo();
            JuradoBo juradoBo = new JuradoBo();

            foreach (Jurado jurado in juradoBo.Listar())
            {
                this.cmbJurado.Properties.Items.Add(jurado);
            }
        }

        private void txtInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar objeto
                //Festival.or.Notas categoria = new Festival.or.Notas();
                //CategoriaBo bo = new CategoriaBo();
                //categoria = (Festival.or.Notas)bindingSource.Current; 

                // Gravar no banco
                //bindingSource.EndEdit();
                //bo.Inserir(Notas);
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

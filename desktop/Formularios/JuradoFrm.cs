namespace Festival.desktop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class JuradoFrm : Form
    {
        public JuradoFrm()
        {
            InitializeComponent();
            bindingSource.DataSource = new Festival.or.Jurado();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar objeto
                Festival.or.Jurado jurado = new Festival.or.Jurado();
                Festival.bo.JuradoBo bo = new Festival.bo.JuradoBo();
                jurado = (Festival.or.Jurado)bindingSource.Current;

                // Gravar no banco
                bindingSource.EndEdit();
                bo.Inserir(jurado);
                MessageBox.Show("Inserido com sucesso");

                // Limpar campos

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ");
                throw new Exception("Erro ao inserir Frm  " + ex);
            }
        }
    }
}

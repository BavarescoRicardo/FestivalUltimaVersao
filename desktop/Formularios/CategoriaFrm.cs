using Festival.bo;
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
    public partial class CategoriaFrm : Form
    {
        public CategoriaFrm()
        {
            InitializeComponent();
            bindingSource.DataSource = new Festival.or.Categoria();
        }

        private void txtInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar objeto
                Festival.or.Categoria categoria = new Festival.or.Categoria();
                CategoriaBo bo = new CategoriaBo();
                categoria = (Festival.or.Categoria)bindingSource.Current; 

                // Gravar no banco
                bindingSource.EndEdit();
                bo.Inserir(categoria);
                MessageBox.Show("Inserido com sucesso");

                // Limpar campos
                txtCategoria.Text = string.Empty;
                txtData.DateTime = new DateTime();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir ");
                throw new Exception("Erro ao inserir  " + ex);
            }
        }
    }
}

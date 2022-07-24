using Festival.bo;
using Festival.or;
using System;
using System.Windows.Forms;

namespace Festival.desktop.Formularios
{
    public partial class Aprovar : Form
    {
        public int[] idApresentacao { get; set; }
        public int idCategoria { get; set; }
        private Categoria cat = new Categoria();
        public Aprovar()
        {
            InitializeComponent();
            CategoriaBo bo = new CategoriaBo();
            foreach (Categoria cat in bo.Listar())
            {
                this.cmbCat.Properties.Items.Add(cat);
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
                Apresentacao apresentacao = new Apresentacao();
                ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
                cat = (Categoria)this.cmbCat.SelectedItem;

                // encontrar apresentacoes selecionadas
                foreach (int id in idApresentacao)
                {
                    apresentacao = apresentacaoBo.RetornePeloId(id);

                    // Montar nova apresentacao
                    apresentacao.categoria = cat;
                    apresentacao.id_apresentacao = 0;

                    // Gravar novas apresentacoes na classe selecionada
                    apresentacaoBo.Inserir(apresentacao);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nâo foi possível classificar a apresentação");
                MessageBox.Show("Motivo:  "+ex.Message);
            }


            MessageBox.Show("Aprovadas com sucesso..");
            this.Close();
        }
    }
}

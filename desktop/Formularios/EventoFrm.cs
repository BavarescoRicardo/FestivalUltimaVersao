namespace Festival
{
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

    public partial class EventoFrm : Form
    {
        public EventoFrm()
        {
            InitializeComponent();
            eventoBindingSource.DataSource = new Festival.or.Evento();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar objeto
                Festival.or.Evento evento = new Festival.or.Evento();
                EventoBo bo = new EventoBo();
                evento = (Festival.or.Evento)eventoBindingSource.Current;

                // Gravar no banco
                eventoBindingSource.EndEdit();
                bo.Inserir(evento);
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

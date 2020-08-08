using Festival.listagens;
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
            NotaFrm nota = new NotaFrm();
            nota.ShowDialog();
        }
    }
}

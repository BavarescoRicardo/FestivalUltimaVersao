using Festival.bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class NotasDtoReport
    {
        public NotasDtoReport()
        {

        }

        public NotasDtoReport(int id_notas, int cantor, int categoria, int apresentacao)
        {
            CantorBo cantorBo = new CantorBo();
            CategoriaBo categoriaBo = new CategoriaBo();
            JuradoBo juradoBo = new JuradoBo();
            ApresentacaoBo apresentacaoBo = new ApresentacaoBo();

            this.id_notas = id_notas;

            this.cantor = cantorBo.RetornePeloId(cantor);
            this.categoria = categoriaBo.RetornePeloId(categoria);
            this.jurado = jurado;
            this.apresentacao = apresentacaoBo.RetornePeloId(apresentacao);
        }

        public virtual int id_notas { get; set; }

        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }
        public virtual Jurado jurado { get; set; }
        public virtual Apresentacao apresentacao { get; set; }

    }
}

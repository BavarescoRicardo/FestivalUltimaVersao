using Festival.bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    class ClassificacaoDtoReport
    {
        ApresentacaoBo apresentacaoBo = new ApresentacaoBo();
        CategoriaBo categoriaBo = new CategoriaBo();
        CantorBo cantorBo = new CantorBo();
        public ClassificacaoDtoReport()
        {

        }

        public ClassificacaoDtoReport(int id_classificacao, double notafinal, int id_apresentacao, int id_categoria, int id_cantor)
        {
            this.id_classificacao = id_classificacao;
            this.notafinal = notafinal;

            this.apresentacao = apresentacaoBo.RetornePeloId(id_apresentacao);
            this.categoria = categoriaBo.RetornePeloId(id_categoria);
            this.cantor = cantorBo.RetornePeloId(id_cantor);
        }

        public virtual int id_classificacao { get; set; }
        public virtual double notafinal { get; set; }
        public virtual Apresentacao apresentacao { get; set; }
        public virtual Cantor cantor { get; set; }
        public virtual Categoria categoria { get; set; }
        public virtual bool codigosSelecionados { get; set; }
    }
}

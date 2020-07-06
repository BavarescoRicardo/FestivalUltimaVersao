using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    public interface ICrudDao<X>
    {
        void Inserir(X or);

        void Atualizar(X or);

        void Excluir(X or);

        X RetornePeloId(int id);
        IList<X> Listar();
    }
}

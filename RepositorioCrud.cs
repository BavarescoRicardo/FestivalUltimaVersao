using Festival.mapeamento;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    public class RepositorioCrud<X> : ICrudDao<X> where X : class
    {
        public void Atualizar(X or)
        {
            using (ISession sessao = FluentySessionFactory.AbrirSessao())
            {
                using (ITransaction transacao = sessao.BeginTransaction())
                {
                    try
                    {
                        sessao.Update(or);
                        transacao.Commit();
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao atualizar informação   " + e.Message);
                    }

                }
            }
        }

        public void Excluir(X or)
        {
            using (ISession sessao = FluentySessionFactory.AbrirSessao())
            {
                using (ITransaction transacao = sessao.BeginTransaction())
                {
                    try
                    {
                        sessao.Delete(or);
                        transacao.Commit();
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao apagar informação   " + e.Message);
                    }

                }
            }
        }

        public void Inserir(X or)
        {
            using (ISession sessao = FluentySessionFactory.AbrirSessao())
            {
                using (ITransaction transacao = sessao.BeginTransaction())
                {
                    try
                    {
                        sessao.Save(or);
                        transacao.Commit();
                    } catch (Exception e)
                    {
                        throw new Exception("Erro ao salvar informação no RepCrud  " + e.Message);
                    }

                }
            }
        }

        public IList<X> Listar()
        {
            using (ISession sessao = FluentySessionFactory.AbrirSessao())
            {
                return (from e in sessao.Query <X>() select e).ToList();
            }
        }

        public X RetornePeloId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

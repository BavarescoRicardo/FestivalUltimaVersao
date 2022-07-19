using DevExpress.XtraLayout.Resizing;
using Festival.mapeamento;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        public DataTable ListaDataTable<X>()
        {
            DataTable dataGrid = new DataTable();
            IList<X> tabela;
            using (ISession sessao = FluentySessionFactory.AbrirSessao())
            {
                tabela = (from e in sessao.Query<X>() select e).ToList();
                
                // Codigo para retornar as colunas através dos atributos do objeto dinamico                
                MemberInfo[] myMembers = typeof(X).GetMembers();
                //myMembers.Select(x => x.Name).Where(x != "equals").ToList();

                List<String> listaColunas = new List<string>();
                List<String> listaColunasFormatadas = new List<string>();
                // Seleciona todos os atributs sem nenhum filtro
                listaColunas = myMembers.Select(mem => mem.Name).ToList();
                // filtra todos os atributos selecionados
                foreach (string col in listaColunas)
                {
                    if ((!Regex.IsMatch(col, @"get.*")) && (!Regex.IsMatch(col, @"set.*")) && (!Regex.IsMatch(col, @".*Hash.*")) && (!Regex.IsMatch(col, @"GetType"))
                            && (!Regex.IsMatch(col, @"Equal.*")) && (!Regex.IsMatch(col, @"ToString")) && (!Regex.IsMatch(col, @"ctor.*"))) 
                    { 
                        if(!Regex.IsMatch(col, @"id_"))
                        {
                            listaColunasFormatadas.Add(col);
                        }
                        else
                        {
                            listaColunasFormatadas.Add(string.Format("Codigo"));
                        }                        
                    }
                }
                
                // Adicionar colunas dinamicas
                for (int i = 0; i < listaColunasFormatadas.Count; i++)
                {
                    dataGrid.Columns.Add(listaColunasFormatadas[i].ToString());
                }

                string[] valorCampo = new string[tabela.Count+2];
                PropertyInfo prop = null;
                int l = 0;

                // Laco entre todas as linhas 
                foreach (var item in tabela)
                {
                    // Laço para cada coluna
                    for (l = 1; l < listaColunasFormatadas.Count; l++)
                    {
                        //  listaColunasFormatadas[i].ToString()
                        prop = item.GetType().GetProperty(listaColunasFormatadas[l].ToString());
                        if ((prop == null) || (item == null))
                            continue;

                        try
                        {
                            valorCampo[l] = prop.GetValue(item, null).ToString();
                        }
                        catch (Exception)
                        {
                          // irão ocorrer erros previstos  
                        }                                                      
                                                
                    }

                    // Se encontrou um valor para aquela linha adiciona na tabela
                    if (prop != null)
                        dataGrid.Rows.Add(new Object[] { valorCampo[0], valorCampo[1], valorCampo[2], valorCampo[3],
                            valorCampo[4], valorCampo[5], valorCampo[6]});
                }

                // Retorna DataTable ja preenchida
                return dataGrid;                
            }
        }

        public X RetornePeloId(int id)
        {
            using (ISession sessao = FluentySessionFactory.AbrirSessao())
            {
                using (ITransaction transacao = sessao.BeginTransaction())
                {
                    try
                    {
                        return sessao.Get<X>(id);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao obter informação   " + e.Message);
                    }

                }
            }
        }
    }
}

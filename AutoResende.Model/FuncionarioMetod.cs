using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class FuncionarioMetod
    {
        public static bool Insere(Funcionario pFuncionario)
        {
           
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Funcionarios.InsertOnSubmit(pFuncionario);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            
        }

        public static bool Deleta(string pCPF)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Funcionario oFuncionario = (from Seleciona in oDB.Funcionarios where Seleciona.CPF == pCPF select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Funcionarios.DeleteOnSubmit(oFuncionario);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
           
        }

        public static Funcionario Seleciona(int pCodigoFuncionario)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Funcionario oFuncionario = (from Seleciona in oDB.Funcionarios where Seleciona.idFuncionario == pCodigoFuncionario select Seleciona).SingleOrDefault();

            //Retorno do Funcionario
            return oFuncionario;
        }

        public static List<Funcionario> ListaFuncionarios()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<Funcionario> oFuncionarios = (from Seleciona in oDB.Funcionarios orderby Seleciona.idFuncionario select Seleciona).ToList<Funcionario>();

            //Retorno da Lista de Funcionarios
            return oFuncionarios;
        }

        public static IQueryable<Funcionario> SelecionaFuncionario(string Funcionario)
        {
            try
            {
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                IQueryable<Funcionario> oFuncionario = (from Seleciona in oDB.Funcionarios where Seleciona.Nome == Funcionario select Seleciona);
                return oFuncionario;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

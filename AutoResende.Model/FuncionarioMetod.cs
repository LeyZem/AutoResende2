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
            //Tentativa
            try
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
            //Exceção
            catch (Exception)
            {
                //Retorno FALSE para configuração de mensagem de erro
                return false;
            }
        }

        public static bool Deleta(int pCodigoFuncionario)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Funcionario oFuncionario = (from Seleciona in oDB.Funcionarios where Seleciona.idFuncionario == pCodigoFuncionario select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Funcionarios.DeleteOnSubmit(oFuncionario);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            }
            //Exceção
            catch (Exception)
            {
                //Retorno FALSE para configuração de mensagem de erro
                return false;
            }
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class FornecedorMetod
    {
        public static bool Insere(Fornecedor pFornecedor)
        {
            //Tentativa
            //try
            //{
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Fornecedors.InsertOnSubmit(pFornecedor);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            //}
            //Exceção
            //catch (Exception ex)
            //{
                //Retorno FALSE para configuração de mensagem de erro
                //throw new Exception("Um erro aconteceu ao salvar",ex);
            //}
        }

        public static bool Deleta(int pCodigoFornecedor)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Fornecedor oFornecedor = (from Seleciona in oDB.Fornecedors where Seleciona.idFornecedor == pCodigoFornecedor select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Fornecedors.DeleteOnSubmit(oFornecedor);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
           
        }

        public static Fornecedor Seleciona(int pCodigoFornecedor)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Fornecedor oFornecedor = (from Seleciona in oDB.Fornecedors where Seleciona.idFornecedor == pCodigoFornecedor select Seleciona).SingleOrDefault();

            //Retorno do Fornecedor
            return oFornecedor;
        }

        public static List<Fornecedor> ListaFornecedores()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<Fornecedor> oFornecedores = (from Seleciona in oDB.Fornecedors orderby Seleciona.idFornecedor select Seleciona).ToList<Fornecedor>();

            //Retorno da Lista de Fornecedor
            return oFornecedores;
        }
    }
}

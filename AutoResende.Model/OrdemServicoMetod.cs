using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class OrdemServicoMetod
    {
        public static bool Insere(OrdemServico pOrdemServico)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.OrdemServicos.InsertOnSubmit(pOrdemServico);
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

        public static bool Deleta(int pCodigoOrdemServico)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                OrdemServico oOrdemServico = (from Seleciona in oDB.OrdemServicos where Seleciona.idOrdemServico == pCodigoOrdemServico select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.OrdemServicos.DeleteOnSubmit(oOrdemServico);
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

        public static OrdemServico Seleciona(int pCodigoOrdemServico)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            OrdemServico oOrdemServico = (from Seleciona in oDB.OrdemServicos where Seleciona.idOrdemServico == pCodigoOrdemServico select Seleciona).SingleOrDefault();

            //Retorno da Ordem de Serviço
            return oOrdemServico;
        }

        public static List<OrdemServico> ListaOrdemServicos()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<OrdemServico> oOrdemServicos = (from Seleciona in oDB.OrdemServicos orderby Seleciona.idOrdemServico select Seleciona).ToList<OrdemServico>();

            //Retorno da Lista de Ordem de Serviço
            return oOrdemServicos;
        }
    }
}

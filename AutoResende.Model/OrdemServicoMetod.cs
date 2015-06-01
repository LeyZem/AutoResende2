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
    }
}

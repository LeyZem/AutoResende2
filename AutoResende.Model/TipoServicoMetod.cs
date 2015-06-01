using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class TipoServicoMetod
    {
        public static bool Insere(TipoServico pTipoServico)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.TipoServicos.InsertOnSubmit(pTipoServico);
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

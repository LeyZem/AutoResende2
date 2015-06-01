using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class MercadoriaMetod
    {
        public static bool Insere(Mercadoria pMercadoria)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Mercadorias.InsertOnSubmit(pMercadoria);
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

        public static bool Deleta(int pCodigoMercadoria)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Mercadoria oMercadoria = (from Seleciona in oDB.Mercadorias where Seleciona.idMercadoria == pCodigoMercadoria select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Mercadorias.DeleteOnSubmit(oMercadoria);
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

        public static Mercadoria Seleciona(int pCodigoMercadoria)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Mercadoria oMercadoria = (from Seleciona in oDB.Mercadorias where Seleciona.idMercadoria == pCodigoMercadoria select Seleciona).SingleOrDefault();

            //Retorno da Ordem de Serviço
            return oMercadoria;
        }
    }
}

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
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Mercadorias.InsertOnSubmit(pMercadoria);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            
        }

        public static bool Deleta(int pCodigoMercadoria)
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

        public static Mercadoria Seleciona(int pCodigoMercadoria)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Mercadoria oMercadoria = (from Seleciona in oDB.Mercadorias where Seleciona.idMercadoria == pCodigoMercadoria select Seleciona).SingleOrDefault();

            //Retorno da Ordem de Serviço
            return oMercadoria;
        }

        public static List<Mercadoria> ListaMercadorias()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<Mercadoria> oMercadorias = (from Seleciona in oDB.Mercadorias orderby Seleciona.idMercadoria select Seleciona).ToList<Mercadoria>();

            //Retorno da Lista de Mercadorias
            return oMercadorias;
        }
    }
}

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
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.TipoServicos.InsertOnSubmit(pTipoServico);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            
        }

        public static bool Deleta(string pNome)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                TipoServico oTipoServico = (from Seleciona in oDB.TipoServicos where Seleciona.NomeServiço == pNome select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.TipoServicos.DeleteOnSubmit(oTipoServico);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            
        }

        public static TipoServico Seleciona(int pCodigoTipoServico)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            TipoServico oTipoServico = (from Seleciona in oDB.TipoServicos where Seleciona.idTipoServico == pCodigoTipoServico select Seleciona).SingleOrDefault();

            //Retorno do Tipo de Serviço
            return oTipoServico;
        }

        public static List<TipoServico> ListaTipoServicos()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<TipoServico> oTipoServicos = (from Seleciona in oDB.TipoServicos orderby Seleciona.idTipoServico select Seleciona).ToList<TipoServico>();

            //Retorno da Lista de Tipo de Servicos
            return oTipoServicos;
        }

        public static IQueryable<TipoServico> SelecionaTipoServico(string TipoServico)
        {
            try
            {
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                IQueryable<TipoServico> oTipoServico = (from Seleciona in oDB.TipoServicos where Seleciona.NomeServiço == TipoServico select Seleciona);
                return oTipoServico;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

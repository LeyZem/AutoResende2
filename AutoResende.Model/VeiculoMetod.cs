using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class VeiculoMetod
    {
        public static bool Insere(Veiculo pVeiculo)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Veiculos.InsertOnSubmit(pVeiculo);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
           
        }

        public static bool Deleta(int pCodigoVeiculo)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Veiculo oVeiculo = (from Seleciona in oDB.Veiculos where Seleciona.idVeiculo == pCodigoVeiculo select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Veiculos.DeleteOnSubmit(oVeiculo);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
            
        }

        public static Veiculo Seleciona(int pCodigoVeiculo)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Veiculo oVeiculo = (from Seleciona in oDB.Veiculos where Seleciona.idVeiculo == pCodigoVeiculo select Seleciona).SingleOrDefault();

            //Retorno do Veiculo
            return oVeiculo;
        }

        public static List<Veiculo> ListaVeiculos()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<Veiculo> oVeiculos = (from Seleciona in oDB.Veiculos orderby Seleciona.idVeiculo select Seleciona).ToList<Veiculo>();

            //Retorno da Ordem de Serviço
            return oVeiculos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AutoResende.Model;

namespace AutoResende.Controller
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   

    public class CAutoResende : System.Web.Services.WebService
    {
        //CLIENTE
        [WebMethod]
        public static void Insere(Cliente oCliente)
        {
            ClienteMetod.Insere(oCliente);
        }

        public static Cliente SelecionaCPFCliente(string CPF)
        {
            Cliente oCliente = ClienteMetod.SelecionaCPFCliente(CPF);
            return oCliente;
        }

        public static Cliente SelecionaNomeCliente(string Nome)
        {
            Cliente oCliente = ClienteMetod.SelecionaNomeCliente(Nome);
            return oCliente;
        }




        //FORNECEDOR
        public static void Insere(Fornecedor oFornecedor)
        {
            FornecedorMetod.Insere(oFornecedor);
        }



        //FUNCIONÁRIO
        public static void Insere(Funcionario oFuncionario)
        {
            FuncionarioMetod.Insere(oFuncionario);
        }



        //MERCADORIA
        public static void Insere(Mercadoria oMercadoria)
        {
            MercadoriaMetod.Insere(oMercadoria);
        }



        //ORDEM DE SERVIÇO
        public static void Insere(OrdemServico oOrdemServico)
        {
            OrdemServicoMetod.Insere(oOrdemServico);
        }



        //TIPO DE SERVIÇO
        public static void Insere(TipoServico oTipoServico)
        {
            TipoServicoMetod.Insere(oTipoServico);
        }

        public static List<TipoServico> ListaTiposServico()
        {
            List<TipoServico> oTipoServicos = TipoServicoMetod.ListaTipoServicos();
            return oTipoServicos;
        }



        //VEÍCULO
        public static void Insere(Veiculo oVeiculo)
        {
            VeiculoMetod.Insere(oVeiculo);
        }

        public static Veiculo Seleciona (string Placa)
        {
            Veiculo oVeiculo = VeiculoMetod.Seleciona(Placa);
            return oVeiculo;
        }

    }
}

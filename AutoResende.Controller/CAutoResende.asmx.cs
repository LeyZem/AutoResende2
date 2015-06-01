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

        [WebMethod]
        public static void Insere(Cliente oCliente)
        {
            ClienteMetod.Insere(oCliente);
        }
       
        public static void Insere(Fornecedor oFornecedor)
        {
            FornecedorMetod.Insere(oFornecedor);
        }

        public static void Insere(Funcionario oFuncionario)
        {
            FuncionarioMetod.Insere(oFuncionario);
        }

        public static void Insere(Mercadoria oMercadoria)
        {
            MercadoriaMetod.Insere(oMercadoria);
        }

        public static void Insere(OrdemServico oOrdemServico)
        {
            OrdemServicoMetod.Insere(oOrdemServico);
        }

        public static void Insere(TipoServico oTipoServico)
        {
            TipoServicoMetod.Insere(oTipoServico);
        }

        public static void Insere(Veiculo oVeiculo)
        {
            VeiculoMetod.Insere(oVeiculo);
        }
    }
}

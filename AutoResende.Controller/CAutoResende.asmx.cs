using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AutoResende.Model;

namespace AutoResende.Controller
{
    
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

        public static IQueryable<Cliente> SelecionaCliente(string pCliente)
        {
            return ClienteMetod.SelecionaCliente(pCliente);
        }

        public static void DeletaCliente(string pCPF)
        {
            ClienteMetod.Deleta(pCPF);
        }



        //FORNECEDOR
        public static void Insere(Fornecedor oFornecedor)
        {
            FornecedorMetod.Insere(oFornecedor);
        }

        public static IQueryable<Fornecedor> SelecionaFornecedor(string pFornecedor)
        {
            return FornecedorMetod.SelecionaFornecedor(pFornecedor);
        }


        public static void DeletaFornecedor(string pCNPJ)
        {
            FornecedorMetod.Deleta(pCNPJ);
        }


        //FUNCIONÁRIO
        public static void Insere(Funcionario oFuncionario)
        {
            FuncionarioMetod.Insere(oFuncionario);
        }

        public static IQueryable<Funcionario> SelecionaFuncionario(string pFuncionario)
        {
            return FuncionarioMetod.SelecionaFuncionario(pFuncionario);
        }

        public static void DeletaFuncionario(string CPF)
        {
            FuncionarioMetod.Deleta(CPF);
        }



        //MERCADORIA
        public static void Insere(Mercadoria oMercadoria)
        {
            MercadoriaMetod.Insere(oMercadoria);
        }

        public static IQueryable<Mercadoria> SelecionaMercadoria(int pMercadoria)
        {
            return MercadoriaMetod.SelecionaMercadoria(pMercadoria);
        }

        public static void DeletaMercadoria(int Codigo)
        {
            MercadoriaMetod.Deleta(Codigo);
        }




        //ORDEM DE SERVIÇO
        public static void InsereOrdemServico(OrdemServico oOrdemServico)
        {
            OrdemServicoMetod.Insere(oOrdemServico);
        }


        public static void DeletaOrdemServico(int Codigo)
        {
            OrdemServicoMetod.Deleta(Codigo);
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

        public static IQueryable<TipoServico> SelecionaTipoServico(string pTipoServico)
        {
            return TipoServicoMetod.SelecionaTipoServico(pTipoServico);
        }

        public static void DeletaTipoServico(string Nome)
        {
            TipoServicoMetod.Deleta(Nome);
        }



        //VEÍCULO
        public static void Insere(Veiculo oVeiculo)
        {
            VeiculoMetod.Insere(oVeiculo);
        }

        public static Veiculo SelecionaPlacaVeiculo(string Placa)
        {
            //Veiculo oVeiculo = VeiculoMetod.Seleciona(Placa);
            Veiculo oVeiculo = VeiculoMetod.SelecionaPlacaVeiculo(Placa);
            return oVeiculo;
        }

        public static IQueryable<Veiculo> SelecionaVeiculo(string pVeiculo)
        {
            return VeiculoMetod.SelecionaVeiculo(pVeiculo);
        }

        public static void DeletaVeiculo(string Placa)
        {
            VeiculoMetod.Deleta(Placa);
        }


    }
}

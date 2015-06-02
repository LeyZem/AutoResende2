using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoResende.Model
{
    public class ClienteMetod
    {
        public static bool Insere(Cliente pCliente)
        {
           
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Clientes.InsertOnSubmit(pCliente);
                oDB.SubmitChanges();
                oDB.Dispose();

                
                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
           
        }

        public static bool Deleta(int pCodigoCliente)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Cliente oCliente = (from Seleciona in oDB.Clientes where Seleciona.idCliente == pCodigoCliente select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Clientes.DeleteOnSubmit(oCliente);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
           
        }

        public static Cliente Seleciona(int pCodigoCliente)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Cliente oCliente = (from Seleciona in oDB.Clientes where Seleciona.idCliente == pCodigoCliente select Seleciona).SingleOrDefault();

            //Retorno do Cliente
            return oCliente;
        }

        public static List<Cliente> ListaClientes()
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            List<Cliente> oClientes = (from Seleciona in oDB.Clientes orderby Seleciona.idCliente select Seleciona).ToList<Cliente>();

            //Retorno da Lista de Clientes
            return oClientes;
        }
    }
}

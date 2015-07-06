using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Linq;

namespace AutoResende.Model
{
    public class ClienteMetod
    {
        public static bool Insere(Cliente pCliente)
        {

            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.GetTable<Cliente>()
                                   where cu.CPF == pCliente.CPF
                                   select cu).SingleOrDefault();

            //Se a consulta retorna NULA ele cadastra o usuário    
            if (ConsultaUsuario == null)
            {
                try
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Bairro = pCliente.Bairro;
                    oCliente.CEP = pCliente.CEP;
                    oCliente.Cidade = pCliente.Cidade;
                    oCliente.Comentario = pCliente.Comentario;
                    oCliente.CPF = pCliente.CPF;
                    oCliente.DataNascimento = pCliente.DataNascimento;
                    oCliente.email = pCliente.email;
                    //oCliente.idCliente = pCliente.idCliente;
                    oCliente.Logradouro = pCliente.Logradouro;
                    oCliente.Nome = pCliente.Nome;
                    oCliente.OrgaoExpedidor = pCliente.OrgaoExpedidor;
                    oCliente.Pais = pCliente.Pais;
                    oCliente.RG = pCliente.RG;
                    oCliente.TelCel = pCliente.TelCel;
                    oCliente.TelRes = pCliente.TelRes;
                    oCliente.UF = pCliente.UF;

                    Table<Cliente> oClientes = ObterUsuarios();
                    oClientes.InsertOnSubmit(oCliente);
                    oClientes.Context.SubmitChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {
                try
                {
                    ConsultaUsuario.Bairro = pCliente.Bairro;
                    ConsultaUsuario.CEP = pCliente.CEP;
                    ConsultaUsuario.Cidade = pCliente.Cidade;
                    ConsultaUsuario.Comentario = pCliente.Comentario;
                    ConsultaUsuario.CPF = pCliente.CPF;
                    ConsultaUsuario.DataNascimento = pCliente.DataNascimento;
                    ConsultaUsuario.email = pCliente.email;
                    //ConsultaUsuario.idCliente = pCliente.idCliente;
                    ConsultaUsuario.Logradouro = pCliente.Logradouro;
                    ConsultaUsuario.Nome = pCliente.Nome;
                    ConsultaUsuario.OrgaoExpedidor = pCliente.OrgaoExpedidor;
                    ConsultaUsuario.Pais = pCliente.Pais;
                    ConsultaUsuario.RG = pCliente.RG;
                    ConsultaUsuario.TelCel = pCliente.TelCel;
                    ConsultaUsuario.TelRes = pCliente.TelRes;
                    ConsultaUsuario.UF = pCliente.UF;

                    oDB.SubmitChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            //Retorno TRUE para configuração de mensagem de sucesso
            return true;
        }
        public static Table<Cliente> ObterUsuarios()
        {
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //Retorno da Tabela Cliente
                return oDB.GetTable<Cliente>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Deleta(string pCPF)
        {
            
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Seleção
                Cliente oCliente = (from Seleciona in oDB.Clientes where Seleciona.CPF == pCPF select Seleciona).SingleOrDefault();

                //String de Exclusão
                oDB.Clientes.DeleteOnSubmit(oCliente);
                oDB.SubmitChanges();
                oDB.Dispose();

                //Retorno TRUE para configuração de mensagem de sucesso
                return true;
           
        }

        public static Cliente SelecionaCPFCliente(string pCliente)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Cliente oCliente = (from Seleciona in oDB.Clientes where Seleciona.CPF == pCliente select Seleciona).SingleOrDefault();

            //Retorno do Cliente
            return oCliente;
        }

        public static Cliente SelecionaNomeCliente(string pCliente)
        {
            //Conexão com o Banco de Dados
            AutoResendeDataContext oDB = new AutoResendeDataContext();

            //String de Seleção
            Cliente oCliente = (from Seleciona in oDB.Clientes where Seleciona.Nome == pCliente select Seleciona).SingleOrDefault();

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

        public static IQueryable<Cliente> SelecionaCliente(string Cliente)
        {
            try
            {
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                IQueryable<Cliente> oCliente = (from Seleciona in oDB.Clientes where Seleciona.Nome == Cliente select Seleciona);
                return oCliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoResende.Model
{
    public class ClienteMetod
    {
        public static bool Insere(Cliente pCliente)
        {
            //Tentativa
            try
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
            //Exceção
            catch (Exception)
            {
                //Retorno FALSE para configuração de mensagem de erro
                return false;
            }
        }

        public static bool Deleta(Cliente pCliente)
        {
            //Tentativa
            try
            {
                //Conexão com o Banco de Dados
                AutoResendeDataContext oDB = new AutoResendeDataContext();

                //String de Inserção
                oDB.Clientes.DeleteOnSubmit(pCliente);
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

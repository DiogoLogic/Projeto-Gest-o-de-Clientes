using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gestão_de_Clientes
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }
        static List<Cliente> clientes = new List<Cliente>();

        enum Menu {Listagem = 1, adicionar = 2, remover = 3, Sair = 4}

        static void Main(string[] args)
        {

            bool escolherSair = false;

            while (!escolherSair)
            {
                //Iniciando menu
                Console.WriteLine("Sistema de clientes - Bem vindo!\n");
                Console.WriteLine("1-Listagem\n2-adcionar\n3-remover\n4-Sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Listagem:
                        break;
                    case Menu.adicionar:
                        Adicionar();
                        break;
                    case Menu.remover:
                        break;
                    case Menu.Sair:
                            escolherSair = true;
                        break;

                }
                Console.Clear();
            }
          

        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de cliente: ");
            Console.WriteLine("Nome do cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);


            Console.WriteLine("Cadastro do cliente concluído, aperte enter para sair");
            Console.ReadLine();
        }

        
    }
}

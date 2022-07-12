using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gestão_de_Clientes
{
    internal class Program
    {
        enum Menu {Listagem = 1, adcionar = 2, remover = 3, Sair = 4}

        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de clientes - Bem vindo!\n");
            Console.WriteLine("1-Listagem\n2-adcionar\n3-remover\n4-Sair");
            Console.ReadLine();

        }
    }
}

using System;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {

        static void menu(Empresa empresa)
        {
            string op;
            Console.WriteLine("----Menu----");
            Console.WriteLine("1-Alocal funcionario a um horario");
            Console.WriteLine("Insira a opcao: ");
            op =Console.ReadLine();
            if (int.Parse(op) == 1)
            {
                empresa.alocar();
            }

        }


        static void Main(string[] args)
        {
            

            Empresa ADOSMELHORES = new Empresa();
            ADOSMELHORES.LerFicheiro();
            menu(ADOSMELHORES);

        }

            



    }
}


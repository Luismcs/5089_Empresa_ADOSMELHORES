using System;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {


        static void menu(Empresa empresa) //menu da empresa
        {
            string op;
            Console.WriteLine("----Menu----");
            Console.WriteLine("1-Mostrar lista de funcionários");
            Console.WriteLine("2-Mostrar lista de horários");
            Console.WriteLine("3-Alocar funcionario a um horario");
            Console.WriteLine("4-Mostrar gastos da Empresa");
            Console.WriteLine("5-Mostrar funcionários não alocados");
            Console.WriteLine("Insira a opcao: ");
            op = Console.ReadLine();
            Console.Clear(); //limpa a consola

            //menus de opções

            if (int.Parse(op) == 1)
            {
                empresa.imprimeFuncionarios();
                menu(empresa);
            }
            if (int.Parse(op) == 2)
            {
                empresa.imprimeHorarios();
                menu(empresa);
            }
            if (int.Parse(op) == 3)
            {
                empresa.alocar();
                menu(empresa);
            }
            if (int.Parse(op) == 4)
            {
                empresa.GastosEmpresa();
                menu(empresa);
            }
            if (int.Parse(op) == 5)
            {
                empresa.naoAlocados();
                menu(empresa);
            }


        }


        static void Main(string[] args)
        {
            Empresa ADOSMELHORES = new Empresa();
            ADOSMELHORES.LerFicheiro();
            menu(ADOSMELHORES);

        }

        //Falta alterar o tipo de horario no ficheiro de funcionarios.txt





    }





}
    


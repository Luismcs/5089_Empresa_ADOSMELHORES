using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime today = DateTime.Today; //dia
            DateTime currentDateTime = DateTime.Now; //data de hoje

            Empresa aDosMelhores = new Empresa(); //cria a empresa aDosMelhores
            Funcionario func1 = new Funcionario(1, "João", "Rua A", "111-2222", currentDateTime, currentDateTime, "Chefe1", "Área1", "Disponível", 20.5);

            aDosMelhores.AdicionarFuncionario(func1);

            // Accessing the list of Funcionarios in Empresa
            foreach (var funcionario in aDosMelhores.Funcionarios)
            {
                funcionario.ExibirInformacoes();
            }

        }
    }
}
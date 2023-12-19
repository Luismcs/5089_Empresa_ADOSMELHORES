using System;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {

     
        static void Main(string[] args)
        {
            {
                //// Declarar uma lista de Funcionário
                //List<Funcionario> funcionarios = new List<Funcionario>();

                //// Adicionar um novo funcionário à lista
                //DateTime dataHoraAtual = DateTime.Now;
                //Funcionario novoFuncionario = new Funcionario(1, "João", "RUA A", "91991919", dataHoraAtual, dataHoraAtual, "chefe1", "Area1", "Laboral", 20.5);
                //Funcionario novoFuncionario2 = new Funcionario(1, "João", "RUA A", "91991919", dataHoraAtual, dataHoraAtual, "chefe1", "Area1", "Laboral", 20.5);
                //Funcionario novoFuncionario3 = new Funcionario(1, "João", "RUA A", "91991919", dataHoraAtual, dataHoraAtual, "chefe1", "Area1", "Laboral", 20.5);

                //funcionarios.Add(novoFuncionario);
                //funcionarios.Add(novoFuncionario2);
                //funcionarios.Add(novoFuncionario3);

                //// Converter a lista de Funcionário em uma representação de texto
                //List<string> linhas = funcionarios.Select(f => f.ConverterParaTexto()).ToList();

                // Escrever a representação de texto em um arquivo
                // Verificar se o arquivo existe antes de tentar lê-lo
                Empresa ADOSMELHORES = new Empresa();
                ADOSMELHORES.LerFicheiro();
        }

            



        }
    }
}
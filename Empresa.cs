using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class FileHandler
    {
        public static void WriteToFile(string frase, string nome)
        {
            StreamWriter escrita = new StreamWriter(@"funcionarios.txt"); //cria variavel de escrita para um ficheiro
            escrita.WriteLine(frase);
            escrita.Close();
        }

        public static void ReadFromFile(string nomeficheiro)
        {
            StreamReader leitura = new StreamReader(nomeficheiro); //cria variavel de leitura para um ficheiro
            while (!leitura.EndOfStream) //Lê linhas enquanto não chegar ao fim do ficheiro de leitura
            {
                string linha = leitura.ReadLine(); //Lê a linha do ficheiro de leitura
                Console.WriteLine(linha);
            }

            leitura.Close(); //fecha a variavel de leitura
        }

    }
    internal class Empresa
    {
        private List<Funcionario> funcionarios; //cria uma lista de funcionários chamada funcionários

        public List<Funcionario> Funcionarios //get e set da lista
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }

        // Constructor
        public Empresa()
        {

            funcionarios = new List<Funcionario>();

           
            
        }

        //Método que adiciona funcionario á lista
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }


       //public void Selecao_horario()
       // {   

       //     Console.WriteLine("Qual e o funcionario que pretende selecionar?");
       //     Console.WriteLine("Escolha a opção referente ao  horário de trabalho: ");
       //     Console.WriteLine("1- Laboral - 8h-12h");
       //     Console.WriteLine("2- Ambos - 8h-12h e 14h-18h");
       //     Console.WriteLine("3- Pos-laboral 20h-24h e 2h-6h");
       //     string horario = Console.ReadLine();
       //     if (int.Parse(horario) == 1)
       //     {
       //         Console.WriteLine("Horário Laboral");
                
       //     }
       //     else if (int.Parse(horario) == 2)
       //     {
       //         Console.WriteLine("Horário Ambos");
       //     }
       //     else if (int.Parse(horario) == 3)
       //     {
       //         Console.WriteLine("Horário Pos-laboral");
       //     }
       //     else
       //     {
       //         Console.WriteLine("Horário inválido");
       //     }

            
            
       // }
       public void LerFicheiro()
        {
            if (File.Exists("funcionarios.txt"))
            {
                // Ler todas as linhas do arquivo "funcionarios.txt" e armazená-las em uma lista
                List<string> linhasArquivo = new List<string>(File.ReadAllLines("funcionarios.txt"));

                // Mostrar o conteúdo na console linha por linha
                foreach (string linha in linhasArquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("O arquivo 'funcionarios.txt' não foi encontrado.");
            }
        }
    }

    }
}

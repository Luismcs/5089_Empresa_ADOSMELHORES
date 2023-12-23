using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{

    internal class Empresa
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Horario> horarios = new List<Horario>();
        List<Funcionario> naoalocados = new List<Funcionario>();


        // Constructor
        public Empresa()
        {




        }

        //Método que adiciona funcionario á lista



        public void LerFicheiro() //lê ficheiro de funcionarios e o ficheiro de horarios
        {
            string id;
            string nome;
            string morada;
            string telefone;
            string dataFim;
            string dataRegisto;
            string isencao;
            string bonus;
            string carro;
            string chefe;
            string area;
            string disponibilidade;
            string valorHora;


            // Verificar se o arquivo existe antes de tentar lê-lo
            if (File.Exists("funcionarios.txt"))
            {
                // Usar StreamReader para ler o arquivo linha por linha
                using (StreamReader sr = new StreamReader("funcionarios.txt"))
                {
                    string linha;
                    while (!sr.EndOfStream)
                    {
                        string[] vec_fun = sr.ReadLine().Split(';'); //le a linha para um vetor
                        id = vec_fun[0];
                        nome = vec_fun[1];
                        morada = vec_fun[2];
                        telefone = vec_fun[3];
                        dataFim = vec_fun[4];
                        dataRegisto = vec_fun[5];
                        isencao = vec_fun[6];
                        bonus = vec_fun[7];
                        carro = vec_fun[8];
                        chefe = vec_fun[9];
                        area = vec_fun[10];
                        disponibilidade = vec_fun[11];
                        valorHora = vec_fun[12];
                        Funcionario funcionario = new Funcionario(id, nome, morada, telefone, dataFim, dataRegisto, isencao, bonus, carro, chefe, area, disponibilidade, valorHora); //cria um objeto funcionario
                        funcionarios.Add(funcionario); //adiciona funcionario á lista
                    }
                }
            }
            else
            {
                Console.WriteLine("O ficheiro 'funcionarios.txt' não foi encontrado.");
            }

            if (File.Exists("Horarios.txt"))
            {
                // Usar StreamReader para ler o arquivo linha por linha
                using (StreamReader sh = new StreamReader("Horarios.txt"))
                {
                    string linha;
                    string tipo;
                    while (!sh.EndOfStream)
                    {
                        string[] vec_hor = sh.ReadLine().Split(';'); //le a linha para um vetor
                        id = vec_hor[0];
                        nome = vec_hor[1];
                        tipo = vec_hor[2];
                        Horario horario = new Horario(id, nome, tipo); //cria um objeto funcionario
                        horarios.Add(horario); //adiciona funcionario á lista
                    }
                }
            }
            else
            {
                Console.WriteLine("O ficheiro 'horarios.txt' não foi encontrado.");
            }
        }

        public void adicionafun()
        {
            string nome, morada, contacto, dataFim, dataRegisto, chefe, area, disponibilidade, valorhora, isencao, bonus, carro;
            Console.WriteLine("Introduza o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Introduza a morada: ");
            morada = Console.ReadLine();
            Console.WriteLine("Introduza a data de fim de contrato: o contacto: ");
            contacto = Console.ReadLine();
            Console.WriteLine("Introduza a data de fim de contrato: ");
            dataFim = Console.ReadLine();
            Console.WriteLine("Introduza a data de fim de registo: ");
            dataRegisto = Console.ReadLine();
            Console.WriteLine("Introduza o chefe: ");
            chefe = Console.ReadLine();
            Console.WriteLine("Introduza a area: ");
            area = Console.ReadLine();
            Console.WriteLine("Disponibilidade: ");


        }

        //Exercicio2

        public void alocar() //seleciona o horario e escreve no ficheiro Horarios.txt o id o nome e o tipo de horário selecionado
        {
            string id;
            Console.WriteLine("Introduza o id do funcionário: ");
            id = Console.ReadLine();
            bool ver = false; //verificação
            string tipo = "";

            foreach (Funcionario fun in funcionarios)
            {
                if (verHorario(id))
                {
                    Console.WriteLine("Já foi atribuido um horario a este funcionário");
                    return;
                }
                if (fun.Id == id)
                {
                    ver = true;
                    Console.WriteLine("1-Pós-Laboral: ");
                    Console.WriteLine("2-Laboral: ");
                    Console.WriteLine("3-Ambas: ");
                    Console.WriteLine("Introduza o tipo de horário: ");
                    tipo = Console.ReadLine();
                    string[] vec_fun = { id + fun.Nome + tipo };          //coloca as atributos num vetor
                    Horario horario = new Horario(id, fun.Nome, tipo);   //cria um objeto horário
                    Console.Clear();

                    //Altera a designação na lista de funcionários

                    if (tipo == "1")
                    {
                        fun._Disponibilidade = "Pós-Laboral";
                    }
                    else if (tipo == "2")
                    {
                        fun._Disponibilidade = "Laboral";
                    }
                    else if (tipo == "3")
                    {
                        fun._Disponibilidade = "Ambas";
                    }

                    else //verifica se a opção é válida
                    {
                        Console.WriteLine("Introduza uma opçao válida");
                        return;
                    }

                    horarios.Add(horario);                                //adiciona horario á lista
                    string frase = fun.Id + ";" + fun.Nome + ";" + tipo;  //cria a frase a colocar no horario.txt
                    FileHandler.WriteToFile(frase, @"Horarios.txt");      //escreve a frase no horario.txt
                    copiaFuncionarios(funcionarios, @"Funcionarios.txt");
                }
            }
            if (!ver)
            {
                Console.WriteLine("O funcionário não existe!");
                return;
            }
            else
            {

                Console.WriteLine("Funcionário alocado!");
            }
        }

        public bool verHorario(string op) //verifica se o funcionário já existe na lista de horarios
        {
            foreach (Horario line in horarios)
            {
                if (op == line.Id)
                {
                    return true; //se já existir retorna true
                }
            }
            return false;
        }

        public void imprimeFuncionarios() //imprime a lista de funcionarios
        {
            // Mostrar o conteúdo na console linha por linha
            Console.WriteLine("Lista de Funcionarios:");
            foreach (Funcionario line in funcionarios)
            {
                Console.WriteLine(line.ExibirInformacoes());
            }
        }

        public void imprimeHorarios() //imprime a lista de horários
        {
            Console.WriteLine("Lista de Horarios:");

            foreach (Horario line in horarios)
            {
                Console.WriteLine(line.ExibirInformacoes());
            }
        }

        //Exercicio 3

        public void GastosEmpresa() //MARCOS
        {
            double gastos = 0.0;
            if (funcionarios != null && funcionarios.Count > 0)
            {
                foreach (Funcionario funcionario in funcionarios)
                {
                    gastos += funcionario.CalcularSalario(); //calcula o total de cada funcionário

                }
            }
            Console.WriteLine($"Os gastos da empresa são de {gastos} euros");
        }

        //Exercicio 5

        public void naoAlocados() //mostra os funcionários por alocar a um horário
        {
            string idfun;
            bool ver = false;

            foreach (Funcionario funcionario in funcionarios) //compara cada funcionario aos funcionarios que estão na lista de horários
            {
                idfun = funcionario.Id;
                ver = false;
                foreach (Horario alocado in horarios)
                {

                    if (alocado.Id == idfun)
                    {
                        ver = true; //se o fucnionario existe ver é true
                    }

                }
                if (!ver) //se o funcionario nao existe no ficheiro de horarios
                {
                    string id = funcionario.Id;
                    string nome = funcionario.Nome;
                    string frase = id + ";" + nome;
                    naoalocados.Add(funcionario);
                    FileHandler.WriteToFileReset(frase, @"NaoAlocados.txt");
                }

            }
            bool vazio = false; //verifica se a lista está vazia

            foreach (Funcionario line in naoalocados)
            {
                Console.WriteLine(line.ExibirInformacoes());
                vazio = true;
            }

            if (!vazio) //se a lista está vazia imprime a mensagem
            {
                Console.WriteLine("Lista de não alocaldos vazia");
            }
        }

        public static void copiaFuncionarios(List<Funcionario> listafuncionarios, string nomeFicheiro) //copia a lista de funcionários para o ficheiro funcionarios.txt
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(nomeFicheiro))
                {
                    foreach (Funcionario funcionario in listafuncionarios)
                    {
                        string linha = $"{funcionario.Id};{funcionario.Nome};{funcionario.Morada};{funcionario.Telefone};{funcionario._DataFim};{funcionario._DataRegisto}" +
                        $";{funcionario._Isencao};{funcionario._Bonus};{funcionario._Carro};{funcionario._Chefe};{funcionario._Area};{funcionario._Disponibilidade};{funcionario._ValorHora}";
                        sw.WriteLine(linha);
                    }
                }

                Console.WriteLine("Os dados foram atualizador no arquivo"+nomeFicheiro+"  com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao escrever no arquivo: {ex.Message}");
            }
        }
    }

}

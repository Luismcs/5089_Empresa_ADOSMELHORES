﻿using System;
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


        // Constructor
        public Empresa()
        {

            


        }

        //Método que adiciona funcionario á lista
    


       public void LerFicheiro()
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

                // Mostrar o conteúdo na console linha por linha
               Console.WriteLine("Lista de Funcionarios:");
                foreach (Funcionario line in funcionarios)
                {
                    Console.WriteLine(line.ExibirInformacoes());
                }

                
            }
            else
            {
                Console.WriteLine("O arquivo 'funcionarios.txt' não foi encontrado.");
            }
        }

        public void alocar() //seleciona o horario e escreve no ficheiro Horarios.txt o id o nome e o tipo de horário selecionado
        {
            string id;
            Console.WriteLine("Introduza o id do funcionário: ");
            id=Console.ReadLine();
            foreach (Funcionario fun in funcionarios)
            {
                if(fun.Id == id)
                {
                    Console.WriteLine("1-Pós-Laboral: ");
                    Console.WriteLine("2-Laboral: ");
                    Console.WriteLine("3-Ambas: ");
                    Console.WriteLine("Introduza o tipo de horário: ");
                    string tipo= Console.ReadLine();
                    string[] vec_fun = { id + fun.Nome+tipo };          //le a linha para um vetor
                    Horario horario = new Horario(id, fun.Nome,tipo);   //cria um objeto funcionario
                    horarios.Add(horario);                              //adiciona horario á lista
                    string frase = fun.Id+";"+fun.Nome +";"+ tipo;
                    FileHandler.WriteToFile(frase, @"Horarios.txt");

                }
            }
        }

        public void imprimeHorarios()
        {
            Console.WriteLine("Lista de Horarios:");
            foreach (Horario line in horarios)
            {
                Console.WriteLine(line.ExibirInformacoes());
            }
        }

    }
}
 
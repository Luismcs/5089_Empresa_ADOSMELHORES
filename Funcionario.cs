using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario
    {

        //atributos da classe
        public string Id { get; set; }
        public string Nome { get; set; }

        public string Morada { get; set; }
        public string Telefone { get; set; }
        public string _DataFim { get; set; }
        public string _DataRegisto { get; set; }
        public string _Isencao { get; set; }
        public string _Bonus { get; set; }
        public string _Carro { get; set; }
        public string _Chefe { get; set; }
        public string _Area { get; set; }
        public string _Disponibilidade { get; set; }
        public string _ValorHora { get; set; }

        
        //public int Id { get; set; }

        //gets e sets
        

        //Construtor
        public Funcionario(string id, string nome, string morada, string telefone,string DataFim, string DataRegisto,string isencao,string bonus,string carro,string Chefe, string Area, string Disponibilidade, string ValorHora)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            _DataFim = DataFim;
            _DataRegisto = DataRegisto;
            _Chefe = Chefe;
            _Area=Area;
            _Disponibilidade = Disponibilidade;
            _ValorHora = ValorHora;
            _Isencao = isencao;
            _Bonus = bonus;   
            _Carro = carro;  
        }

        // Método para exibir informações do funcionário
        public string  ExibirInformacoes()
        {
            return
                              $"ID: {Id}\nNome: {Nome}\nMorada: {Morada}\n" +
                              $"Contacto: {Telefone}\nFim de Contrato: {_DataFim}\n" +
                              $"Registo Criminal: {_DataRegisto}\nIsenção de Horário: {_Isencao}\n" +
                              $"Bónus Mensal: {_Bonus}\nCarro da Empresa: {_Carro}\n" +
                              $"Reporta a: {_Chefe}\nÁrea: {_Area}\nDisponibilidade: {_Disponibilidade}\n" +
                              $"Valor Hora: {_ValorHora}";
                              
        }

        public double CalcularSalario() //calcula o salário de cada funcionário //MARCOS
        {
            double salario = 0;
            double valorHora = Convert.ToDouble(_ValorHora);
            salario = (valorHora * 8)*22;
            Console.WriteLine($"O salário do funcionário {Nome} é de {salario} euros");
            return salario;


        }

    }
}

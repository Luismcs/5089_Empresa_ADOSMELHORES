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

        private int id;
        private string nome;
        private string morada;
        private string telefone;
        private DateTime dataFim;
        private DateTime dataRegisto;
        private bool isencao;
        private bool bonus;
        private bool carro;
        private string chefe;
        private string area;
        private string disponibilidade;
        private double valorHora;
        //public int Id { get; set; }

        //gets e sets
        public int Id { 
                        get { return id; } 
                        set {  id = value; } 
                      }
        public string Nome { 
                        get {  return nome; } 
                        set {  nome = value; } 
                      }
        public string Morada {
            get { return morada; }
            set { morada = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public DateTime Data_fim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }
        public DateTime Data_Registo
        {
            get { return dataRegisto; }
            set { dataRegisto = value; }
        }
        public bool Isencao
        {
            get { return isencao; }
            set { isencao = value; }
        }
        public bool Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public bool Carro
        {
            get { return carro; }
            set { carro = value; }
        }
        public string Chefe
        {
            get { return chefe; }
            set { chefe = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Disponibilidade
        {
            get { return disponibilidade; }
            set { disponibilidade = value; }
        }
        public double Valor_Hora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }

        //Construtor
        public Funcionario(int id, string nome, string morada, string telefone,DateTime DataFim, DateTime DataRegisto,string Chefe, string Area, string Disponibilidade, double ValorHora)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            this.dataFim = DataFim;
            this.dataRegisto = DataRegisto;
            chefe = Chefe;
            area=Area;
            disponibilidade = Disponibilidade;
            valorHora = ValorHora;
            Isencao = false; // valor default
            Bonus = false;   // valor default
            Carro = false;   // valor default
        }

        // Método para exibir informações do funcionário
        public void ExibirInformacoes()
        {
            Console.WriteLine(
                              $"ID: {Id}\nNome: {Nome}\nMorada: {Morada}\n" +
                              $"Contacto: {Telefone}\nFim de Contrato: {dataFim}\n" +
                              $"Registo Criminal: {dataRegisto}\nIsenção de Horário: {Isencao}\n" +
                              $"Bónus Mensal: {Bonus}\nCarro da Empresa: {Carro}\n" +
                              $"Reporta a: {Chefe}\nÁrea: {Area}\nDisponibilidade: {Disponibilidade}\n" +
                              $"Valor Hora: {valorHora}"
                              );
        }
        public string ConverterParaTexto()
        {
            return $"{Id};{Nome};{Morada};{Telefone};{dataFim};{dataRegisto};{Isencao};{Bonus};{Carro};{Chefe};{Area};{Disponibilidade};{valorHora}";
        }
    }
}

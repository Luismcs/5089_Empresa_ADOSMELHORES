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

        private string id;
        private string nome;
        private string morada;
        private string telefone;
        private string dataFim;
        private string dataRegisto;
        private string isencao;
        private string bonus;
        private string carro;
        private string chefe;
        private string area;
        private string disponibilidade;
        private string valorHora;
        //public int Id { get; set; }

        //gets e sets
        public string Id { 
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
        public string Data_fim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }
        public string Data_Registo
        {
            get { return dataRegisto; }
            set { dataRegisto = value; }
        }
        public string Isencao
        {
            get { return isencao; }
            set { isencao = value; }
        }
        public string Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public string Carro
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
        public string Valor_Hora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }

        //Construtor
        public Funcionario(string id, string nome, string morada, string telefone,string DataFim, string DataRegisto,string isencao,string bonus,string carro,string Chefe, string Area, string Disponibilidade, string ValorHora)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            dataFim = DataFim;
            dataRegisto = DataRegisto;
            chefe = Chefe;
            area=Area;
            disponibilidade = Disponibilidade;
            valorHora = ValorHora;
            Isencao = isencao;
            Bonus = bonus;   
            Carro = carro;  
        }

        // Método para exibir informações do funcionário
        public string  ExibirInformacoes()
        {
            return
                              $"ID: {Id}\nNome: {Nome}\nMorada: {Morada}\n" +
                              $"Contacto: {Telefone}\nFim de Contrato: {dataFim}\n" +
                              $"Registo Criminal: {dataRegisto}\nIsenção de Horário: {Isencao}\n" +
                              $"Bónus Mensal: {Bonus}\nCarro da Empresa: {Carro}\n" +
                              $"Reporta a: {Chefe}\nÁrea: {Area}\nDisponibilidade: {Disponibilidade}\n" +
                              $"Valor Hora: {valorHora}";
                              
        }
        
    }
}

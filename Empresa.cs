using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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

       

    }
}

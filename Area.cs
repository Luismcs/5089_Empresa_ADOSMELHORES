using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Area
    {
        public string id { get; set; } 
        public string nome { get; set; }
        public string valor { get; set; }

        public Area(string id, string nome, string area)
        {
            this.id = id;
            this.nome = nome;
            this.valor = area;
        }
        
         public string ExibirDepartamentos()
        {
            return this.id + " - " + this.nome + " - " + this.valor;
            
        }
        

    }
}

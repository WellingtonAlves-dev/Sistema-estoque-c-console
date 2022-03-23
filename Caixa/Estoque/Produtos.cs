using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produtos
    {
        static int autoIncrement = 0;
        public int id { get; } 
        private string _nome;
        private double _preco;
        public string Nome 
        {
            get => _nome;
            set 
            {
                if(value == String.Empty)
                {
                    throw new Exception("O nome do produto não pode está vázio");
                } else
                {
                    _nome = value.ToUpper();
                }
            }
        }
        public double Preco
        {
            get => Math.Round(_preco, 2);
            set
            {
                if(value > 0)
                {
                    _preco = value;
                } else
                {
                    throw new Exception("O valor do produto não pode ser igual ou menor que zero");
                }
            } 
        }
        public Produtos()
        {
            autoIncrement++;
            this.id = autoIncrement;
        }
        public override string ToString()
        {
            string template = "-------------------------------\n";
            template += $"ID: {this.id}\n";
            template += $"NOME: {this._nome}\n";
            template += $"PRECO: {this._preco}\n";
            template += "-------------------------------\n";
            return template;
        }
    }
}

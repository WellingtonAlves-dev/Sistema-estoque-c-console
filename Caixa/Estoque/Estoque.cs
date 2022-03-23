using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Estoque
    {
        private List<Produtos> produtos = new List<Produtos>();
            
        public Estoque()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("         SISTEMA ESTOQUE          ");
            Console.WriteLine("----------------------------------");
        }

        public void CadastrarProduto()
        {
            string nome;
            double valor;
            Produtos produto = new Produtos();

            Console.Write("Digite o nome do produto ");
            nome = Console.ReadLine();
            produto.Nome = nome;

            Console.Write("Digite o valor do produto ");
            string valorStr = Console.ReadLine();
            valorStr = String.IsNullOrEmpty(valorStr) ? "0.00" : valorStr;
            valor = Convert.ToDouble(valorStr.Replace(".", ","));

            produto.Preco = valor;

            Console.Write(produto.ToString());
            Console.WriteLine("Deseja salvar este produto? S (sim) ou N (não)");
            string resposta = Console.ReadLine() ?? "N";
            if (resposta.ToUpper() == "S")
            {
                this.produtos.Add(produto);
            } else
            {
                Console.WriteLine("Ação cancelada");
            }
        }
        public void ListarProdutos()
        {
            foreach (Produtos produto in this.produtos)
            {
                Console.WriteLine(produto.ToString());
            }
            Console.WriteLine("Produtos cadastrados: " + this.produtos.Count());
        }
        public void DeletarProduto()
        {
            int idProduto = 0;
            Console.Write("Digite o ID do produto: ");
            idProduto = Convert.ToInt32(Console.ReadLine());
            foreach(Produtos produto in produtos)
            {
                if(produto.id == idProduto)
                {
                    produtos.Remove(produto);
                    Console.WriteLine("Produto removido com sucesso");
                    break;
                }
            }
        }
    }
}

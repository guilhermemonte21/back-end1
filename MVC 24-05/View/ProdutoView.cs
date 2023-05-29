using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_24_05.Model;

namespace MVC_24_05.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
             //método para exibir os dados da lista no console
         void Listar(List<Produto> produtos)
        {
            Console.WriteLine($"\nLista de produtos");
            Console.WriteLine(produtos.Count());

            foreach (var produto in produtos)
            {
                Console.WriteLine(@$"
                Código: {produto.Codigo}
                Nome: {produto.Nome}
                Preço: {produto.Preco:C2}");

            }
        }
         Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"\nPágina de cadastro");
            Console.WriteLine($"\nDigite o código:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"\nDigite o nome:");
            novoProduto.Nome = Console.ReadLine();
            Console.WriteLine($"\nDigite o preço:");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;

        }
    }
}
}

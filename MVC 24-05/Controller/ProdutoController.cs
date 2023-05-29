using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_24_05.Model;
using MVC_24_05.View;
namespace MVC_24_05.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //chamada da Model trazendo a lista
            List<Produto> produtos = produto.Ler();

            //chamada da View passandoa a lista
            produtoView.Listar(produtos);

        }
        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();
            produto.Inserir(novoProduto);
        }
    }
}
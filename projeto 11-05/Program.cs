// instancia do objeto carrinho
using projeto_11_05;
Carrinho carrinho = new Carrinho();

//instanciar objeto(s) da classe Produto
Produto p1 = new Produto(1,"GTA V", 52.90f);
Produto p2 = new Produto(2,"Fifa 23", 120.50f);
Produto p3 = new Produto(3,"God of War", 100.00f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Apos a remoção");

carrinho.Remover(p2);
carrinho.Remover(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

//criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "The Last of Us";
_novoProduto.Preço = 199.99f;

carrinho.Atualizar(1,_novoProduto);
carrinho.Listar();
carrinho.TotalCarrinho();



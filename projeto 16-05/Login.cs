using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_16_05
{
    public class Login
    {
        public bool Logado { get; set; }
        public void Log()
        {
            //Aqui vai a logica
            Usuario user = new Usuario();
            //Validar se esta logado
            Logar(user);
            if(Logado==true)
            {
                GerarMenu();
            }
        }
        public void Logar (Usuario usuario)
        {
            Console.WriteLine($"Informe o email:");
            string emailDigitado= Console.ReadLine();

            Console.WriteLine($"Informe a senha:");
            string senhaDigitada= Console.ReadLine();

            if(emailDigitado == usuario.Email && senhaDigitada == usuario.Senha)
            {
                   
            }

            
            

         }
        public void Deslogar() { }
        public void GerarMenu() { 
            Produto produto = new Produto();
            Marca marca = new Marca();
            do{
            Console.WriteLine($@"
            [1] - Cadastrar Produto
            [2] - Listar Produto
            [3] - Remover Produto
            ------------------------
            [4] - Cadastrar Marca
            [5] - Listar Marca
            [6] - Remover Marca
            
            [0] - Sair");
            string opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                produto.Cadastrar();
                break;
                case "2" :
                produto.Listar();
                break;
                case "3": 
                Console.WriteLine($"Informe o codigo a ser excluido:");
                int codigo= int.Parse(Console.ReadLine());
                produto.Deletar(codigo);
                break;
                case "4":
                marca.Cadastrar();
                break;
                case "5":
                marca.Listar();
                break;
                case "6":
                Console.WriteLine($"Informe o codigo a ser excluido");
                int CodigoMarca= int.Parse(Console.ReadLine());
                marca.Deletar(CodigoMarca);
                break;
                
                
            }
            }while(true);
            
         }
    }
}
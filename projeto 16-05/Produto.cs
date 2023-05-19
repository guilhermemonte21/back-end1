using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_16_05
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public Usuario CadastradoPor { get; set; }
        List<Produto> listaProdutos = new List<Produto>();
        public Produto(){}
        public Produto(int _code, string _nome, float _price){
                Codigo=_code;
            NomeProduto=_nome; 
           Preco= _price;
        }
         
        public void Cadastrar(){
            Console.WriteLine($"Digite codigo");
            int _code = int.Parse(Console.ReadLine());

            listaProdutos.Add(new Produto(Codigo, NomeProduto, Preco));
        }
       
        public void Listar() 
        { 
              if (listaProdutos.Count > 0)
            {
                foreach (Produto p in listaProdutos)
                {
                    Console.WriteLine(@$"
                    Codigo : {p.Codigo}
                    Nome : {p.NomeProduto}
                    Preco : {p.Preco:c2}");

                }

            }
         }
        public void  Deletar(int Codigo){
            listaProdutos.Remove(new Produto(Codigo, NomeProduto, Preco));
          }
    }

}
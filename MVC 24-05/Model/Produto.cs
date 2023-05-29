using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_24_05.Model
{
    public class Produto
    {
        //Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo csv
        private const string PATH="Database/Produto.csv";


        public Produto()
        {
            //criar a logica para gerar a pasta e o arquivo

            //obter o caminho da pasta
           string pasta =  PATH.Split("/")[0];
            //verificar se no caminho ja existe uma pasta
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            //verificar se no caminho existe um arquivo
            if (!File.Exists(PATH)){
                File.Create(PATH);
            }        
          }
        //Metodo para ler os dados no arquivo csv
          public List<Produto> Ler()
          {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");
                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);
            }


            return produtos;
          }
           public string PrepararLinhasCsv(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

       
        public void Inserir(Produto p)
        {
            string[] linhas = { PrepararLinhasCsv(p) };

            File.AppendAllLines(PATH, linhas);
        }

    }
}
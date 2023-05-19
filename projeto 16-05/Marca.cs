using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_16_05
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public float Precop { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> listaMarcas = new List<Marca>();
        public Marca(){}
        public Marca(int code, string name, float prize)
        {
            Codigo = code;
            NomeMarca = name;
            Precop = prize;

        }

        public void Cadastrar()
        {

           

            Console.WriteLine($"Digite codigo");
            int code = int.Parse(Console.ReadLine());

            listaMarcas.Add(new Marca(Codigo, NomeMarca, Precop));
        }
        public void Listar()
        {
            if (listaMarcas.Count > 0)
            {
                foreach (Marca p in listaMarcas)
                {
                    Console.WriteLine(@$"
                    Codigo : {p.Codigo}
                    Nome : {p.NomeMarca}
                    Preco : {p.Precop:c2}");

                }

            }
        }
        public void Deletar(int Codigo)
        {
            listaMarcas.Remove(new Marca(Codigo, NomeMarca, Precop));
        }
    }
}
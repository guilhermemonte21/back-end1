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
        public DateTime DataCadastro { get; set; }
        List<Marca> listaMarcas = new List<Marca>();

        public void Cadastrar()
         { 
            //Aqui a logica
          }
        public void Listar() { }
        public void Deletar(int Codigo) 
        {
        }
    }
}
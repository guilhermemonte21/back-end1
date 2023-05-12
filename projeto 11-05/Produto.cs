using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_11_05
{
    public class Produto
    {

        //propriedades
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preço { get; set; }


        //construtores
        public Produto()
        {
        }
        public Produto(int _codigo,string _nome, float _preço)
        {
            Codigo=_codigo;
            Nome=_nome;
            Preço=_preço;
        }
    }
}
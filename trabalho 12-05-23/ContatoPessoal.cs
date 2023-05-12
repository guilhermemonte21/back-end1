using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trabalho_12_05_23
{
    public class ContatoPessoal:Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public void ValidarCpf(string _cpf)
        {
            
        }
    }
}
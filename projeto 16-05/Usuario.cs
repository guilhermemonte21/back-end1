using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_16_05
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar( )
         { 
            this.Nome = "Guilherme";
            this.Email = "admin@email.com";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;



         }
         public void Deletar() {
            this.Nome = "";
            this.Email= "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
         }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_11_05
{
    public interface ICarrinho
    {
        //regras do "Contrato"\
        //metodos que deverão aqui ser declarados apenas

        //CRUD : Create, Read , Update, Delete

        //Padrão de chamada de metodos
        //tipo Nome(parametros)

        //Create
        void Adicionar(Produto _produto);
        //Read
        void Listar();
        //Update
        void Atualizar(int _codigo, Produto _produto);
        //Delete
        void Remover(Produto _produto);
    }
}
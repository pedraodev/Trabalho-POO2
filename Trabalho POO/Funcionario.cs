using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class Funcionario
    {
        public string Nome { get; set; }

        //método que tem como função retornar o nome do usuário

        public double CPF { get; set; }
        
        //Atributo que tem como função retornar o CPF do usuário

        public string Endereço { get; set; }
        
        //Atributo que tem como função retornar o Endereço do usuário

        public string matricula { get; set; }
        
        //Atributo que tem como função retornar a matricula do usuário

        public string cargo { get; set; }
        
        //Atributo que tem como função retornar o cargo do usuário
        public string informacoesbasicas() 
        {
            return Nome + matricula + cargo;
        }
        
        //Método que tem como função retornar as informações básicas do Funcionário no demonstrativo simples

        public string infocompleta()
        {
            return Nome + CPF + Endereço + matricula + cargo;
        }
        
        //Método que tem como função retornar as informações completas do Funcionário no demonstrativo completo

    }
}

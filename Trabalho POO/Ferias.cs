using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO;

namespace Trabalho_POO
{
    internal class Ferias
    {        
        public double calcularferias { get; set; }
        public double soma_ferias { get; set; }
        public double adicionar_desconto_ferias()
        {
            return 0;
        }
        public double Tirar_Ferias()
        {

            double salario, total_ferias, soma_ferias;
            salario = 0;
            total_ferias = (1.0 / 3.0) * (salario / 3.0);
            soma_ferias = total_ferias + salario;

            calcularferias = soma_ferias;

            return Tirar_Ferias();

        }

        
        /*
         isso foi o que eu substitui pelo código de cima
        public Ferias() <- isso aqui é um construtor,
        por isso Ferias estava em verde,
        se for essa a forma correta, deleta o que ta em cima, e volta esse aqui
{

    double salario, total_ferias, soma_ferias;
    salario = 0;
    total_ferias = (1.0 / 3.0) * (salario / 3.0);
    soma_ferias = total_ferias + salario;

    calcularferias = soma_ferias;

}*/
        public double calculo_ferias()
        {
            return calcularferias;
        }
        public string analise_das_ferias { set; get; }
        public string solicitarferias()
        {
            return analise_das_ferias;
            
        }
    }
}




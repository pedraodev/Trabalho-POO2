using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class salariomes
    {
        
        public double valorhora { get; set; }
        public double horastrabalhadas { get; set; }

        public double valorsalario()
        {
            return valorhora * horastrabalhadas;
        }

        public double DescontoINSS()
        {
            double salario = valorsalario();
            double descontoINSS;

            if (salario <= 1320)
            {
                descontoINSS = 0;
            }
            else if (salario < 2571.29)
            {
                descontoINSS = salario * 0.9;
            }
            else if (salario < 3856.95)
            {
                descontoINSS = salario * 0.12;
            }
            else
            {
                descontoINSS = salario * 0.14;
            }
                        
            return descontoINSS;
        }

        public double salarioliquido()
        {
            double salario = valorsalario();
            double descontoINSS = DescontoINSS();
            double salarioLiquido = salario - descontoINSS;

            return salarioLiquido;
        }
    }

}

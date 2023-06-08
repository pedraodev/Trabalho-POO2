using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO
{
    internal class lucroBI
    {

        public int n_vendas_pelo_funcionario { set; get; }
        public double lucros_por_venda_funcionario { set; get; }
        public int metas_venda_mes { set; get; }
            
        public string consultar_vendas()
        {
            string positivo_ou_negativo, retorno_lucrativo;
            if (n_vendas_pelo_funcionario > metas_venda_mes)
            {
                positivo_ou_negativo = "Funcionario lucrativo para empresa";
            } else
            {
                positivo_ou_negativo = "Funcionario não lucrou para empresa";
            }
            retorno_lucrativo = positivo_ou_negativo;

            return retorno_lucrativo;
        }
        public int mes_anterior { set; get; }
        public double lucro_mes_passado { set; get; }
        public double lucro_venda_mes { set; get; }
        public string consulta_passada()
        {
            string retorno_demissao_ou_aumento_de_venda;
            string funcionario_decaiu;

            if (lucro_mes_passado < lucro_venda_mes)
            {
                funcionario_decaiu = "O funcionario decaiu as vendas!";
            }
            else
            {
                funcionario_decaiu = "o funcionario vendeu mais que mês anterior!";
            }
            retorno_demissao_ou_aumento_de_venda = funcionario_decaiu;

            return retorno_demissao_ou_aumento_de_venda;


        }
    }
}

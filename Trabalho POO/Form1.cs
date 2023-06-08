using System.Windows.Forms;
using System.Globalization;

namespace Trabalho_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            salariomes salariomes = new salariomes();
                        
            double  horas, valor;

            valor = double.Parse(txtvalor.Text);
            horas = double.Parse(txthora.Text);

            salariomes.valorhora = valor;
            salariomes.horastrabalhadas = horas;

            double salariomensal = salariomes.valorsalario();
            double Desconto = salariomes.DescontoINSS();
            double salarioLiquido = salariomes.salarioliquido();
            double resultado;

            resultado = salarioLiquido - Desconto;

            txtresultado.Text = resultado.ToString("C");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtresultado_Click(object sender, EventArgs e)
        {
           
            //matricula = txtcargo;

            
            //txtresultado.Text = btnnome.Text;
            //txtresultado.Text = btnmatricula.Text;
            //txtresultado.Text = btncargo.Text;
        }

        private void btndecimo_Click(object sender, EventArgs e)
        {
            decimoterceiro decimo = new decimoterceiro();
            salariomes rsalario = new salariomes();

            double valorhora = double.Parse(txtvalor.Text);
            double horastrabalhadas = double.Parse(txthora.Text);
                        
            rsalario.valorhora = valorhora;
            rsalario.horastrabalhadas = horastrabalhadas;

            double salariol = rsalario.valorsalario();
            double dterceiro = double.Parse(txtmeses.Text);

            decimo.salarioliquido = salariol;
            decimo.mesestrabalhados = dterceiro;

            double resultdecimo = decimo.calculodecimo();

            lblrdecimo.Text = resultdecimo.ToString("C");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncompleto_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            salariomes rsalario = new salariomes();
            decimoterceiro rdecimo = new decimoterceiro();
            Ferias rferias = new Ferias();
            lucroBI rlucro = new lucroBI();

            string nome, matricula, cargo;
            

            funcionario.Nome = txtnome.Text;
            funcionario.matricula = txtmatricula.Text;
            funcionario.cargo = txtcargo.Text;

            /*double salarioc = double.Parse(txtresultado.Text);
            double decimoc = double.Parse(txtmeses.Text);
            double feriasc = double.Parse(txtferias.Text);
            double lucroc = double.Parse(txtlucro.Text);
            vou arrumar esse erro aqui depois
            salarioc.ToString("C");
            */

            nome = txtnome.Text;
            matricula = txtmatricula.Text;
            cargo = txtcargo.Text;

            //txtresultado.Text = nome;
            //txtresultado.Text += matricula;
            //txtresultado.Text += cargo;

            txtcompleto.Text = "Funcionário: " + nome + ", Matricula: " + matricula + " ,Com o cargo: " + cargo + ",Com o salario de: ";
        }

        private void btnferias_Click(object sender, EventArgs e)
        {
            /*aqui você precisa criar um construtor salariomes,
            e retornar o valor para calcular as ferias em cima do txt hora, valor 
            para isso, cria um double com o nome de uma variavel,
            que recebe double.Parse que é a conversão(txthora)
            exemplo: double horasalario = double.Parse(txthora.Text) <- isso converte uma txt em tipo double
            e depois criar uma para o valor das horas igual o exemplo acima,
            se você ver o décimo terceiro, está assim, depois é só retornar o valor em: txtferias.Text 
            Não se esqueça que o resultado disso só é feito, depois de clicar em btnlucro,
            por isso está dentro dessa caixa de texto
            idéia: o lucro será salario liquido - o valor que retornará da txtlucro,
            aparecendo o resultado em lbllucro,
            tenta assim, acho que dá certo
            Se você observar o decimo, vai ver que é basicamente daquela forma que faz as férias,
            e o lucroBi, é bem simples, nas férias tem que ter uma conta igual a do decimo, mas divido por 30,
            lembre-se disse, existe funcionário que tira 5,7,10 dias
             */
            Ferias ferias = new Ferias();
            
            ferias.solicitarferias();
            double total_ferias;
            total_ferias = ferias.calculo_ferias();
         //   lblrferias.Text = soma_ferias.ToString();


            // double salario,total_ferias, soma_ferias;
            //  salario = double.Parse(txtresultado.Text);
            // total_ferias = (1.0 / 3.0) * (salario / 3.0);
            //soma_ferias = total_ferias + salario;
            //lblrferias.Text = soma_ferias.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblrferias_Click(object sender, EventArgs e)
        {
           
        }
    }
}
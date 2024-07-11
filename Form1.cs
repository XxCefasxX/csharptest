namespace Practicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string snum1 = tb_num1.Text;
                string snum2 = tb_num2.Text;
                if (snum1 != "" && snum2 != "")
                {
                    int numero1 = Convert.ToInt32(snum1);
                    int numero2 = Convert.ToInt32(snum2);
                    int resultado = numero1 + numero2;

                    lb_resultado.Text = resultado.ToString();
                }
                else
                {
                    lb_resultado.Text = "Hay campos sin valor";
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }

        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            try
            {
                string snum1 = tb_num1.Text;
                string snum2 = tb_num2.Text;
                if (snum1 != "" && snum2 != "")
                {
                    int numero1 = Convert.ToInt32(snum1);
                    int numero2 = Convert.ToInt32(snum2);
                    int resultado = numero1 - numero2;

                    lb_resultado.Text = resultado.ToString();
                }
                else
                {
                    lb_resultado.Text = "Hay campos sin valor";
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string snum1 = tb_num1.Text;
                string snum2 = tb_num2.Text;
                if (snum1 != "" && snum2 != "")
                {
                    decimal numero1 = Convert.ToDecimal(snum1);
                    decimal numero2 = Convert.ToDecimal(snum2);
                    decimal resultado = numero1 + numero2;

                    lb_resultado.Text = resultado.ToString();
                }
                else
                {
                    lb_resultado.Text = "Hay campos sin valor";
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tb_num1.Text);
            int resutado = numero;

            int potencia = Convert.ToInt32(tb_num2.Text);

            for (int p = 0; p < potencia; p++)
            {
                resutado = resutado * numero;
            }
            lb_resultado.Text = resutado.ToString();
        }
    }
}

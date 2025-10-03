namespace CalculadoraBase
{
    public partial class Form1 : Form
    {
        double v1, v2, resp;
        bool virgula = false;
        int operacao = 0, limite = 27;

        public object TextBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "1";
        }

        private void bvirgula_Click(object sender, EventArgs e)
        {
            if (!virgula)
            {
                if (string.IsNullOrEmpty(display.Text))
                {
                    display.Text = display.Text + "0,";
                    virgula = true;
                }
                else
                {
                    display.Text = display.Text + ",";
                    virgula = true;
                }

            }
        }

        private void bsoma_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 1;
                    v1 = Double.Parse(display.Text);
                    //textBox1.Text = textBox1.Text + v1.ToString() + " +";
                    textBox1.Text = v1.ToString() + " +";
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }
            }
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            if (operacao == 1)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 + v2;
                display.Text = resp.ToString();
                textBox1.Text = v1.ToString() + " + " + v2.ToString() + " =";
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
            if (operacao == 2)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 - v2;
                display.Text = resp.ToString();
                textBox1.Text = v1.ToString() + " - " + v2.ToString() + " =";
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
            if (operacao == 3)
            {
                v2 = Double.Parse(display.Text);
                if (v2 == 0)
                {
                    textBox1.Text = "";
                    display.Font = new Font(textBox1.Font.FontFamily, 15, FontStyle.Bold);
                    display.TextAlign = HorizontalAlignment.Left;
                    limite = 40;
                    display.Text = "Não é possível dividir por zero";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Button)
                        {
                            if (ctrl.Text != "C")
                            {
                                ctrl.Enabled = false;
                            }

                        }
                    }
                }
                else
                {
                    resp = v1 / v2;
                    display.Text = resp.ToString();
                    textBox1.Text = v1.ToString() + " ÷ " + v2.ToString() + " =";
                }

                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
            if (operacao == 4)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 * v2;
                display.Text = resp.ToString();
                textBox1.Text = v1.ToString() + " × " + v2.ToString() + " =";
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
            if (operacao == 5)
            {
                v2 = Double.Parse(display.Text);
                resp = Math.Pow(v1, v2);
                display.Text = resp.ToString();
                textBox1.Text = v1.ToString() + " ^ " + v2.ToString() + " =";
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
            if (operacao == 6)
            {
                v2 = Double.Parse(display.Text);
                if (v2 == 0)
                {
                    textBox1.Text = "";
                    display.Font = new Font(textBox1.Font.FontFamily, 15, FontStyle.Bold);
                    display.TextAlign = HorizontalAlignment.Left;
                    limite = 40;
                    display.Text = "Não é possível dividir por zero";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Button)
                        {
                            if (ctrl.Text != "C")
                            {
                                ctrl.Enabled = false;
                            }

                        }
                    }
                }
                else
                {
                    resp = v1 % v2;
                    display.Text = resp.ToString();
                    textBox1.Text = v1.ToString() + " mod " + v2.ToString() + " =";

                }

                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            textBox1.Text = "";
            virgula = false;
            limite = 27;
            v1 = 0;
            v2 = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Enabled = true;
                }
            }
            display.Font = new Font(textBox1.Font.FontFamily, 40, FontStyle.Regular);
            display.TextAlign = HorizontalAlignment.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "2";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            ///****************************** tirar zeros a esquerda
            if (string.IsNullOrEmpty(display.Text) && string.IsNullOrEmpty(textBox1.Text))
            {
                display.Text = "";
            }
            else
            {
                if (display.Text == "0")
                {
                    display.Text = "0";
                }
                else
                {
                    display.Text = display.Text + "0";
                }

            }

        }

        public void zero_a_esquerda()
        {
            if (!string.IsNullOrEmpty(display.Text) && display.Text[0] == '0' && display.Text[1] != ',')
            {
                display.Text = display.Text.TrimStart(display.Text[0]);
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            zero_a_esquerda();
            display.Text = display.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 2;
                    v1 = Double.Parse(display.Text);
                    textBox1.Text = v1.ToString() + " -";
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }

            }

            if (string.IsNullOrEmpty(display.Text) && string.IsNullOrEmpty(textBox1.Text))
            {
                display.Text = "-";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 3;
                    v1 = Double.Parse(display.Text);
                    textBox1.Text = v1.ToString() + " ÷";
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 4;
                    v1 = Double.Parse(display.Text);
                    textBox1.Text = v1.ToString() + " ×";
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }
            }
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

            if (limite == 27)
            {
                if (display.Text.Length > limite)
                {
                    display.Text = display.Text.Substring(0, limite) + "...";
                }
            }


            if (display.Text.Length <= 6)
            {
                display.Font = new Font(textBox1.Font.FontFamily, 40, FontStyle.Regular);
            }
            else if (display.Text.Length >= 7 && display.Text.Length <= 9)
            {
                display.Font = new Font(textBox1.Font.FontFamily, 30, FontStyle.Regular);
            }
            else if (display.Text.Length >= 10 && display.Text.Length <= 16)
            {
                display.Font = new Font(textBox1.Font.FontFamily, 20, FontStyle.Regular);
                if (display.Text.Length >= 14)
                {
                    display.TextAlign = HorizontalAlignment.Left;
                }
                else
                {
                    display.TextAlign = HorizontalAlignment.Right;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                v1 = Double.Parse(display.Text);
                textBox1.Text = "√" + v1.ToString() + " =";
                resp = Math.Sqrt(v1);
                display.Text = resp.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 5;
                    v1 = Double.Parse(display.Text);
                    textBox1.Text = v1.ToString() + " ^ ";
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                v1 = Double.Parse(display.Text);
                textBox1.Text = "log(" + v1.ToString() + ") =";
                resp = Math.Log10(v1);
                display.Text = resp.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 6;
                    v1 = Double.Parse(display.Text);
                    textBox1.Text = v1.ToString() + " mod";
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                v1 = Double.Parse(display.Text);
                textBox1.Text = "Sin (" + v1.ToString() + ") =";
                double radiano = v1 * Math.PI / 180;
                resp = Math.Sin(radiano);
                display.Text = resp.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                v1 = Double.Parse(display.Text);
                textBox1.Text = "Abs (" + v1.ToString() + ") =";
                resp = Math.Abs(v1);
                display.Text = resp.ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(display.Text))
            {
                //display.Text = display.Text.TrimEnd(display.Text[display.Text.Length - 1]);
                display.Text = display.Text.Substring(0, display.Text.Length - 1); ;
                textBox1.Text = "";
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double mudar = Double.Parse(display.Text);

            display.Text = (mudar * -1).ToString();
        }
    }
}

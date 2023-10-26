namespace FirstApp
{
    public partial class Form1 : Form
    {
        double? store;//previous number in memory, dik ? mn b3d stype bach n9dr nrj3ha null
        char op;//operator (+ - * / =)

        public Form1()
        {
            InitializeComponent();
        }

        private void clickDigit(String digit)
        {
            if (checkLength())
            {
                if (Screen.Text == "0")
                {
                    Screen.Text = digit;
                }
                else
                {
                    Screen.Text += digit;
                }
            }
        }

        private void clickOp(char op)
        {
            if (prevNum.Text == "0")
            {
                store = double.Parse(Screen.Text);
                prevNum.Text = Screen.Text;
                this.op = op;
                Screen.Text = "0";
            }
            else if (op == '=')
            {
                operate(this.op, double.Parse(Screen.Text));
                Screen.Text = store.ToString();
                prevNum.Text = "0";
                store = null;
            }
            else
            {
                operate(this.op, double.Parse(Screen.Text));
                this.op = op;
                Screen.Text = "0";
                prevNum.Text = store.ToString();
            }
        }

        private void operate(char op, double operand)
        {
            double result = 0;
            switch (op)
            {
                case '+':
                    store += operand;
                    break;
                case '-':
                    store -= operand;
                    break;
                case 'x':
                    store *= operand;
                    break;
                case '/':
                    store /= operand;
                    break;
            }
        }

        private bool checkLength()
        {
            return Screen.Text.Length < 14 ? true : false;
        }

        private void digit_1_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }
        private void digit_2_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_3_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_4_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_5_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_6_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_7_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_8_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_9_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void digit_0_Click(object sender, EventArgs e)
        {
            clickDigit(((Button)sender).Text);
        }

        private void op_c_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            prevNum.Text = "0";
        }

        private void op_delete_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "0" && Screen.Text.Length > 1)
            {
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
            }
            else if (Screen.Text != "0" && Screen.Text.Length == 1)
            {
                Screen.Text = "0";
            }
        }

        private void digit_comma_Click(object sender, EventArgs e)
        {
            if (!Screen.Text.Contains(","))
            {
                if (Screen.Text == "-")
                {
                    Screen.Text += "0";
                }
                Screen.Text += ",";        
            }
        }

        private void op_sub_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "-";
            }
            else
            {
                clickOp(((Button)sender).Text.ToCharArray()[0]);
            }
        }

        private void op_add_Click(object sender, EventArgs e)
        {
            clickOp(((Button)sender).Text.ToCharArray()[0]);
        }

        private void op_mult_Click(object sender, EventArgs e)
        {
            clickOp(((Button)sender).Text.ToCharArray()[0]);
        }

        private void op_div_Click(object sender, EventArgs e)
        {
            clickOp(((Button)sender).Text.ToCharArray()[0]);
        }

        private void op_equals_Click(object sender, EventArgs e)
        {
            clickOp(((Button)sender).Text.ToCharArray()[0]);
        }
    }
}
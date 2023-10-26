namespace FirstApp
{
    public partial class Form1 : Form
    {
        List<double> numberStack = new List<double>();
        List<char> operators = new List<char>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void clickOp(String op)
        {
            numberStack.Add(double.Parse(Screen.Text));
            Screen.Text = "0";
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
                Screen.Text += ",";
            }
        }
    }
}
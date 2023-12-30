using calculatorApp.CalFunctionality;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        char sign;
        double lastvalue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = "";
            Result.Text = CalculatorServices.SetTextToResultlabel("2", buttonvalue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("5", buttonvalue);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("4", buttonvalue);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("6", buttonvalue);

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("3", buttonvalue);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("7", buttonvalue);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("8", buttonvalue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = "";
            Result.Text = CalculatorServices.SetTextToResultlabel("1", buttonvalue);

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string buttonvalue = Result.Text.ToString();
            buttonvalue = buttonvalue.Trim();
            Result.Text = CalculatorServices.SetTextToResultlabel("9", buttonvalue);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            double currentvalue = Convert.ToDouble(Result.Text);
            sign = '+';
            lastvalue = CalculatorServices.Equal(currentvalue, lastvalue, sign);
            label1.Text = lastvalue.ToString();
            Result.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double currentvalue = Convert.ToDouble(Result.Text);
            sign = '-';
            lastvalue = CalculatorServices.Equal(currentvalue, lastvalue, sign);
            label1.Text = lastvalue.ToString();
            Result.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double currentvalue = Convert.ToDouble(Result.Text);
            sign = '/';
            lastvalue = CalculatorServices.Equal(currentvalue, lastvalue, sign);
            label1.Text = lastvalue.ToString();
            Result.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double currentvalue = Convert.ToDouble(Result.Text);
            sign = 'X';
            lastvalue = CalculatorServices.Equal(currentvalue, lastvalue, sign);
            label1.Text = lastvalue.ToString();
            Result.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lastvalue = 0;
            Result.Text = "";
            label1.Text = "";

        }
    }

}
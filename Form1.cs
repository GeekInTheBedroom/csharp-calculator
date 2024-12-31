using System.Data;

namespace csharp_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool CanUsePoint = true;
        public static void AddOperator(TextBox textBox, char operatorChar)
        {
            if (textBox.Text != string.Empty)
            {
                if (char.IsNumber(textBox.Text[textBox.Text.Length - 1]))
                {
                    textBox.Text += operatorChar;
                    CanUsePoint = true;
                }
            }
        }

        #region Adding numbers to TextBox
        private void ButtonNumber0_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '0';
        }

        private void ButtonNumber1_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '1';
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '2';
        }

        private void ButtonNumber3_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '3';
        }

        private void ButtonNumber4_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '4';
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '5';
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '6';
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '7';
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '8';
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            TextBoxProblem.Text += '9';
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (TextBoxProblem.Text != string.Empty && CanUsePoint != false)
            {
                TextBoxProblem.Text += '.';
                CanUsePoint = false;
            }
        }
        #endregion
        #region Adding operators to TextBox
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddOperator(TextBoxProblem, '+');
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            AddOperator(TextBoxProblem, '-');
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            AddOperator(TextBoxProblem, '×');
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            AddOperator(TextBoxProblem, '÷');
        }
        #endregion

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            string ReplacedSymbolProblem = TextBoxProblem.Text.Replace('×', '*').Replace('÷', '/');
            DataTable table = new DataTable();
            TextBoxProblem.Text = (Convert.ToDouble(table.Compute(ReplacedSymbolProblem, string.Empty))).ToString();
        }
    }
}

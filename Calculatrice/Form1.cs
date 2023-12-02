namespace Calculatrice
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

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 1;
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 2;
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 3;
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 4;
        }

        private void btn5_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 5;
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 6;
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 7;
        }

        private void btn8_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 8;
        }

        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 9;
        }

        private void btn0_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + 0;
        }

        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = "";

        }
    }
}

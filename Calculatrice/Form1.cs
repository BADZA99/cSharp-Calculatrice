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

        // variable qui sauvegarde l'operateur
        string operateur;
        float number1;
        float number2;



        // fonctions pour afficher les nombres dans le champ
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

        // fonction qui ajoute le point 
        private void btnDot_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = textField.Text + ",";
        }

        // fonction qui clear le champ
        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            textField.Text = "";

        }

     

        // fonctions qui affectent l'operateur
        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            string a = textField.Text;
            // essaie de convertir a en float si true elle sera stocke dans number1
            float.TryParse(a, out number1);
            textField.Text = "";
            operateur = "+";

        }

        private void btnSous_MouseClick(object sender, MouseEventArgs e)
        {
            string a=textField.Text;
            // essaie de convertir a en float si true elle sera stocke dans number1
            float.TryParse(a,out number1);
            textField.Text = "";
            operateur = "-";

        }

        private void btnMulti_MouseClick(object sender, MouseEventArgs e)
        {
            string a = textField.Text;
            // essaie de convertir a en float si true elle sera stocke dans number1
            float.TryParse(a, out number1);
            textField.Text = "";
            operateur = "*";

        }

        private void btnDiv_MouseClick(object sender, MouseEventArgs e)
        {

            string a = textField.Text;
            // essaie de convertir a en float si true elle sera stocke dans number1
            float.TryParse(a, out number1);
            textField.Text = "";
            operateur = "/";

        }



        //  les fonctions qui permettent d'effectuer les operations 

        private void btnEgal_MouseClick(object sender, MouseEventArgs e)
        {
            string b = textField.Text;
            float.TryParse(b, out number2);
            if (operateur == "+")
            {
            //  convertir en float le resultat et l'afficher
            float result= number1-number2;
            textField.Text = result.ToString();
            }
            else if (operateur == "-")
            {
                textField.Text = (number1 - number2).ToString();
            }
            else if (operateur == "*")
            {
                textField.Text = (number1 * number2).ToString();
            }
            else if (operateur == "/")
            {
                textField.Text = (number1 / number2).ToString();
            }
        }
    }
}

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string id = "kullan�c�1";
        string password = "sifre1";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)   
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == id && textBox2.Text == password)
            {
                MessageBox.Show("Giri� Ba�ar�l�");
            }
            else
            {
                MessageBox.Show("Giri� Bilgileriniz Hatal�!");
            }
        }
    }
}
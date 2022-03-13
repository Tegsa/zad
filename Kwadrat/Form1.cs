namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = (float.Parse(textBox1.Text) * float.Parse(textBox1.Text) -4 * float.Parse(textBox2.Text) * float.Parse(textBox3.Text)).ToString();
           float delta = float.Parse(textBox4.Text);
            if (delta > 0)
            {
                textBox6.Text = "dodatnia";
                
            }else if (delta < 0)
            {
                textBox6.Text = "ujemna";
            }
            else if (delta == 0)
            {
               textBox6.Text = "zero";
            }
              
            textBox7.Text = (((float.Parse(textBox1.Text) * (-1)) + (float)Math.Sqrt(delta)) / 2 * float.Parse(textBox2.Text)).ToString();
            textBox8.Text = (((float.Parse(textBox1.Text) * (-1)) - (float)Math.Sqrt(delta)) / 2 * float.Parse(textBox2.Text)).ToString();

        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
namespace Final_Project_Me_No._1
{
    public partial class Form1 : Form
    {
        Authentication auth = new Authentication();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Username pls");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password pls");
                textBox2.Focus();
            }
            else if (textBox1.Text != "123" || textBox2.Text != "123")
            {
                MessageBox.Show("wrong username or password pls try again");
                textBox2.Focus();
                textBox2.SelectAll();
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool success = auth.Login(username, password);
            if (success)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("√À— ºË“πÀ√◊ÕUsername ‰¡Ë∂Ÿ°µ«≈");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }  
}

using MySql.Data.MySqlClient;

namespace Login_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=123456;database=test";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string stm = "Select name, password from log WHERE name =@Name AND Password=@password";
                var cmd = new MySqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@Name", username_txt);
                cmd.Parameters.AddWithValue("@Name", pwd_txt.Text);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login Successful!");
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Login Gagal");
            }
            con.Close();
        }

        private void Form2_form(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Close();
        }

    }
}

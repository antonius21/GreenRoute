namespace GreenRoute
{
    public partial class Form1 : Form
    {
        private User[] users = new User[]
        {
            new User(01,"Anton","Antonio21","12345678"),
            new User(02,"Max","Max21","87654321")
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 && textBox2.TextLength == 0)
            {
                MessageBox.Show("Ввведіть данні");
            }
            else 
            {
                User user = users.FirstOrDefault(u=>u.Login==textBox1.Text && u.Password== textBox2.Text);
                if (user != null) 
                {
                    MessageBox.Show("Доброго дня"+user.Name);
                }
                else
                {
                    MessageBox.Show("Немає такого користувача");
                }

            }
        }
    }
}

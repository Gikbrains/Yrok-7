using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            public class form1: form
            {
            public string globalUsername = "Batman";
            public string globalPassword = "batmobil";
            public Form1()
            {
                InitializeComponent();
            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }
            private void button1_Click(object sender, EventArgs e)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                if (username == globalUsername && password == globalPassword)
                {
                    MessageBox.Show("Login granted, awesome !");
                }
                else
                {
                    MessageBox.Show("Login denied, check your credentials !");
                }
                

                
            }

            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ST4CY_Login_Tool
{
    public partial class Copy : Form
    {
        public Copy()
        {
            InitializeComponent();
            Process.Start("https://discord.gg/dhb6YeM");
        }

        private void Copy_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("JS Copied!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("login('" + textBox1.Text + "')");
            MessageBox.Show("Login Copied!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
    }
}

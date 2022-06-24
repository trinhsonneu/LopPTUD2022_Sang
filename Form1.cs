using System;
using System.Windows.Forms;

namespace LopPTUD2022_Sang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với lập trình C#!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

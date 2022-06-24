using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopPTUD2022_Sang
{
    public partial class frmLTCoBan : Form
    {
        int i, n, T;
        public frmLTCoBan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            i = 1;
            while (i<=n)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            lblKQ.Text = "Kết quả tính theo While là:" + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n) ;
            lblKQ.Text = "Kết quả tính theo Do While là:" + Convert.ToString(T);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
(e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) ==
13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            for (i=1;i<=n;i++)
            {
                if (i % 2==0)
                {
                    T = T + i;
                }    
            }
            lblKQ.Text = "Kết quả tính theo For là:" + Convert.ToString(T);
        }
    }
}

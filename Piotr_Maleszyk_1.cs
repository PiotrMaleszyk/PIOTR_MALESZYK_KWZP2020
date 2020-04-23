using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_change_me.Enabled = false;
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckB_wl_wyl_CheckedChanged(object sender, EventArgs e)
        {
            btn_change_me.Enabled = ckB_wl_wyl.Checked;
        }

        private void btn_change_me_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {
            if (Txt1.TextLength > 0)
            {
                btn_change_me.Text = Txt1.Text;
            }
        }
    
    }
}

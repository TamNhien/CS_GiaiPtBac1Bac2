using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_GiaiPtBac1Bac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txta.ResetText();
            txtb.ResetText();
            txtc.ResetText();
            lsKQ.Items.Clear();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = false;
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = true;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c;
            lsKQ.Items.Clear();
            if (rd1.Checked)
            {
                PTBac1 nhien = new PTBac1();
                a = double.Parse(txta.Text);
                b = double.Parse(txtb.Text);
                lsKQ.Items.Add(nhien.GiaiPTBac1(a, b));
            }
            
            if (rd2.Checked)
            {
                PTBac2 nhien = new PTBac2();
                a = double.Parse(txta.Text);
                b = double.Parse(txtb.Text);
                c = double.Parse(txtc.Text);
                lsKQ.Items.Add(nhien.GiaiPTBac2(a, b, c));
            }
        }
    }
}

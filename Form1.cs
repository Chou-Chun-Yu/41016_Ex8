using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_Ex8
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            try
            {
                int xStart, yStart, xEnd, yEnd;
                xStart = Convert.ToInt32(tb_xStart.Text);
                yStart = Convert.ToInt32(tb_yStart.Text);
                xEnd = Convert.ToInt32(tb_xEnd.Text);
                yEnd = Convert.ToInt32(tb_yEnd.Text);
                             
                if (xStart > xEnd || yStart > yEnd)
                {
                    MessageBox.Show("起始值要小於終止值!!!");
                }
                if (yStart == Convert.ToInt32(tb_yStart.Text))
                {
                    tb_result.Text += "X/Y" + "\t";
                    for (; yStart <= yEnd; yStart++)
                    {
                        tb_result.Text += yStart + "\t";
                    }
                    tb_result.Text += "\r\n";
                }           
                for (; xStart <= xEnd; xStart++)
                {
                    tb_result.Text += xStart + "\t";
                    for (yStart = Convert.ToInt32(tb_yStart.Text); yStart <= yEnd; yStart++)
                    {
                        tb_result.Text += yStart + "*" + xStart + "=" + xStart * yStart + "\t";
                    }
                    tb_result.Text += "\r\n";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

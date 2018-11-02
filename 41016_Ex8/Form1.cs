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
                string result = "";   
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
                    result += "X/Y" + "\t";
                    for (; yStart <= yEnd; yStart++)
                    {
                        result += yStart + "\t";
                    }
                    result += "\r\n";
                }           
                for (; xStart <= xEnd; xStart++)
                {
                    result += xStart + "\t";
                    for (yStart = Convert.ToInt32(tb_yStart.Text); yStart <= yEnd; yStart++)
                    {
                        result += yStart + "*" + xStart + "=" + xStart * yStart + "\t";
                    }
                    result += "\r\n";
                }
                tb_result.Text = result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

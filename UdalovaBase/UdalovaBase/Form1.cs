using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdalovaBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String l = "Admin";
            String p = "Admin";
            
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                Form2 dlg = new Form2();
                dlg.Show(this);
            }
            else
            {
                Error dlg = new Error();
                dlg.Show(this);
            }
        }
    }
}

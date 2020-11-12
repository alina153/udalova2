using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        

        private string FilePath;

        public string filename;

        public bool isFileChanged;

        public Form1()
        {
            InitializeComponent();
            init();
            
        }

        public void init()

        {

            filename = "";

            isFileChanged = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            filename = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())

            {

                if (dialog.ShowDialog() == DialogResult.OK)

                {

                    FilePath = dialog.FileName;

                    textBox1.Text = File.ReadAllText(FilePath);

                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))

            {

                using (SaveFileDialog dialog = new SaveFileDialog())

                {

                    if (dialog.ShowDialog() == DialogResult.OK)

                    {

                        FilePath = dialog.FileName;

                        File.WriteAllText(FilePath, textBox1.Text);

                    }

                }
            }

            File.WriteAllText(FilePath, textBox1.Text);

        }



        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())

            {

                if (dialog.ShowDialog() == DialogResult.OK)

                {

                    FilePath = dialog.FileName;

                    File.WriteAllText(FilePath, textBox1.Text);

                }

            }
        }

        private void pageParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

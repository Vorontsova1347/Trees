using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trees;

namespace TaskTrees
{
    public partial class Form1 : Form
    {
        Tree tree;
        public Form1()
        {
            InitializeComponent();
        }


        private void RandomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tree = new Tree(int.Parse(DepthTBox.Text));
                Graphics gr;
                gr = pictureBox.CreateGraphics();
                gr.Clear(Color.White);
                tree.DrawBinTree(gr, 10, pictureBox.Width - 10, 5, 75);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

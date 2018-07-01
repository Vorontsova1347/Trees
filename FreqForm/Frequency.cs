using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trees;

namespace FreqForm
{
    public partial class Frequency : Form
    {
        public Frequency()
        {
            InitializeComponent();
        }

        Trees.Frequency words; 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                List<string> ss = new List<string>();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                    s = streamReader.ReadToEnd();
                    ss = new List<string>(s.Split(new char[] { ' ', ' ', '\n', '\r', ',', '.', '(', ')', ':', ';', '[', ']', '}', '{' },
                                          StringSplitOptions.RemoveEmptyEntries));
                }
                words = new Trees.Frequency(ss);
                dataGridView = words.ConvertTreeToDGV(dataGridView);
            }
            catch(IOException ex)
            {
                MessageBox.Show("I/O exception");
            }
            catch
            {
                MessageBox.Show("Just error");
            }
        }
    }
}

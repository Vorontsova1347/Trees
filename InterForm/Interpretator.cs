using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interpretator;

namespace WindowsFormsApp2
{
    public partial class Inter : Form
    {
        Interpretator.Interpretator interpretator = new Interpretator.Interpretator();
        public Inter()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = "";
            ErrorTB.Text = "";
            try
            {
                AnswerTB.Text = Convert.ToString(interpretator.Inter(InputTB.Text));
            }
            catch (Interpretator.Interpretator.InputError)
            {
                AnswerTB.Text = "ERROR!";
                List<int> list = interpretator.GetPointError;
                for (int i = 0; i < list.Count; i++)
                {
                    ErrorTB.Text += Convert.ToString(list[i]) + " ";
                }
            }
        }

    }
}

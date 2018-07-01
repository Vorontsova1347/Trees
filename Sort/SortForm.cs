using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortLibrary;

namespace Sort
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }
        SortLibrary.Point[] Points;
        private void buttonVozr_Click(object sender, EventArgs e)
        {
            Points = ConvertTextBoxToPoints.ConvertToPoints(textBoxPoints);
            SortLibrary.Sort.SortInsertPoints(Points, true);
            textBoxPoints.Lines = SortLibrary.ConvertTextBoxToPoints.ConvertToStringArr(Points);
        }

        private void buttonUbiv_Click(object sender, EventArgs e)
        {
            Points = ConvertTextBoxToPoints.ConvertToPoints(textBoxPoints);
            SortLibrary.Sort.SortInsertPoints(Points, false);
            textBoxPoints.Lines = SortLibrary.ConvertTextBoxToPoints.ConvertToStringArr(Points);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152_Coursework
{
    public partial class frmEditYear : Form
    {
        // Declaring variables.
        Year[] arrayOfYears;

        public frmEditYear()
        {
            InitializeComponent();
        }



        // Update the form, every time it's opened.
        public void Update_EditTextboxes()
        {
            arrayOfYears = Data.locations[frmMain.selectedLocation].GetYears();
            txtBoxEditDescription.Text = arrayOfYears[frmMain.selectedYear].GetYearDescription();
        }

        // When Save button is clicked.
        private void btnSaveYear_Click(object sender, EventArgs e)
        {
            arrayOfYears[frmMain.selectedYear].SetYearDescription(txtBoxEditDescription.Text);
            Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtBoxEditDescription.Text = arrayOfYears[frmMain.selectedYear].GetYearDescription();
        }
    }
}

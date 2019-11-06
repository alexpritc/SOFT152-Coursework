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
    public partial class frmEditLocation : Form
    {

        public frmEditLocation()
        {
            InitializeComponent();
        }



        // Update the form, every time it's opened.
        public void Update_EditTextboxes()
        {
            txtBoxName.Text = Data.locations[frmMain.selectedLocation].GetLocationName();
            txtBoxStreetNumberAndName.Text = Data.locations[frmMain.selectedLocation].GetStreetNumberAndName();
            txtBoxCounty.Text = Data.locations[frmMain.selectedLocation].GetCounty();
            txtBoxPostcode.Text = Data.locations[frmMain.selectedLocation].GetPostcode();
            txtBoxLatitude.Text = Data.locations[frmMain.selectedLocation].GetLatitude().ToString();
            txtBoxLongitude.Text = Data.locations[frmMain.selectedLocation].GetLongitude().ToString();
        }


        // When back button is clicked.
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        // When Revert Changes button is clicked.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = Data.locations[frmMain.selectedLocation].GetLocationName();
            txtBoxStreetNumberAndName.Text = Data.locations[frmMain.selectedLocation].GetStreetNumberAndName();
            txtBoxCounty.Text = Data.locations[frmMain.selectedLocation].GetCounty();
            txtBoxPostcode.Text = Data.locations[frmMain.selectedLocation].GetPostcode();
            txtBoxLatitude.Text = Data.locations[frmMain.selectedLocation].GetLatitude().ToString();
            txtBoxLongitude.Text = Data.locations[frmMain.selectedLocation].GetLongitude().ToString();
        }

        // When save button is clicked.
        public void btnSave_Click(object sender, EventArgs e)
        {
            Data.locations[frmMain.selectedLocation].SetLocationName(txtBoxName.Text);
            Data.locations[frmMain.selectedLocation].SetStreetNumberAndName(txtBoxStreetNumberAndName.Text);
            Data.locations[frmMain.selectedLocation].SetCounty(txtBoxCounty.Text);
            Data.locations[frmMain.selectedLocation].SetPostcode(txtBoxPostcode.Text);
            Data.locations[frmMain.selectedLocation].SetLatitude(txtBoxLatitude.Text);
            Data.locations[frmMain.selectedLocation].SetLongitude(txtBoxLongitude.Text);

            Hide();
       
        }

    }
}

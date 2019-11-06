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
    public partial class frmAddLocation : Form
    {
        // Declaring variables.
        string locationName, streetNumberAndName, county, postcode, latitude,
               longitude;



        public frmAddLocation()
        {
            InitializeComponent();
        }



        // When the form loads, clear all the text boxes.
        public void Update_EditTextboxes()
        {
            txtBoxName.Clear();
            txtBoxStreetNumberAndName.Clear();
            txtBoxCounty.Clear();
            txtBoxPostcode.Clear();
            txtBoxLatitude.Clear();
            txtBoxLongitude.Clear();
        }

        // When the save button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            locationName = txtBoxName.Text;
            streetNumberAndName = txtBoxStreetNumberAndName.Text;
            county = txtBoxCounty.Text;
            postcode = txtBoxPostcode.Text;
            latitude = txtBoxLatitude.Text;
            longitude = txtBoxLongitude.Text;


            // Create new location.
            Location newLocation = new Location(locationName, streetNumberAndName, county, postcode, latitude, longitude);

            // Add location to Array.
            Data.AddLocationToArray(ref Data.locations, newLocation);

            // Adds number of years to a separate array.
            Data.AddNumberOfYearsToArray(ref Data.numberOfYearsArray, "0");

            // Increase number of lcoations by 1.
            NumberOfLocations();

            // Hide form.
            Hide();
        }

        // When the reset button is clicked.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxStreetNumberAndName.Clear();
            txtBoxCounty.Clear();
            txtBoxPostcode.Clear();
            txtBoxLatitude.Clear();
            txtBoxLongitude.Clear();
        }

        // When the cancel button is clicked.
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }



        // Add 1 to the number of locations in file.
        private void NumberOfLocations()
        {
            int intNumberOfLocations = Convert.ToInt32(Data.numberOfLocations);
            intNumberOfLocations++;
            Data.numberOfLocations = Convert.ToString(intNumberOfLocations);
        }
    }
}

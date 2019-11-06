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
    public partial class frmAddYear : Form
    {

        // Declaring variables.
        string name, streetNumberAndName, county, postcode, latitude, longitude;

        int numberOfYearsInLocation;


        public frmAddYear()
        {
            InitializeComponent();
        }



        // Update the text boxes whenever the form is loaded up.
        public void Update_EditTextboxes()
        {
            txtBoxYear.Clear();
            txtBoxYearDescription.Clear();
        }



        // When the save button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            string year, yearDescription;

            // Get the new year details.
            year = txtBoxYear.Text;
            yearDescription = txtBoxYearDescription.Text;

            // Change the number of years for the location.
            numberOfYearsInLocation = Convert.ToInt32(Data.numberOfYearsArray[frmMain.selectedLocation]);
            numberOfYearsInLocation++;
            Data.numberOfYearsArray[frmMain.selectedLocation] = Convert.ToString(numberOfYearsInLocation);

            Data.years = null;
            for (int i = 0; i < numberOfYearsInLocation; i++)
            {
                // Get the details of the selected location.
                GetCurrentLocationDetails();

                // Create months.
                CreateMonths();

                // Make a new temp year.
                Year newYear = new Year(year, yearDescription, Data.months);

                // Add Year to Array.
                Data.AddYearToArray(ref Data.years, newYear);

            }

            // Make a new location.
            Location newLocation = new Location(name, streetNumberAndName, county, postcode, latitude, longitude, Data.years);

            // Override the old location.
            Data.locations[frmMain.selectedLocation] = newLocation;

            Hide();
        }

        // When the reset button is clicked.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxYear.Clear();
            txtBoxYearDescription.Clear();
        }

        // When the back button is clicked.
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }



        // Create empty months.
        public void CreateMonths()
        {
            int monthID = 1;

            Data.months = null;
            for (int i = 0; i < 12; i++)
            {
                string monthIDNumber = Convert.ToString(monthID), maximumTemperature = "999", minimumTemperature = "999",
                   numberOfDaysOfAirFrost = "999", millimetresOfRainfall = "999", hoursOfSunshine = "999";

                MonthlyObservations newMonth = new MonthlyObservations(monthIDNumber, maximumTemperature, minimumTemperature,
                numberOfDaysOfAirFrost, millimetresOfRainfall, hoursOfSunshine);

                Data.AddMonthToArray(ref Data.months, newMonth);

                monthID++;
            }
        }



        // Get the details of the currently selected location.
        public void GetCurrentLocationDetails()
        {
            name = Data.locations[frmMain.selectedLocation].GetLocationName();
            streetNumberAndName = Data.locations[frmMain.selectedLocation].GetStreetNumberAndName();
            county = Data.locations[frmMain.selectedLocation].GetCounty();
            postcode = Data.locations[frmMain.selectedLocation].GetPostcode();
            latitude = Data.locations[frmMain.selectedLocation].GetLatitude().ToString();
            longitude = Data.locations[frmMain.selectedLocation].GetLongitude().ToString();
        }
    }
}

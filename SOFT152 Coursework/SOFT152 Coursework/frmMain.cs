using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SOFT152_Coursework
{
    public partial class frmMain : Form
    {
        // Delcaring variables.

        /// <summary>
        /// Directory of opened file.
        /// </summary>
        public static string fileName;

        /// <summary>
        /// Name of the file, without the extension.
        /// </summary>
        public string uiFileName;

        /// <summary>
        /// Converted MonthID into a readable month.
        /// </summary>
        public string monthAsString;

        /// <summary>
        /// Index of current selected Location.
        /// </summary>
        public int selectedLocation;

        /// <summary>
        /// Index of current selected Year.
        /// </summary>
        public int selectedYear;

        /// <summary>
        /// Index of the current selected Month.
        /// </summary>
        public int selectedMonth;

        /// <summary>
        /// All the years in the current selected Location.
        /// </summary>
        Year[] currentLocationsYears;

        /// <summary>
        /// All the months in the current selected Location.
        /// </summary>
        MonthlyObservations[] currentYearsMonths;



        public frmMain()
        {
            InitializeComponent();
        }



        // File --> Open...
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File opened at: " + theDialog.FileName.ToString());
                fileName = theDialog.FileName.ToString();
            }

            if (fileName != null)
            {
                // Read in the data from the chosen file.
                Data.ReadLocations();

                // Updates the UI.
                LoadItemsInto_ComboBoxLocations();
                Update_FileLoaded();
            }
        }

        // Tools --> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }



        // Clears and re-enters details the information from
        // Data.ReadLocations into the Locations ComboBox.
        private void LoadItemsInto_ComboBoxLocations()
        {
            comboBoxLocations.Items.Clear();

            foreach (Location locationItem in Data.locations)
            {
                comboBoxLocations.Items.Add(locationItem.GetLocationName() + ", " 
                                            + locationItem.GetPostcode() + ".");
            }
        }

        // Clears and re-enters details the information from
        // GetYear() into the Years ComboBox.
        private void LoadItemsInto_ComboBoxYears(int selectedLocation)
        {
            comboBoxYears.Items.Clear();

            currentLocationsYears = Data.locations[selectedLocation].GetYears();

            foreach (Year yearItem in currentLocationsYears)
            {
                comboBoxYears.Items.Add(yearItem.GetYear() + ".");
            }
        }

        // Clears and re-enters details the information from
        // GetMonths() into the Months ComboBox.
        private void LoadItemsInto_ComboBoxMonths(int selectedYear)
        {
            comboBoxMonths.Items.Clear();

            currentYearsMonths = currentLocationsYears[selectedYear].GetMonths();

            foreach (MonthlyObservations monthItem in currentYearsMonths)
            {
                int currentMonth = Convert.ToInt32(monthItem.GetMonthIDNumber());
                MakeMonthIDReadable(currentMonth);

                comboBoxMonths.Items.Add(monthAsString);
            }
        }



        // Converts the MonthID into a readable string format.
        private void MakeMonthIDReadable(int currentMonth)
        {
            switch (currentMonth)
            {
                case 1:
                    monthAsString = "January";
                    break;
                case 2:
                    monthAsString = "February";
                    break;
                case 3:
                    monthAsString = "March";
                    break;
                case 4:
                    monthAsString = "April";
                    break;
                case 5:
                    monthAsString = "May";
                    break;
                case 6:
                    monthAsString = "June";
                    break;
                case 7:
                    monthAsString = "July";
                    break;
                case 8:
                    monthAsString = "August";
                    break;
                case 9:
                    monthAsString = "September";
                    break;
                case 10:
                    monthAsString = "October";
                    break;
                case 11:
                    monthAsString = "November";
                    break;
                case 12:
                    monthAsString = "December";
                    break;

            }
        }



        // Updates the file loaded, without the directory or extension.
        // Updates the number of locations in file.
        private void Update_FileLoaded()
        {
            uiFileName = Path.GetFileNameWithoutExtension(fileName);
            lblFileLoaded.Text = uiFileName;
            lblNumberOfLocationsInFile.Text = "NO. Locations in File: " + Data.numberOfLocations;
        }

        // Updates the location details.
        private void Update_LocationDetails(int selectedLocation)
        {
            lblLocationLoaded.Text = Data.locations[selectedLocation].GetLocationName() + ", "
                                   + Data.locations[selectedLocation].GetPostcode() + ".";

            lblAddressDATA.Text = Data.locations[selectedLocation].GetLocationName() + ", "
                       + Data.locations[selectedLocation].GetStreetNumberAndName() + ", "
                       + Data.locations[selectedLocation].GetCounty() + ", "
                       + Data.locations[selectedLocation].GetPostcode() + ".";

            lblCoordinatesDATA.Text = "(" + Data.locations[selectedLocation].GetLatitude() + ", "
                                  + Data.locations[selectedLocation].GetLongitude() + ")";

            lblNumberOfYearsInLocationDATA.Text = Data.numberOfYearsArray[selectedLocation];
        }

        // Updates the year details.
        private void Update_YearDetails(int selectedYear)
        {
            lblYearSelected.Text = currentLocationsYears[selectedYear].GetYear();

            lblYearDATA.Text = currentLocationsYears[selectedYear].GetYear();

            lblYearDescriptionDATA.Text = currentLocationsYears[selectedYear].GetYearDescription();
        }

        // Updates the month details.
        private void Update_MonthDetails(int selectedMonth)
        {
            lblMonthSelected.Text = comboBoxMonths.SelectedItem.ToString();

            lblMonthDATA.Text = currentYearsMonths[selectedMonth].GetMonthIDNumber();

            lblMaximumTemperatureDATA.Text = currentYearsMonths[selectedMonth].GetMaximumTemperature().ToString();

            lblMinimumTemperatureDATA.Text = currentYearsMonths[selectedMonth].GetMinimumTemperature().ToString();

            lblNumberOfDaysOfAirfrostDATA.Text = currentYearsMonths[selectedMonth].GetNumberOfDaysOfAirFrost().ToString();

            lblMillimetresOfRainfallDATA.Text = currentYearsMonths[selectedMonth].GetMillimetresOfRainfall().ToString();

            lblHoursOfSunshineDATA.Text = currentYearsMonths[selectedMonth].GetHoursOfSunshine().ToString();

        }

        // Clears the location details.
        private void Clear_LocationDetails()
        {
            lblLocationLoaded.Text = "N/A";

            lblAddressDATA.Text = "N/A";

            lblCoordinatesDATA.Text = "N/A";

            lblNumberOfYearsInLocationDATA.Text = "N/A";
        }

        // Clears the year details.
        private void Clear_YearDetails()
        {
            lblYearSelected.Text = "No Year Selected";

            lblYearDATA.Text = "N/A";

            lblYearDescriptionDATA.Text = "N/A";
        }

        // Clears the month details.
        private void Clear_MonthDetails()
        {
            lblMonthSelected.Text = "No Month Selected";

            lblMonthDATA.Text = "N/A";

            lblMaximumTemperatureDATA.Text = "N/A";

            lblMinimumTemperatureDATA.Text = "N/A";

            lblNumberOfDaysOfAirfrostDATA.Text = "N/A";

            lblMillimetresOfRainfallDATA.Text = "N/A";

            lblHoursOfSunshineDATA.Text = "N/A";
        }



        // Gets the index when a new location is selected,
        // and loads the years from that selected location into the
        // Years ComboBox.
        // It clears and then updates the UI.
        private void comboBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxYears.Items.Clear();
            comboBoxMonths.Items.Clear();

            Clear_LocationDetails();
            Clear_YearDetails();
            Clear_MonthDetails();

            selectedLocation = comboBoxLocations.SelectedIndex;

            LoadItemsInto_ComboBoxYears(selectedLocation);
            Update_LocationDetails(selectedLocation);
        }

        // Gets the index when a new year is selected,
        // and loads the months from that selected year into the
        // Months ComboBox.
        // It clears and then updates the UI.
        private void comboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMonths.Items.Clear();

            Clear_MonthDetails();

            selectedYear = comboBoxYears.SelectedIndex;

            LoadItemsInto_ComboBoxMonths(selectedYear);
            Update_YearDetails(selectedYear);
        }

        // Gets the index when a new month is selected,
        // It updates the UI.
        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = comboBoxMonths.SelectedIndex;

            Update_MonthDetails(selectedMonth);
        }

    }
}

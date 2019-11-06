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
        /// The inputted text that the user is using to
        /// filter through results.
        /// </summary>
        public string textToSearchFor;



        /// <summary>
        /// Index of current selected Location.
        /// </summary>
        public static int selectedLocation = -1;

        /// <summary>
        /// Index of current selected Year.
        /// </summary>
        public static int selectedYear = -1;

        /// <summary>
        /// Index of the current selected Month.
        /// </summary>
        public static int selectedMonth = -1;



        /// <summary>
        /// Checks if the selected location index is not -1.
        /// </summary>
        bool isValidSelectedLocation = true;

        /// <summary>
        /// Checks if the selected Year index is not -1.
        /// </summary>
        bool isValidSelectedYear = true;

        /// <summary>
        /// Checks if the selected Month index is not -1.
        /// </summary>
        bool isValidSelectedMonth = true;



        /// <summary>
        /// All the years in the current selected Location.
        /// </summary>
        Year[] currentLocationsYears;

        /// <summary>
        /// All the months in the current selected Location.
        /// </summary>
        MonthlyObservations[] currentYearsMonths;



        /// <summary>
        /// An array of locations, filtered by the search results.
        /// </summary>
        Location[] filteredLocations = null;

        /// <summary>
        /// An array of years, filtered by the search results.
        /// </summary>
        Year[] filteredYears = null;

        /// <summary>
        /// An array of months, filtered by the search results.
        /// </summary>
        MonthlyObservations[] filteredMonths = null;



        /// <summary>
        /// Instance of frmAbout.
        /// </summary>
        frmAbout aboutForm = new frmAbout();

        /// <summary>
        /// Instance of frmEditLocation.
        /// </summary>
        frmEditLocation editLocationForm = new frmEditLocation();

        /// <summary>
        /// Instance of frmEditYear.
        /// </summary>
        frmEditYear editYearForm = new frmEditYear();

        /// <summary>
        /// Instance of frmEditMonth.
        /// </summary>
        frmEditMonth editMonthForm = new frmEditMonth();

        /// <summary>
        /// Instance of frmAddLocation.
        /// </summary>
        frmAddLocation addLocationForm = new frmAddLocation();

        /// <summary>
        /// Instance of frmAddYear.
        /// </summary>
        frmAddYear addYearForm = new frmAddYear();

        /// <summary>
        /// Instance of frmLocationAnalysis.
        /// </summary>
        frmLocationAnalysis locationAnalysisForm = new frmLocationAnalysis();

        /// <summary>
        /// Instance of frmYearAnalysis.
        /// </summary>
        frmYearAnalysis yearAnalysisForm = new frmYearAnalysis();



        public frmMain()
        {
            InitializeComponent();
        }



        // File --> New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_All();
            Data.ClearData();

            fileName = "Untitled";

            lblFileLoaded.Text = fileName;            
        }

        // File --> Open...
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = theDialog.FileName.ToString();
            }

            if (fileName != null)
            {
                Clear_All();
                Data.ClearData();

                // Read in the data from the chosen file.
                Data.ReadLocations();

                // Updates the UI.
                LoadItemsInto_ComboBoxLocations();
                Update_FileLoaded();
            }
        }

        // File --> Save As...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = theDialog.FileName.ToString();
            }
            if (fileName != null)
            {
                // Saves the data.
                Data.SaveLocations();
                Update_FileLoaded();
            }

        }

        // File --> Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Read in the data from the chosen file.
            Data.SaveLocations();

        }

        // File --> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tools --> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }



        // Clears and re-enters details the information from
        // Data.ReadLocations into the Locations ComboBox.
        public void LoadItemsInto_ComboBoxLocations()
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
        public void LoadItemsInto_ComboBoxYears(int selectedLocation)
        {
            comboBoxYears.Items.Clear();

            if (Data.locations[selectedLocation].GetYears() != null)
            {
                currentLocationsYears = Data.locations[selectedLocation].GetYears();

                if (currentLocationsYears != null)
                {
                    foreach (Year yearItem in currentLocationsYears)
                    {
                        comboBoxYears.Items.Add(yearItem.GetYear() + ".");
                    }
                }
            }

        }   

        // Clears and re-enters details the information from
        // GetMonths() into the Months ComboBox.
        public void LoadItemsInto_ComboBoxMonths(int selectedYear)
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
            if (fileName == null)
            {
                lblFileLoaded.Text = "No File Loaded";
            }
            else
            {
                lblFileLoaded.Text = uiFileName;
            }

            if (Data.numberOfLocations != null)
            {
                lblNumberOfLocationsInFile.Text = "NO. Locations in File: " + Data.numberOfLocations;
            }
            else
            {
                lblNumberOfLocationsInFile.Text = "NO. Locations in File: N/A";
            }
        }

        // Updates the location details.
        public void Update_LocationDetails(int selectedLocation)
        {
            if (selectedLocation < Data.locations.Length)
            {
                lblLocationLoaded.Text = Data.locations[selectedLocation].GetLocationName() + ", "
                                  + Data.locations[selectedLocation].GetPostcode() + ".";

                lblAddressDATA.Text = Data.locations[selectedLocation].GetLocationName() + ", "
                           + Data.locations[selectedLocation].GetStreetNumberAndName() + ", "
                           + Data.locations[selectedLocation].GetCounty() + ", "
                           + Data.locations[selectedLocation].GetPostcode() + ".";

                lblCoordinatesDATA.Text = "(" + Data.locations[selectedLocation].GetLatitude() + ", "
                                      + Data.locations[selectedLocation].GetLongitude() + ")";

                if (Data.locations[selectedLocation].GetYears() != null)
                {
                    lblNumberOfYearsInLocationDATA.Text = Data.numberOfYearsArray[selectedLocation];
                }

            }
        }

        // Updates the year details.
        public void Update_YearDetails(int selectedYear)
        {
            lblYearSelected.Text = currentLocationsYears[selectedYear].GetYear();

            lblYearDATA.Text = currentLocationsYears[selectedYear].GetYear();

            lblYearDescriptionDATA.Text = currentLocationsYears[selectedYear].GetYearDescription();
        }

        // Updates the month details.
        public void Update_MonthDetails(int selectedMonth)
        {
            lblMonthSelected.Text = comboBoxMonths.SelectedItem.ToString();

            lblMonthDATA.Text = currentYearsMonths[selectedMonth].GetMonthIDNumber();

            if (currentYearsMonths[selectedMonth].GetMaximumTemperature().ToString() == "999")
            {
                lblMaximumTemperatureDATA.Text = "N/A";
            }
            else
            {
                lblMaximumTemperatureDATA.Text = currentYearsMonths[selectedMonth].GetMaximumTemperature().ToString();
            }

            if (currentYearsMonths[selectedMonth].GetMinimumTemperature().ToString() == "999")
            {
                lblMinimumTemperatureDATA.Text = "N/A";
            }
            else
            {
                lblMinimumTemperatureDATA.Text = currentYearsMonths[selectedMonth].GetMinimumTemperature().ToString();
            }

            if (currentYearsMonths[selectedMonth].GetNumberOfDaysOfAirFrost().ToString() == "999")
            {
                lblNumberOfDaysOfAirfrostDATA.Text = "N/A";
            }
            else
            {
                lblNumberOfDaysOfAirfrostDATA.Text = currentYearsMonths[selectedMonth].GetNumberOfDaysOfAirFrost().ToString();
            }

            if (currentYearsMonths[selectedMonth].GetMillimetresOfRainfall().ToString() == "999")
            {
                lblMillimetresOfRainfallDATA.Text = "N/A";
            }
            else
            {
                lblMillimetresOfRainfallDATA.Text = currentYearsMonths[selectedMonth].GetMillimetresOfRainfall().ToString();
            }

            if (currentYearsMonths[selectedMonth].GetHoursOfSunshine().ToString() == "999")
            {
                lblHoursOfSunshineDATA.Text = "N/A";
            }
            else
            {
                lblHoursOfSunshineDATA.Text = currentYearsMonths[selectedMonth].GetHoursOfSunshine().ToString();
            }

        }



        // Clear All.
        private void Clear_All()
        {

            comboBoxLocations.Items.Clear();
            comboBoxYears.Items.Clear();
            comboBoxMonths.Items.Clear();

            Clear_LocationDetails();
            Clear_YearDetails();
            Clear_MonthDetails();
        }

        // Clears the location details.
        private void Clear_LocationDetails()
        {
            lblLocationLoaded.Text = "No Location Loaded";

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
            selectedMonth = -1;
            selectedYear = -1;

            comboBoxYears.Items.Clear();
            comboBoxMonths.Items.Clear();

            Clear_LocationDetails();
            Clear_YearDetails();
            Clear_MonthDetails();

            selectedLocation = comboBoxLocations.SelectedIndex;

            if (selectedLocation == -1)
            {
                isValidSelectedLocation = false;
                MessageBox.Show("ERROR: Please select a valid location");
            }

            if (isValidSelectedLocation == true)
            {
                LoadItemsInto_ComboBoxYears(selectedLocation);
                Update_LocationDetails(selectedLocation);
            }

        }

        // Gets the index when a new year is selected,
        // and loads the months from that selected year into the
        // Months ComboBox.
        // It clears and then updates the UI.
        private void comboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = -1;

            comboBoxMonths.Items.Clear();

            Clear_MonthDetails();

            selectedYear = comboBoxYears.SelectedIndex;

            if (selectedYear == -1)
            {
                isValidSelectedYear = false;
                MessageBox.Show("ERROR: Please select a valid year");
            }

            if (isValidSelectedYear == true)
            {
                LoadItemsInto_ComboBoxMonths(selectedYear);
                Update_YearDetails(selectedYear);
            }

        }

        // Gets the index when a new month is selected,
        // It updates the UI.
        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = comboBoxMonths.SelectedIndex;

            if (selectedMonth == -1)
            {
                isValidSelectedMonth = false;
                MessageBox.Show("ERROR: Please select a valid month");
            }

            if (isValidSelectedMonth == true)
            {
                Update_MonthDetails(selectedMonth);
            }
        }



        // Loads the edit location form.
        // An error message box pops up if the user does not select a location.
        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (comboBoxLocations.SelectedItem != null)
            {
                editLocationForm.Update_EditTextboxes();
                editLocationForm.Show();
            }
            else
            {
                MessageBox.Show("ERROR: Please select a location to edit.");
            }

        }

        // Loads the edit year form.
        // An error message box pops up if the user does not select a year.
        private void btnEditYear_Click(object sender, EventArgs e)
        {
            if (comboBoxYears.SelectedItem != null)
            {
                editYearForm.Update_EditTextboxes();
                editYearForm.Show();
            }
            else
            {
                MessageBox.Show("ERROR: Please select a year to edit.");
            }
        }

        // Loads the edit month form.
        // And error message box pops up if the uder does not select a month.
        private void btnEditMonth_Click(object sender, EventArgs e)
        {
            if (comboBoxMonths.SelectedItem != null)
            {
                editMonthForm.Update_EditTextboxes();
                editMonthForm.Show();
            }
            else
            {
                MessageBox.Show("ERROR: Please select a month to edit.");
            }
        }



        // Refresh button reloads the data onto the main form.
        // This should be pressed after ever edit.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Update_FileLoaded();
            LoadItemsInto_ComboBoxLocations();

            txtBoxSearchLocations.Clear();
            txtBoxSearchYears.Clear();
            txtBoxSearchMonths.Clear();

            if (comboBoxLocations.SelectedItem != null)
            {
                Update_LocationDetails(selectedLocation);
                LoadItemsInto_ComboBoxYears(selectedLocation);
            }
            if (comboBoxYears.SelectedItem != null)
            {
                Update_YearDetails(selectedYear);
                LoadItemsInto_ComboBoxMonths(selectedYear);
            }
            if (comboBoxMonths.SelectedItem != null)
            {
                Update_MonthDetails(selectedMonth);
                LoadItemsInto_ComboBoxMonths(selectedMonth);
            }

        }



        // Add new location.
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            addLocationForm.Update_EditTextboxes();
            addLocationForm.Show();
        }

        // Add new year.
        private void btnAddYear_Click(object sender, EventArgs e)
        {
            addYearForm.Update_EditTextboxes();
            addYearForm.Show();
        }



        // Search for locations.
        private void txtBoxSearchLocations_TextChanged(object sender, EventArgs e)
        {
            string searchInLocations = txtBoxSearchLocations.Text;

            if (String.IsNullOrEmpty(searchInLocations))
            {
                // If the user hasn't typed in the search bar,
                // show all locations.
                LoadItemsInto_ComboBoxLocations();
                filteredLocations = null;
            }
            else
            {
                if (filteredLocations == null)
                {
                    SearchThroughDATALocations(searchInLocations);
                }
                else
                {
                    SearchThroughFILTEREDLocations(searchInLocations);
                }
            }

        }

        // Search through Data.Locations.
        private void SearchThroughDATALocations(string searchInLocations)
        {
            int numberOfMatchingChars = 0;

            // Cycles through each location.
            for (int i = 0; i < Data.locations.Length; i++)
            {
                string currentLocation = Data.locations[i].GetLocationName() +
                                         ", " + Data.locations[i].GetPostcode() +
                                         ".";

                numberOfMatchingChars = 0;

                // Cycles through each character in currentLocation.
                for (int locationChar = 0; locationChar < currentLocation.Length; locationChar++)
                {

                    // Cycles through each character in searchInLocations.
                    for (int searchChar = 0; searchChar < searchInLocations.Length; searchChar++)
                    {

                        if (currentLocation[locationChar].ToString().ToUpper() == searchInLocations[searchChar].ToString().ToUpper())
                        {
                            numberOfMatchingChars++;
                        }
                    }

                }

                if (numberOfMatchingChars != 0)
                {
                    AddLocationToFilteredArray(ref filteredLocations, Data.locations[i]);
                }

            }

            DisplayFilteredLocations();
        }

        // Search through already filtered Locations.
        private void SearchThroughFILTEREDLocations(string searchInLocations)
        {
            int numberOfMatchingChars = 0;
            string lastCharInSearchInLocations = searchInLocations.Substring(searchInLocations.Length - 1);

            Location[] filteredLocationsCOPY = filteredLocations;
            filteredLocations = null;

            // Cycles through each location.
            for (int i = 0; i < filteredLocationsCOPY.Length; i++)
            {
                string currentLocation = filteredLocationsCOPY[i].GetLocationName() +
                                         ", " + filteredLocationsCOPY[i].GetPostcode() +
                                         ".";

                // Cycles through each character in currentLocation.
                for (int locationChar = 0; locationChar < currentLocation.Length; locationChar++)
                {

                    // Cycles through each character in searchInLocations
                    for (int searchChar = 0; searchChar < lastCharInSearchInLocations.Length; searchChar++)
                    {

                        if (currentLocation[locationChar].ToString().ToUpper() == lastCharInSearchInLocations[searchChar].ToString().ToUpper())
                        {
                            numberOfMatchingChars++;
                        }

                    }
                }

                if (numberOfMatchingChars != 0)
                {
                    AddLocationToFilteredArray(ref filteredLocations, filteredLocationsCOPY[i]);
                }

            }

            DisplayFilteredLocations();
        }



        // Search for years.
        private void txtBoxSearchYears_TextChanged(object sender, EventArgs e)
        {
            string searchInYears = txtBoxSearchYears.Text;

            // If a location has been selected.
            if (selectedLocation != -1)
            {
                if (String.IsNullOrEmpty(searchInYears))
                {
                    // If the user hasn't typed in the search bar,
                    // show all locations.
                    LoadItemsInto_ComboBoxYears(selectedLocation);
                    filteredYears = null;
                }
                else
                {
                    if (filteredYears == null)
                    {
                        SearchThroughDATAYears(searchInYears);
                    }
                    else
                    {
                        SearchThroughFILTEREDYears(searchInYears);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: Please select a valid location.");
            }          
        }

        // Search through Data.Locations' years.
        private void SearchThroughDATAYears(string searchInYears)
        {
            int numberOfMatchingChars = 0;
            Year[] years = Data.locations[selectedLocation].GetYears();

            // Cycles through each year.
            for (int i = 0; i < years.Length; i++)
            {
                string currentYear = years[i].GetYear() + ".";

                numberOfMatchingChars = 0;

                // Cycles through each character in currentYear.
                for (int YearChar = 0; YearChar < currentYear.Length; YearChar++)
                {

                    // Cycles through each character in searchInYears.
                    for (int searchChar = 0; searchChar < searchInYears.Length; searchChar++)
                    {

                        if (currentYear[YearChar].ToString().ToUpper() == searchInYears[searchChar].ToString().ToUpper())
                        {
                            numberOfMatchingChars++;
                        }
                    }

                }

                if (numberOfMatchingChars != 0)
                {
                    AddYearToFilteredArray(ref filteredYears, years[i]);
                }

            }

            DisplayFilteredYears();
        }

        // Search through already filtered years.
        private void SearchThroughFILTEREDYears(string searchInYears)
        {
            int numberOfMatchingChars = 0;
            string lastCharInSearchInYears = searchInYears.Substring(searchInYears.Length - 1);

            Year[] filteredYearsCOPY = filteredYears;
            filteredYears = null;

            // Cycles through each Year.
            for (int i = 0; i < filteredYearsCOPY.Length; i++)
            {
                string currentYear = filteredYearsCOPY[i].GetYear() +".";

                // Cycles through each character in currentYear.
                for (int yearChar = 0; yearChar < currentYear.Length; yearChar++)
                {

                    // Cycles through each character in searchInYears.
                    for (int searchChar = 0; searchChar < lastCharInSearchInYears.Length; searchChar++)
                    {

                        if (currentYear[yearChar].ToString().ToUpper() == lastCharInSearchInYears[searchChar].ToString().ToUpper())
                        {
                            numberOfMatchingChars++;
                        }

                    }
                }

                if (numberOfMatchingChars != 0)
                {
                    AddYearToFilteredArray(ref filteredYears, filteredYearsCOPY[i]);
                }

            }

            DisplayFilteredYears();
        }



        // Search for months.
        private void txtBoxSearchMonths_TextChanged(object sender, EventArgs e)
        {
            string searchInMonths = txtBoxSearchMonths.Text;

            // If a year has been selected.
            if (selectedYear != -1)
            {
                if (String.IsNullOrEmpty(searchInMonths))
                {
                    // If the user hasn't typed in the search bar,
                    // show all locations.
                    LoadItemsInto_ComboBoxMonths(selectedYear);
                    filteredMonths = null;
                }
                else
                {
                    if (filteredMonths == null)
                    {
                        SearchThroughDATAMonths(searchInMonths);
                    }
                    else
                    {
                        SearchThroughFILTEREDMonths(searchInMonths);
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: Please select a valid location.");
            }
        }

        // Search through Data.Locations' years' months.
        private void SearchThroughDATAMonths(string searchInMonths)
        {
            int numberOfMatchingChars = 0;
            Year[] years = Data.locations[selectedLocation].GetYears();
            MonthlyObservations[] months = years[selectedYear].GetMonths();

            // Cycles through each month.
            for (int i = 0; i < months.Length; i++)
            {
                int currentMonthInt = Convert.ToInt32(months[i].GetMonthIDNumber());
                MakeMonthIDReadable(currentMonthInt);
                string currentMonth = monthAsString;

                numberOfMatchingChars = 0;

                // Cycles through each character in currentMonth.
                for (int MonthChar = 0; MonthChar < currentMonth.Length; MonthChar++)
                {

                    // Cycles through each character in searchInMonths.
                    for (int searchChar = 0; searchChar < searchInMonths.Length; searchChar++)
                    {

                        if (currentMonth[MonthChar].ToString().ToUpper() == searchInMonths[searchChar].ToString().ToUpper())
                        {
                            numberOfMatchingChars++;
                        }
                    }

                }

                if (numberOfMatchingChars != 0)
                {
                    AddMonthToFilteredArray(ref filteredMonths, months[i]);
                }

            }

            DisplayFilteredMonths();
        }

        // Search through already filtered months.
        private void SearchThroughFILTEREDMonths(string searchInMonths)
        {
            int numberOfMatchingChars = 0;
            string lastCharInSearchInMonths = searchInMonths.Substring(searchInMonths.Length-1);

            MonthlyObservations[] filteredMonthsCOPY = filteredMonths;
            filteredMonths = null;

            // Cycles through each Month.
            for (int i = 0; i < filteredMonthsCOPY.Length; i++)
            {
                int currentMonthInt = Convert.ToInt32(filteredMonthsCOPY[i].GetMonthIDNumber());
                MakeMonthIDReadable(currentMonthInt);
                string currentMonth = monthAsString;

                // Cycles through each character in currentMonth.
                for (int monthChar = 0; monthChar < currentMonth.Length; monthChar++)
                {

                    // Cycles through each character in searchInMonth.
                    for (int searchChar = 0; searchChar < lastCharInSearchInMonths.Length; searchChar++)
                    {

                        if (currentMonth[monthChar].ToString().ToUpper() == lastCharInSearchInMonths[searchChar].ToString().ToUpper())
                        {
                            numberOfMatchingChars++;
                        }

                    }
                }

                if (numberOfMatchingChars != 0)
                {
                    AddMonthToFilteredArray(ref filteredMonths, filteredMonthsCOPY[i]);
                }

            }

            DisplayFilteredMonths();
        }



        // Displays filtered locations into the Locations ComboBox.
        public void DisplayFilteredLocations()
        {
            comboBoxLocations.Items.Clear();

            if (filteredLocations != null)
            {
                foreach (Location locationItem in filteredLocations)
                {
                    comboBoxLocations.Items.Add(locationItem.GetLocationName() + ", "
                                                + locationItem.GetPostcode() + ".");
                }
            }
            else
            {
                MessageBox.Show("No matching results.");
                txtBoxSearchLocations.Clear();
                LoadItemsInto_ComboBoxLocations();
            }

        }

        // Displays filtered years into the Years ComboBox.
        public void DisplayFilteredYears()
        {
            comboBoxYears.Items.Clear();

            if (filteredYears != null)
            {
                foreach (Year yearItem in filteredYears)
                {
                    comboBoxYears.Items.Add(yearItem.GetYear() + ".");
                }
            }
            else
            {
                MessageBox.Show("No matching results.");
                txtBoxSearchYears.Clear();
                LoadItemsInto_ComboBoxYears(selectedLocation);
            }

        }

        // Displays filtered months into the Months ComboBox.
        public void DisplayFilteredMonths()
        {
            comboBoxMonths.Items.Clear();

            if (filteredMonths != null)
            {
                foreach (MonthlyObservations monthItem in filteredMonths)
                {
                    int currentMonth = Convert.ToInt32(monthItem.GetMonthIDNumber());
                    MakeMonthIDReadable(currentMonth);

                    comboBoxMonths.Items.Add(monthAsString);
                }
            }
            else
            {
                MessageBox.Show("No matching results.");
                txtBoxSearchMonths.Clear();
                LoadItemsInto_ComboBoxMonths(selectedYear);
            }

        }



        // Adds location to the array.
        private Location[] AddLocationToFilteredArray(ref Location[] thisLocationArray, Location newLocation)
        {
            int locationArraySize;

            // Find size of array now.
            if (thisLocationArray == null)
                locationArraySize = 0;
            else
                locationArraySize = thisLocationArray.Length;

            // Make it one bigger.
            Array.Resize(ref thisLocationArray, locationArraySize + 1);

            // Add into array.
            thisLocationArray[locationArraySize] = newLocation;

            return thisLocationArray;
        }

        // Adds years to the array.
        private Year[] AddYearToFilteredArray(ref Year[] thisYearArray, Year newYear)
        {
            int YearArraySize;

            // Find size of array now.
            if (thisYearArray == null)
                YearArraySize = 0;
            else
                YearArraySize = thisYearArray.Length;

            // Make it one bigger.
            Array.Resize(ref thisYearArray, YearArraySize + 1);

            // Add into array.
            thisYearArray[YearArraySize] = newYear;

            return thisYearArray;
        }

        // Adds months to the array.
        private MonthlyObservations[] AddMonthToFilteredArray(ref MonthlyObservations[] thisMonthArray, MonthlyObservations newMonth)
        {
            int monthArraySize;

            // Find size of array now.
            if (thisMonthArray == null)
                monthArraySize = 0;
            else
                monthArraySize = thisMonthArray.Length;

            // Make it one bigger.
            Array.Resize(ref thisMonthArray, monthArraySize + 1);

            // Add into array.
            thisMonthArray[monthArraySize] = newMonth;

            return thisMonthArray;
        }



        // Shows a new form, depending on which data is selected.
        // This form is used for data analysis.
        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            // If only a location is selected:
            if (selectedLocation != -1 && selectedYear == -1)
            {
                locationAnalysisForm.DataUpdate();
                locationAnalysisForm.Show();
            }

            // If a year is also selected:
            if (selectedYear != -1 && selectedMonth == -1)
            {
                yearAnalysisForm.DataUpdate();
                yearAnalysisForm.Show();
            }

            // If a month is selected:
            if (selectedMonth != -1)
            {
                MessageBox.Show("This feature is only available for locations and years.");
            }
        }
    }
}

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
    public partial class frmEditMonth : Form
    {

        // Declaring variables.
        Year[] arrayOfYears;
        MonthlyObservations[] arrayOfMonths;



        public frmEditMonth()
        {
            InitializeComponent();
        }



        // Update the form, every time it's opened.
        public void Update_EditTextboxes()
        {
            arrayOfYears = Data.locations[frmMain.selectedLocation].GetYears();
            arrayOfMonths = arrayOfYears[frmMain.selectedYear].GetMonths();

            txtBoxMonthID.Text = arrayOfMonths[frmMain.selectedMonth].GetMonthIDNumber();
            txtBoxMaximumTemperature.Text = arrayOfMonths[frmMain.selectedMonth].GetMaximumTemperature().ToString();
            txtBoxMinimumTemperature.Text = arrayOfMonths[frmMain.selectedMonth].GetMinimumTemperature().ToString();
            txtBoxMillimetresOfRainfall.Text = arrayOfMonths[frmMain.selectedMonth].GetMillimetresOfRainfall().ToString();
            txtBoxDaysOfAirfrost.Text = arrayOfMonths[frmMain.selectedMonth].GetNumberOfDaysOfAirFrost().ToString();
            txtBoxHoursOfSunshine.Text = arrayOfMonths[frmMain.selectedMonth].GetHoursOfSunshine().ToString();
        }

        // When the save button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            arrayOfMonths[frmMain.selectedMonth].SetMonthIDNumber(txtBoxMonthID.Text);
            arrayOfMonths[frmMain.selectedMonth].SetMaximumTemperature(txtBoxMaximumTemperature.Text);
            arrayOfMonths[frmMain.selectedMonth].SetMinimumTemperature(txtBoxMinimumTemperature.Text);
            arrayOfMonths[frmMain.selectedMonth].SetMillimetresOfRainfall(txtBoxMillimetresOfRainfall.Text);
            arrayOfMonths[frmMain.selectedMonth].SetNumberOfDaysOfAirFrost(txtBoxDaysOfAirfrost.Text);
            arrayOfMonths[frmMain.selectedMonth].SetHoursOfSunshine(txtBoxHoursOfSunshine.Text);

            Hide();
        }

        // When the reset button is clicked.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxMonthID.Text = arrayOfMonths[frmMain.selectedMonth].GetMonthIDNumber();
            txtBoxMaximumTemperature.Text = arrayOfMonths[frmMain.selectedMonth].GetMaximumTemperature().ToString();
            txtBoxMinimumTemperature.Text = arrayOfMonths[frmMain.selectedMonth].GetMinimumTemperature().ToString();
            txtBoxMillimetresOfRainfall.Text = arrayOfMonths[frmMain.selectedMonth].GetMillimetresOfRainfall().ToString();
            txtBoxDaysOfAirfrost.Text = arrayOfMonths[frmMain.selectedMonth].GetNumberOfDaysOfAirFrost().ToString();
            txtBoxHoursOfSunshine.Text = arrayOfMonths[frmMain.selectedMonth].GetHoursOfSunshine().ToString();
        }

        // When the back button is clicked.
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

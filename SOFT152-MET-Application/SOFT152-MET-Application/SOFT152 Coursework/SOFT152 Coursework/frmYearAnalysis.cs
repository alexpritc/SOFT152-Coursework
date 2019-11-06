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
    public partial class frmYearAnalysis : Form
    {
        // Declaring varaibles.
        public double maximumTemperature;
        public double minimumTemperature;
        public double daysOfAirfrost;
        public double millimetresOfRainfall;
        public double hoursOfSunshine;

        Year[] years = null;
        MonthlyObservations[] months;

        double[] arrayOfMaximumTemperature;
        double[] arrayOfMinimumTemperature;
        double[] arrayOfDaysOfAirfrost;
        double[] arrayOfMillimetresOfRainfall;
        double[] arrayOfHoursOfSunshine;

        int index;
        int numberOfBars;

        bool isMaxTemp = false;
        bool isMinTemp = false;
        bool isAirfrost = false;
        bool isRainfall = false;
        bool isSunshine = false;

        public frmYearAnalysis()
        {
            InitializeComponent();
        }





        // Everytime the form loads, reset the data.
        public void DataUpdate()
        {
            comboBoxMenu.SelectedIndex = 0;

            years = Data.locations[frmMain.selectedLocation].GetYears();
            months = years[frmMain.selectedYear].GetMonths();

            arrayOfMaximumTemperature = null;
            arrayOfMinimumTemperature = null;
            arrayOfDaysOfAirfrost = null;
            arrayOfMillimetresOfRainfall = null;
            arrayOfHoursOfSunshine = null;

            numberOfBars = months.Length;

            MaximumTemperature();
            MinimumTemperature();
            DaysOfAirfrost();
            MillimetresOfRainfall();
            HoursOfSunshine();

            isMaxTemp = true;
            isMinTemp = false;
            isAirfrost = false;
            isRainfall = false;
            isSunshine = false;

            Refresh();

        }



        // Drawing the graphics.
        private void panelYearAnalysis_Paint_1(object sender, PaintEventArgs e)
        {
            int gapBetweenBars = 10;

            Color solidColor = Color.Black;
            Brush solidBrush = new SolidBrush(solidColor);

            Font myFont = new Font("Helvetica", 6, FontStyle.Regular);


            using (Graphics panelGraphics = panelYearAnalysis.CreateGraphics())
            using (Graphics panel2Graphics = panelMonths.CreateGraphics())
            using (Graphics panel3Graphics = panelValues.CreateGraphics())
            using (Pen linePen = new Pen(solidBrush))
            {
                for (int i = 0; i < numberOfBars; i++)
                {
                    if (isMaxTemp == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars * 2, Convert.ToSingle(arrayOfMaximumTemperature[i]) * 10, 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfMaximumTemperature[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isMinTemp == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars * 2, Convert.ToSingle(arrayOfMinimumTemperature[i]) * 20, 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfMinimumTemperature[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isAirfrost == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars * 2, Convert.ToSingle(arrayOfDaysOfAirfrost[i]) * 20, 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfDaysOfAirfrost[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isRainfall == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars * 2, Convert.ToSingle(arrayOfMillimetresOfRainfall[i]), 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfMillimetresOfRainfall[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isSunshine == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars * 2, Convert.ToSingle(arrayOfHoursOfSunshine[i]), 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfHoursOfSunshine[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }

                    panel2Graphics.DrawString(months[i].GetMonthIDNumber().ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                }
            }

        }



        // When the OK button is clicked, hide the form.
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        // When a new Monthly Observation attribute is selected...
        private void comboBoxMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            index = comboBoxMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    isMaxTemp = true;
                    isMinTemp = false;
                    isAirfrost = false;
                    isRainfall = false;
                    isSunshine = false;
                    break;
                case 1:
                    isMinTemp = true;
                    isMaxTemp = false;
                    isAirfrost = false;
                    isRainfall = false;
                    isSunshine = false;
                    break;
                case 2:
                    isAirfrost = true;
                    isMaxTemp = false;
                    isMinTemp = false;
                    isRainfall = false;
                    isSunshine = false;
                    break;
                case 3:
                    isRainfall = true;
                    isMaxTemp = false;
                    isMinTemp = false;
                    isAirfrost = false;
                    isSunshine = false;
                    break;
                case 4:
                    isSunshine = true;
                    isMaxTemp = false;
                    isMinTemp = false;
                    isAirfrost = false;
                    isRainfall = false;
                    break;
            }

            Refresh();

        }

        // ...Get and store the appropriate averages-data.
        private void MaximumTemperature()
        {

            for (int j = 0; j < 12; j++)
            {
                maximumTemperature = months[j].GetMaximumTemperature();
                AddDoubleToArray(ref arrayOfMaximumTemperature, maximumTemperature);
            }
        }

        private void MinimumTemperature()
        {
            for (int j = 0; j < 12; j++)
            {
                minimumTemperature = months[j].GetMinimumTemperature();
                AddDoubleToArray(ref arrayOfMinimumTemperature, minimumTemperature);
            }
        }

        private void DaysOfAirfrost()
        {

            for (int j = 0; j < 12; j++)
            {
                daysOfAirfrost = months[j].GetNumberOfDaysOfAirFrost();
                AddDoubleToArray(ref arrayOfDaysOfAirfrost, daysOfAirfrost);
            }

        }

        private void MillimetresOfRainfall()
        {

            for (int j = 0; j < 12; j++)
            {
                millimetresOfRainfall = months[j].GetMillimetresOfRainfall();
                AddDoubleToArray(ref arrayOfMillimetresOfRainfall, millimetresOfRainfall);
            }

        }

        private void HoursOfSunshine()
        {
            for (int j = 0; j < 12; j++)
            {
                hoursOfSunshine = months[j].GetHoursOfSunshine();         
                AddDoubleToArray(ref arrayOfHoursOfSunshine, hoursOfSunshine);
            }

        }



        // Adds doubles to the array.
        private double[] AddDoubleToArray(ref double[] thisDoubleArray, double newDouble)
        {
            int doubleArraySize;

            // Find size of array now.
            if (thisDoubleArray == null)
                doubleArraySize = 0;
            else
                doubleArraySize = thisDoubleArray.Length;

            // Make it one bigger.
            Array.Resize(ref thisDoubleArray, doubleArraySize + 1);

            // Add into array.
            thisDoubleArray[doubleArraySize] = newDouble;

            return thisDoubleArray;
        }

    }
}

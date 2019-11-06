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
    public partial class frmLocationAnalysis : Form
    {
        // Declaring varaibles.
        public double avgMaximumTemperature;
        public double avgMinimumTemperature;
        public double avgDaysOfAirfrost;
        public double avgMillimetresOfRainfall;
        public double avgHoursOfSunshine;

        Year[] years = null;
        MonthlyObservations[] months;

        double[] arrayOfAvgMaximumTemperature;
        double[] arrayOfAvgMinimumTemperature;
        double[] arrayOfAvgDaysOfAirfrost;
        double[] arrayOfAvgMillimetresOfRainfall;
        double[] arrayOfAvgHoursOfSunshine;

        int index;
        int numberOfBars;

        bool isMaxTemp = false;
        bool isMinTemp = false;
        bool isAirfrost = false;
        bool isRainfall = false;
        bool isSunshine = false;

        public frmLocationAnalysis()
        {
            InitializeComponent();
        }



        // Everytime the form loads, reset the data.
        public void DataUpdate()
        {
            comboBoxMenu.SelectedIndex = 0;

            years = Data.locations[frmMain.selectedLocation].GetYears();
            months = null;

            arrayOfAvgMaximumTemperature = null;
            arrayOfAvgMinimumTemperature = null;
            arrayOfAvgDaysOfAirfrost = null;
            arrayOfAvgMillimetresOfRainfall = null;
            arrayOfAvgHoursOfSunshine = null;

            numberOfBars = years.Length;

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
        private void panelLocationAnalysis_Paint(object sender, PaintEventArgs e)
        {
            int gapBetweenBars = 10;

            Color solidColor = Color.Black;
            Brush solidBrush = new SolidBrush(solidColor);

            Font myFont = new Font("Helvetica", 6, FontStyle.Regular);


            using (Graphics panelGraphics = panelLocationAnalysis.CreateGraphics())
            using (Graphics panel2Graphics = panelYears.CreateGraphics())
            using (Graphics panel3Graphics = panelValues.CreateGraphics())
            using (Pen linePen = new Pen(solidBrush))
            {
                for (int i = 0; i < numberOfBars; i++)
                {
                    if (isMaxTemp == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars, Convert.ToSingle(arrayOfAvgMaximumTemperature[i]) * 20, 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfAvgMaximumTemperature[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isMinTemp == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars, Convert.ToSingle(arrayOfAvgMinimumTemperature[i]) * 20, 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfAvgMinimumTemperature[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isAirfrost == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars, Convert.ToSingle(arrayOfAvgDaysOfAirfrost[i]) * 20, 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfAvgDaysOfAirfrost[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isRainfall == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars, Convert.ToSingle(arrayOfAvgMillimetresOfRainfall[i]), 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfAvgMillimetresOfRainfall[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    if (isSunshine == true)
                    {
                        panelGraphics.DrawRectangle(linePen, 0, i * gapBetweenBars, Convert.ToSingle(arrayOfAvgHoursOfSunshine[i]), 10);
                        panel3Graphics.DrawString(Convert.ToSingle(arrayOfAvgHoursOfSunshine[i]).ToString(), myFont, solidBrush, 0, i * gapBetweenBars * 2);
                    }
                    panel2Graphics.DrawString(years[i].GetYear().ToString(), myFont, solidBrush, 0, i * gapBetweenBars);
                    
                }
            }

        }


        // When the OK button is clicked, hide the form.
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        // When a new Monthly Observation attribute is selected...
        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
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
            for (int i = 0; i < years.Length; i++)
            {
                avgMaximumTemperature = 0;

                for (int j = 0; j < 12; j++)
                {
                    months = years[i].GetMonths();
                    avgMaximumTemperature += months[j].GetMaximumTemperature();

                    avgMaximumTemperature = avgMaximumTemperature / months.Length;
                    AddDoubleToArray(ref arrayOfAvgMaximumTemperature, avgMaximumTemperature);
                }



            }

        }

        private void MinimumTemperature()
        {
            for (int i = 0; i < years.Length; i++)
            {
                avgMinimumTemperature = 0;

                for (int j = 0; j < 12; j++)
                {
                    months = years[i].GetMonths();
                    avgMinimumTemperature += months[j].GetMinimumTemperature();
                    avgMinimumTemperature = avgMinimumTemperature / months.Length;
                    AddDoubleToArray(ref arrayOfAvgMinimumTemperature, avgMinimumTemperature);

                }



            }
        }

        private void DaysOfAirfrost()
        {
            for (int i = 0; i < years.Length; i++)
            {
                avgDaysOfAirfrost = 0;

                for (int j = 0; j < 12; j++)
                {
                    months = years[i].GetMonths();
                    avgDaysOfAirfrost += months[j].GetNumberOfDaysOfAirFrost();

                    avgDaysOfAirfrost = avgDaysOfAirfrost / months.Length;
                    AddDoubleToArray(ref arrayOfAvgDaysOfAirfrost, avgDaysOfAirfrost);
                }



            }
        }

        private void MillimetresOfRainfall()
        {
            for (int i = 0; i < years.Length; i++)
            {
                avgMillimetresOfRainfall = 0;

                for (int j = 0; j < 12; j++)
                {
                    months = years[i].GetMonths();
                    avgMillimetresOfRainfall += months[j].GetMillimetresOfRainfall();

                    avgMillimetresOfRainfall = avgMillimetresOfRainfall / months.Length;
                    AddDoubleToArray(ref arrayOfAvgMillimetresOfRainfall, avgMillimetresOfRainfall);
                }



            }
        }

        private void HoursOfSunshine()
        {
            for (int i = 0; i < years.Length; i++)
            {
                avgHoursOfSunshine = 0;

                for (int j = 0; j < 12; j++)
                {
                    months = years[i].GetMonths();
                    avgHoursOfSunshine += months[j].GetHoursOfSunshine();

                    avgHoursOfSunshine = avgHoursOfSunshine / months.Length;
                    AddDoubleToArray(ref arrayOfAvgHoursOfSunshine, avgHoursOfSunshine);
                }



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

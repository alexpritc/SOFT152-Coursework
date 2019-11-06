using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Coursework
{
    class MonthlyObservations
    {

        // Declaring variables.
        private string monthIDNumber;
        private float maximumTemperature;
        private float minimumTemperature;
        private float numberOfDaysOfAirFrost;
        private float millimetresOfRainfall;
        private float hoursOfSunshine;


        // Class constructor.
        public MonthlyObservations(string theMonthIDNumber, string theMaximumTemperature,
                                   string theMinimumTemperature, string theNumberOfDaysOfAirFrost,
                                   string theMillimetresOfRainfall, string theHoursOfSunshine)
        {
            monthIDNumber = theMonthIDNumber;
            SetMaximumTemperature(theMaximumTemperature);
            SetMinimumTemperature(theMinimumTemperature);
            SetNumberOfDaysOfAirFrost(theNumberOfDaysOfAirFrost);
            SetMillimetresOfRainfall(theMillimetresOfRainfall);
            SetHoursOfSunshine(theHoursOfSunshine);

        }


        // Setters.
        public void SetMonthIDNumber(string inMonthIDNumber)
        {
            monthIDNumber = inMonthIDNumber;
        }

        public void SetMaximumTemperature(string inMaximumTemperature)
        {
            try
            {
                maximumTemperature = Convert.ToSingle(inMaximumTemperature);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid maximum temperature.");
            }

        }

        public void SetMinimumTemperature(string inMinimumTemperature)
        {
            try
            {
                minimumTemperature = Convert.ToSingle(inMinimumTemperature);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid minimum temperature.");
            }
        }

        public void SetNumberOfDaysOfAirFrost(string inNumberOfDaysOfAirFrost)
        {
            try
            {
                numberOfDaysOfAirFrost = Convert.ToSingle(inNumberOfDaysOfAirFrost);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid number of days of air frost.");
            }

        }

        public void SetMillimetresOfRainfall(string inMillimetresOfRainfall)
        {
            try
            {
                millimetresOfRainfall = Convert.ToSingle(inMillimetresOfRainfall);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid amount of rainfall in millimetres.");
            }
        }

        public void SetHoursOfSunshine(string inHoursOfSunshine)
        {
            try
            {
                hoursOfSunshine = Convert.ToSingle(inHoursOfSunshine);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid number of hours of sunshine.");
            }
        }


        // Getters.
        public string GetMonthIDNumber()
        {
            return monthIDNumber;
        }

        public float GetMaximumTemperature()
        {
            return maximumTemperature;
        }

        public float GetMinimumTemperature()
        {
            return minimumTemperature;
        }

        public float GetNumberOfDaysOfAirFrost()
        {
            return numberOfDaysOfAirFrost;
        }

        public float GetMillimetresOfRainfall()
        {
            return millimetresOfRainfall;
        }

        public float GetHoursOfSunshine()
        {
            return hoursOfSunshine;
        }

    }
}

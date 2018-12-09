using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Coursework
{
    class Location
    {

        // Delcaring variables.
        private string locationName;
        private string streetNumberAndName;
        private string county;
        private string postcode;
        private double latitude;
        private double longitude;
        private Year[] years;


        // Class constructor.
        public Location(string theLocationName, string theStreetNumberAndName,
                        string theCounty, string thePostcode, string theLatitude,
                        string theLongitude, Year[] theYears)
        {
            locationName = theLocationName;
            streetNumberAndName = theStreetNumberAndName;
            county = theCounty;
            postcode = thePostcode;
            SetLatitude(theLatitude);
            SetLongitude(theLongitude);
            years = theYears;
        }


        // Setters.
        public void SetLocationName(string inLocationName)
        {
            locationName = inLocationName;
        }

        public void SetStreetNumberAndName(string inStreetNumberAndName)
        {
            streetNumberAndName = inStreetNumberAndName;
        }

        public void SetCounty(string inCounty)
        {
            county = inCounty;
        }

        public void SetPostcode(string inPostcode)
        {
            postcode = inPostcode;
        }

        public void SetLatitude(string inLatitude)
        {
            try
            {
                latitude = Convert.ToDouble(inLatitude);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid latitude.");
            }
        }

        public void SetLongitude(string inLongitude)
        {
            try
            {
                longitude = Convert.ToDouble(inLongitude);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " Please enter a valid longitude.");
            }
        }

        public void SetYears(Year[] inYears)
        {
            years = inYears;
        }


        // Getters.
        public string GetLocationName()
        {
            return locationName;
        }

        public string GetStreetNumberAndName()
        {
            return streetNumberAndName;
        }

        public string GetCounty()
        {
            return county;
        }

        public string GetPostcode()
        {
            return postcode;
        }

        public double GetLatitude()
        {
            return latitude;
        }

        public double GetLongitude()
        {
            return longitude;
        }

        public Year[] GetYears()
        {
            return years;
        }
    }
}

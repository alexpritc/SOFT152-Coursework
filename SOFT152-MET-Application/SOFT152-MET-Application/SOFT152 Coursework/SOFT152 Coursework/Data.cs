using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SOFT152_Coursework
{
    class Data
    {
        // Delcaring variables...
        public static MonthlyObservations[] months = new MonthlyObservations[0];
        public static Year[] years = new Year[0];
        public static Location[] locations = new Location[0];
        public static string[] numberOfYearsArray = new string[0];

        public static string numberOfLocations;
        public static int counter = 0;

        public static Year[] currentLocationsYears;
        public static MonthlyObservations[] currentYearsMonths;



        // Clear all stored data.
        public static void ClearData()
        {
            Array.Clear(months, 0, months.Length);
            Array.Resize(ref months, 0);

            Array.Clear(years, 0, years.Length);
            Array.Resize(ref years, 0);

            Array.Clear(locations, 0, locations.Length);
            Array.Resize(ref locations, 0);
        }



        // Reads locations.
        public static void ReadLocations()
        {
            string locationName, streetNumberAndName, county, postcode, latitude, longitude, numberOfYears;

            StreamReader readLocation = new StreamReader(frmMain.fileName);

            // Reads in the number of locations.
            numberOfLocations = readLocation.ReadLine();

            while (!readLocation.EndOfStream)
            {
                // Get location data x7.
                locationName = readLocation.ReadLine();
                streetNumberAndName = readLocation.ReadLine();
                county = readLocation.ReadLine();
                postcode = readLocation.ReadLine();
                latitude = readLocation.ReadLine();
                longitude = readLocation.ReadLine();
                numberOfYears = readLocation.ReadLine();


                // Read years.
                ReadYears(readLocation, Convert.ToInt32(numberOfYears));

                // Create new location.
                Location newLocation = new Location(locationName, streetNumberAndName, county, postcode, latitude, longitude, years);

                // Add location to Array.
                AddLocationToArray(ref locations, newLocation);

                // Adds number of years to a separate array.
                AddNumberOfYearsToArray(ref numberOfYearsArray, numberOfYears);

            }

            readLocation.Close();
        }

        // Adds location to the array.
        public static Location[] AddLocationToArray(ref Location[] thisLocationArray, Location newLocation)
        {
            int locationArraySize;

            // Find size of array now.
            if (thisLocationArray == null)
                locationArraySize = 0;
            else
                locationArraySize = locations.Length;

            // Make it one bigger.
            Array.Resize(ref thisLocationArray, locationArraySize + 1);

            // Add into array.
            thisLocationArray[locationArraySize] = newLocation;

            return thisLocationArray;
        }

        // Adds number of years in location to separate array.
        public static string[] AddNumberOfYearsToArray(ref string[] thisNumberOfYearsArray, string numberOfYears)
        {
            int numberOfYearsArraySize;

            // Find size of array now.
            if (thisNumberOfYearsArray == null)
                numberOfYearsArraySize = 0;
            else
                numberOfYearsArraySize = thisNumberOfYearsArray.Length;

            // Make it one bigger.
            Array.Resize(ref thisNumberOfYearsArray, numberOfYearsArraySize + 1);

            // Add into array.
            thisNumberOfYearsArray[numberOfYearsArraySize] = numberOfYears;

            return thisNumberOfYearsArray;
        }

        // Reads years.
        public static void ReadYears(StreamReader readYears, int numberOfYearsInLocation)
        {
            // Declaring varaibles.
            string yearDescription, year;
            int numberOfMonths = 11;

            years = null;
            for (int i = 0; i < numberOfYearsInLocation; i++)
            {
                // Get Year data x2.
                yearDescription = readYears.ReadLine();
                year = readYears.ReadLine();

                // Read months.
                ReadMonths(readYears, numberOfMonths);

                // Create new Year.
                Year newYear = new Year(year, yearDescription, months);

                // Add Year to Array.
                AddYearToArray(ref years, newYear);

            }
        }

        // Add years to array.
        public static Year[] AddYearToArray(ref Year[] thisYearArray, Year newYear)
        {
            int yearArraySize;

            // Find size of array now.
            if (thisYearArray == null)
            {
                yearArraySize = 0;
            }
            else
            {
                yearArraySize = years.Length;
            }

            // Make it one bigger.
            Array.Resize(ref thisYearArray, yearArraySize + 1);

            // Add into array.
            thisYearArray[yearArraySize] = newYear;

            return thisYearArray;

        }

        // Reads Months.
        public static void ReadMonths(StreamReader readMonths, int numberOfMonthsInYears)
        {
            // Declaring varaibles.
            string monthIDNumber, maximumTemperature, minimumTemperature,
                   numberOfDaysOfAirFrost, millimetresOfRainfall, hoursOfSunshine;
            string year;

            months = null;
            for (int i = 0; i <= numberOfMonthsInYears; i++)
            {

                // Get month data x7
                monthIDNumber = readMonths.ReadLine();
                maximumTemperature = readMonths.ReadLine();
                minimumTemperature = readMonths.ReadLine();
                numberOfDaysOfAirFrost = readMonths.ReadLine();
                millimetresOfRainfall = readMonths.ReadLine();
                hoursOfSunshine = readMonths.ReadLine();
                if (i != numberOfMonthsInYears)
                {
                    year = readMonths.ReadLine();
                }


                // Create new Month.
                MonthlyObservations newMonth = new MonthlyObservations(monthIDNumber, maximumTemperature, minimumTemperature,
                                                                       numberOfDaysOfAirFrost, millimetresOfRainfall, hoursOfSunshine);

                // Add Month to Array.
                AddMonthToArray(ref months, newMonth);
            }

        }

        // Add months to array.
        public static MonthlyObservations[] AddMonthToArray(ref MonthlyObservations[] thisMonthArray, MonthlyObservations newMonth)
        {
            int monthArraySize;

            // Find size of array now.
            if (thisMonthArray == null)
            {
                monthArraySize = 0;
            }
            else
            {
                monthArraySize = thisMonthArray.Length;
            }


            // Make it one bigger.
            Array.Resize(ref thisMonthArray, monthArraySize + 1);

            // Add into array.
            thisMonthArray[monthArraySize] = newMonth;

            return thisMonthArray;

        }



        // Rewrites the file.
        // Starts with the location.
        public static void SaveLocations()
        {
            // Clears file.
            if (frmMain.fileName != null)
            {
                File.WriteAllText(frmMain.fileName, string.Empty);

                StreamWriter writeToFile = new StreamWriter(frmMain.fileName);

                writeToFile.WriteLine(numberOfLocations);

                for (counter = 0; counter < Convert.ToInt32(numberOfLocations); counter++)
                {
                    // Write location data x7.
                    writeToFile.WriteLine(locations[counter].GetLocationName());
                    writeToFile.WriteLine(locations[counter].GetStreetNumberAndName());
                    writeToFile.WriteLine(locations[counter].GetCounty());
                    writeToFile.WriteLine(locations[counter].GetPostcode());
                    writeToFile.WriteLine(locations[counter].GetLatitude());
                    writeToFile.WriteLine(locations[counter].GetLongitude());
                    writeToFile.WriteLine(numberOfYearsArray[counter]);

                    // Save years.
                    SaveYears(writeToFile, Convert.ToInt32(numberOfYearsArray[counter]));

                }

                writeToFile.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: Please use 'Save as...' to name file.");
            }
           
        }

        // Saves the years.
        public static void SaveYears(StreamWriter saveYears, int numberOfYearsInLocation)
        {
            currentLocationsYears = locations[counter].GetYears();
            int numberOfMonths = 11;

            for (int i = 0; i < numberOfYearsInLocation; i++)
            {
                // Save Year data x2.
                saveYears.WriteLine(currentLocationsYears[i].GetYearDescription());
                saveYears.WriteLine(currentLocationsYears[i].GetYear());


                // Save months.
                SaveMonths(saveYears, numberOfMonths);

            }
        }

        // Saves the months.
        public static void SaveMonths(StreamWriter saveMonths, int numberOfMonthsInYears)
        {

            for (int i = 0; i <= numberOfMonthsInYears; i++)
            {
                currentYearsMonths = currentLocationsYears[counter].GetMonths();

                // Save month data x7
                saveMonths.WriteLine(currentYearsMonths[i].GetMonthIDNumber());
                saveMonths.WriteLine(currentYearsMonths[i].GetMaximumTemperature());
                saveMonths.WriteLine(currentYearsMonths[i].GetMinimumTemperature());
                saveMonths.WriteLine(currentYearsMonths[i].GetNumberOfDaysOfAirFrost());
                saveMonths.WriteLine(currentYearsMonths[i].GetMillimetresOfRainfall());
                saveMonths.WriteLine(currentYearsMonths[i].GetHoursOfSunshine());

                if (i != numberOfMonthsInYears)
                {
                    saveMonths.WriteLine(currentLocationsYears[i].GetYear());
                }
            }
        }
    }
}

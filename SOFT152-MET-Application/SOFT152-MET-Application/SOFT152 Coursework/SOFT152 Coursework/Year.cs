using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Coursework
{
    class Year
    {

        // Declaring variables.
        private string year;
        private string yearDescription;
        private MonthlyObservations[] months;


        // Class constructor.
        public Year(string theYear, string theYearDescription, MonthlyObservations[] theMonths)
        {
            year = theYear;
            yearDescription = theYearDescription;
            months = theMonths;
        }


        // Setters.
        public void SetYear(string inYear)
        {
            year = inYear;
        }

        public void SetYearDescription(string inYearDescription)
        {
            yearDescription = inYearDescription;
        }

        public void SetMonthlyObservations(MonthlyObservations[] inMonths)
        {
            months = inMonths;
        }


        // Getters.
        public string GetYear()
        {
            return year;
        }

        public string GetYearDescription()
        {
            return yearDescription;
        }

        public MonthlyObservations[] GetMonths()
        {
            return months;
        }
    }
}

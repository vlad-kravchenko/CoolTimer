using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Bunifu.Framework.UI;

namespace CoolTimer
{
    public partial class MainForm : Form
    {
        private DateTime birth;

        public MainForm(DateTime birth, int limit)
        {
            InitializeComponent();
            this.birth = birth;
            years.MaxValue = limit;

            ConfigTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ConfigTime();
        }

        private void ConfigTime()
        {
            var elapsed = SubtractDates(birth, DateTime.Now);
            years.Value = elapsed.Years;
            months.Value = elapsed.Months;
            days.Value = elapsed.Days;
            hours.Value = elapsed.Hours;
            minutes.Value = elapsed.Minutes;
            seconds.Value = elapsed.Seconds;

            lbYears.Text = years.Value + " years";
            lbMonths.Text = months.Value + " months";
            lbDays.Text = days.Value + " days";
            lbHours.Text = hours.Value + " hours";
            lbMinutes.Text = minutes.Value + " minutes";
            lbSeconds.Text = seconds.Value + " seconds";

            foreach(var control in Controls)
            {
                var bar = control as BunifuCircleProgressbar;
                if (bar == null) continue;

                double percent = (Convert.ToDouble(bar.Value) / Convert.ToDouble(bar.MaxValue)) * 100;

                if (percent < 30)
                {
                    bar.ProgressColor = Color.Green;
                }
                else if (percent < 60)
                {
                    bar.ProgressColor = Color.Yellow;
                }
                else
                {
                    bar.ProgressColor = Color.Red;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static TimeDifference SubtractDates(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate) return new TimeDifference(0, 0, 0, 0, 0, 0, 0, 0);

            //identify median months between two dates
            List<DateTime> medianMonths = new List<DateTime>();

            //start with the first calendar month after the start date
            int monthsIterator = 1;
            DateTime iterativeMonth = startDate.AddMonths(monthsIterator);

            //total full months (we are going to return this)
            int months = 0;

            //continue counting months until you reach or surpass the end date
            while (iterativeMonth < endDate)
            {
                months++;
                monthsIterator++;

                //we use the iterator applied against the start month 
                //to account for edge cases like a start date of 1/31/2019 and a 
                //deadline of 3/31/2019.
                //
                //when adding "1 month" to 1/31/2019, c# will return 2/28/2019, so when you 
                //iterate the next month after, it will be 3/28/2019 instead of 3/31/2019.
                iterativeMonth = startDate.AddMonths(monthsIterator);
            }

            //construct false "end date" with the same day of the month in the month immediately following the start date
            //get year and month of faux date
            int fauxIterator = 0;

            //this accounts for "lost month" when you have start days that are numerically larger than end days
            //example start: 02/27/2019; end: 04/07/2019
            if (startDate.Day > endDate.Day)
            {
                fauxIterator++;
            }

            // get the faux year and month.
            int fauxYear = startDate.AddMonths(fauxIterator).Year;
            int fauxMonth = startDate.AddMonths(fauxIterator).Month;

            //get the days in the faux month
            int fauxDaysInMonth = DateTime.DaysInMonth(fauxYear, fauxMonth);

            //for endDates that have a day value numerically larger than the number of days in a given month,
            //perform a "bonus" month to account for the month that is completely traversed
            //
            //example start: 02/27/2019; end: 04/07/2019
            bool bonus = false;
            if (endDate.Day > fauxDaysInMonth)
            {
                fauxIterator++;
                fauxYear = startDate.AddMonths(fauxIterator).Year;
                fauxMonth = startDate.AddMonths(fauxIterator).Month;
                bonus = true;
            }

            //reset faux days in month after first test
            fauxDaysInMonth = DateTime.DaysInMonth(fauxYear, fauxMonth);

            //get the faux date and total days between the start date
            //and the faux date
            //
            //this will include the traversed month if applicable
            DateTime faux = new DateTime(fauxYear, fauxMonth, endDate.Day, endDate.Hour, endDate.Minute, endDate.Second, endDate.Millisecond);

            //track the original faux day to handle 'lost days' if faux date is less than start date
            int originalFauxDay = faux.Day;

            //if faux is less than start date, advance the month to correct the days
            //this will only happen when fauxIterator == 0, but testing for 
            //that introduces other problems for legitimate close dates
            if (faux < startDate)
            {
                fauxIterator++;
                fauxYear = startDate.AddMonths(fauxIterator).Year;
                fauxMonth = startDate.AddMonths(fauxIterator).Month;
                //add the month to get the faux day as well. This is 
                //important if working with an edge case like 01/31
                int fauxDay = startDate.AddMonths(fauxIterator).Day;
                faux = new DateTime(fauxYear, fauxMonth, fauxDay, endDate.Hour, endDate.Minute, endDate.Second, endDate.Millisecond);
            }

            //if days were lost in the immediately preceeding if clause
            //correct for the lost days here by finding the number of lost days
            //
            //solves test case of
            //start: 1/31/2019 1200
            //end:   3/31/2019 0000
            int fauxCorrectionOffset = 0;
            if (originalFauxDay > faux.Day)
            {
                fauxCorrectionOffset = originalFauxDay - faux.Day;
            }

            int days = 0;
            days = (faux - startDate).Days + fauxCorrectionOffset;

            //order is important, so if a traversed month was included,
            //remove the traversed month days first
            if (bonus)
            {
                //since the faux date is currently on the second month (first after the traversed one)
                //skip back to the traversed month to remove its days
                faux = faux.AddMonths(-1);
                fauxDaysInMonth = DateTime.DaysInMonth(faux.Year, faux.Month);
                days = days - fauxDaysInMonth;
            }

            //prepare to continue calculations with the original faux month
            //these two lines will only affect the outcome if a bonus (traversed) month was 
            //included in the previous calculations
            faux = faux.AddMonths(1);
            fauxDaysInMonth = DateTime.DaysInMonth(faux.Year, faux.Month);

            //if endDate day is numerically higher than the number of days in the second month,
            //and the days remaining are more than are in the second faux month
            //remove the days of the second month
            if (endDate.Day >= fauxDaysInMonth && bonus && days >= fauxDaysInMonth)
            {
                days = days - fauxDaysInMonth;
            }

            //handles edge cases where a startDate and endDate are 
            //an exact number of months or years apart
            //
            //Ticks is also a part of the criteria so that when the dates are the same, 
            //months is not falsely iterated.
            if ((days == 0) &&
                ((endDate - startDate).Hours == 0) &&
                ((endDate - startDate).Minutes == 0) &&
                ((endDate - startDate).Seconds == 0) &&
                ((endDate - startDate).Milliseconds == 0) &&
                ((endDate - startDate).Ticks > 0))
            {
                months++;
            }

            //integer division to get number of whole years
            int years = months / 12;

            //mod months to get number of total months after years
            months = months % 12;

            //use timespan against original dates to 
            //compute hours, minutes, seconds, and milliseconds
            TimeSpan pureDiff = endDate - startDate;

            //save days in 'countdown month'
            //save the days in month. This is what the output is counting down from
            int daysInCountdownMonth = 0;
            if (startDate.Day >= endDate.Day && !(days == 0))
            {
                daysInCountdownMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            }
            else
            {
                daysInCountdownMonth = DateTime.DaysInMonth(startDate.AddMonths(-1).Year, startDate.AddMonths(-1).Month);
                if (daysInCountdownMonth < endDate.Day)
                {
                    //correct with offset
                    //this should account for situations where the end date day is numerically larger
                    //than the number of days in the preceeding month
                    int offset = endDate.Day - daysInCountdownMonth;
                    daysInCountdownMonth = daysInCountdownMonth + offset;
                }
            }

            return new TimeDifference(years, months, days, pureDiff.Hours, pureDiff.Minutes, pureDiff.Seconds, pureDiff.Milliseconds, daysInCountdownMonth);
        }
    }
}
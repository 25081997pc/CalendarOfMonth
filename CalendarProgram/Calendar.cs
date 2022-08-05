using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProgram
{
    public class Calendar
    {
        String[,] calendar = new String[6, 7];
        private String month;

        public void calendarSetup()
        {
            Console.WriteLine("Enter Month : ");
            month = Console.ReadLine().ToLower(CultureInfo.CurrentCulture);
            Console.WriteLine("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("% Java Calendar %");
            Console.WriteLine(month + " " + year);
            Console.WriteLine("-------------------------------");
            String weekName = "S\t" + "M\t" + "T\t" + "W\t" + "T\t" + "F\t" + "S\t";
            Console.WriteLine(weekName);
            Console.WriteLine("--------------------------------");
        }
        public void days()
        {
            Random random = new Random();
            int dayCount = 1;
            int numberOfDays = 0;
            if (month.Equals("january") || month.Equals("march") || month.Equals("may") ||
                month.Equals("july") || month.Equals("august") || month.Equals("october") || month.Equals("december"))
            {
                numberOfDays = 32;
            }
            else if (month.Equals("february"))
            {
                numberOfDays = 29;
            }
            else numberOfDays = 31;
            int rand = random.Next(7);
            for(int i=0; i<7; i++)
            {
                for(int j=0; j<7; j++)
                {
                    if(dayCount<numberOfDays)
                    {
                        String date = Convert.ToString(dayCount);
                        if(rand-- > 0)
                        {
                            calendar[i, j] = " ";
                        }
                        else
                        {
                            calendar[i, j] = date;
                            dayCount++;
                        }
                        Console.Write(calendar[i,j] + "\t");
                        if (j == 6)
                            Console.WriteLine();
                    }
                }
            }
        }
    }
}      
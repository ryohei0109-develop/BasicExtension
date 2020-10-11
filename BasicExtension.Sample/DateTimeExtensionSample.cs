using System;

namespace BasicExtension.Sample
{
    public class DateTimeExtensionSample
    {
        public void Run()
        {
            GetFirstDateOfMonthSample();
            GetLastDateOfMonthSample();
            GetFirstDateOfWeek();
            ToStringSample();
            DayCountSample();
        }

        private void GetFirstDateOfMonthSample()
        {
            DateTime arg1 = new DateTime(2020, 10, 10);
            DateTime result1 = arg1.GetFirstDateOfMonth();
            Console.WriteLine(result1);
            // => 10/1/2020 12:00:00 AM
        }

        private void GetLastDateOfMonthSample()
        {
            DateTime arg1 = new DateTime(2020, 10, 10);
            DateTime result1 = arg1.GetLastDateOfMonth();
            Console.WriteLine(result1);
            // => 10/31/2020 12:00:00 AM
        }

        private void GetFirstDateOfWeek()
        {
            DateTime arg1 = new DateTime(2020, 10, 10);
            DateTime result1 = arg1.GetFirstDateOfWeek();
            Console.WriteLine(result1);
            // => 10/04/2020 12:00:00 AM
        }

        private void ToStringSample()
        {
            DateTime? arg1 = new DateTime(2020, 10, 10);
            string result1 = arg1.ToString("yyyy MM dd");
            Console.WriteLine(result1);
            // => "2020 10 10"

            DateTime? arg2 = null;
            string result2 = arg2.ToString("yyyy MM dd");
            Console.WriteLine(result2);
            // => ""
            // Not happend Exception.
        }

        private void DayCountSample()
        {
            DateTime startDate = new DateTime(2020, 10, 1);
            DateTime endDate = new DateTime(2020, 10, 14);

            int result1 = startDate.DayCount(endDate, true);
            Console.WriteLine(result1);
            // => 14

            int result2 = startDate.DayCount(endDate, false);
            Console.WriteLine(result2);
            // => 13
        }
    }
}

using System;

namespace BasicExtension.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start. {DateTime.Now}");

            BoolExtensionSample boolExtensionSample = new BoolExtensionSample();
            boolExtensionSample.Run();

            DateTimeExtensionSample dateTimeExtensionSample = new DateTimeExtensionSample();
            dateTimeExtensionSample.Run();

            DoubleExtensionSample doubleExtensionSample = new DoubleExtensionSample();
            doubleExtensionSample.Run();

            IEnumerableExtensionSample enumerableExtensionSample = new IEnumerableExtensionSample();
            enumerableExtensionSample.Run();

            IntExtensionSample intExtensionSample = new IntExtensionSample();
            intExtensionSample.Run();

            ObjectExtensionSample objectExtensionSample = new ObjectExtensionSample();
            objectExtensionSample.Run();

            StringExtensionSample stringExtensionSample = new StringExtensionSample();
            stringExtensionSample.Run();

            UrlExtensionSample urlExtensionSample = new UrlExtensionSample();
            urlExtensionSample.Run();

            Console.WriteLine($"End. {DateTime.Now}");
            Console.ReadLine();
        }
    }
}

using System;

namespace BasicExtension.Sample
{
    public class DoubleExtensionSample
    {
        public void Run()
        {
            CheckBetweenSample();
        }

        private void CheckBetweenSample()
        {
            double arg1 = 1.5;
            bool result1 = arg1.IsBetween(1, 10);
            Console.WriteLine(result1);
            // => true
        }
    }
}

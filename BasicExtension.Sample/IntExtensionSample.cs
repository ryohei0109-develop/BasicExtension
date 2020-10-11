using System;

namespace BasicExtension.Sample
{
    public class IntExtensionSample
    {
        public void Run()
        {
            IsBetweenSample();
        }

        private void IsBetweenSample()
        {
            int arg1 = 5;
            bool result1 = arg1.IsBetween(1, 10);
            Console.WriteLine(result1);
            // => true
        }
    }
}

using System;

namespace BasicExtension.Sample
{
    public class BoolExtensionSample
    {
        public void Run()
        {
            ToStringSample();
        }

        private void ToStringSample()
        {
            bool arg1 = true;
            string result1 = arg1.ToString("OK", "NG");
            Console.WriteLine(result1);
            // => "OK"

            bool arg2 = false;
            string result2 = arg2.ToString("OK", "NG");
            Console.WriteLine(result2);
            // => "NG"
        }
    }
}

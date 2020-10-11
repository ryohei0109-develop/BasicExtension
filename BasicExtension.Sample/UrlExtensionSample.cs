using System;

namespace BasicExtension.Sample
{
    public class UrlExtensionSample
    {
        public void Run()
        {
            ShapingSamle();
        }

        private void ShapingSamle()
        {
            string arg1 = "https://google.co.jp//hoge/piiyo/";
            string resutl1 = arg1.Shaping();
            Console.WriteLine(resutl1);
            // => https://google.co.jp/hoge/piiyo/
        }
    }
}

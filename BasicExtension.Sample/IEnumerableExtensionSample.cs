using System;
using System.Collections.Generic;

namespace BasicExtension.Sample
{
    public class IEnumerableExtensionSample
    {
        public void Run()
        {
            ContainsDuplicateSample();
            ToCommaStringSample();
        }

        private void ContainsDuplicateSample()
        {
            List<string> arg1 = new List<string>()
            {
                "hoge", "fuga", "hoge"
            };
            bool result1 = arg1.ContainsDuplicate();
            Console.WriteLine(result1);
            // => true
        }

        private void ToCommaStringSample()
        {
            List<string> arg1 = new List<string>()
            {
                "hoge", "fuga", "hoge"
            };

            string result1 = arg1.ToStringJoin(",");
            Console.WriteLine(result1);
            // => "hoge,fuga,hoge"
            // * Can use in method chain.
        }
    }
}

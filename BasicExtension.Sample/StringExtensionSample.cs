using System;
using System.Collections.Generic;

namespace BasicExtension.Sample
{
    public class StringExtensionSample
    {
        public void Run()
        {
            ToStringOrEmptySample();
            ToStringOrDefaultValueSample();
            ToIntOrZeroSample();
            ToIntOrDefaultSample();
            ToIntOrNullSample();
            ToBoolSample();
            ToBoolOrDefaultSample();
            SplitSample();
            SplitWithNullCheckSample();
            TrimNullCheckSample();
            ReplaceWithNullCheckSample();
            RegexReplaceSample();
            RemoveRightSample();
            ToDateTimeSample();
            ToObjectSample();
            CreateDirectorySample();
            CountSample();
            ParseRegexSample();
            SubstringExtensionSample();
        }

        private void ToStringOrEmptySample()
        {
            string arg1 = "test";
            string result1 = arg1.ToStringOrEmpty();
            Console.WriteLine(result1);
            // => "test"

            string arg2 = null;
            string result2 = arg2.ToStringOrEmpty();
            Console.WriteLine(result2);
            // => ""
        }

        private void ToStringOrDefaultValueSample()
        {
            string arg1 = "test";
            string result1 = arg1.ToStringOrDefaultValue("hoge");
            Console.WriteLine(result1);
            // => "test"

            string arg2 = null;
            string result2 = arg2.ToStringOrDefaultValue("hoge");
            Console.WriteLine(result2);
            // => "hoge"
        }

        private void ToIntOrZeroSample()
        {
            string arg1 = "1";
            int result1 = arg1.ToIntOrZero();
            Console.WriteLine(result1);
            // => 1

            string arg2 = "test";
            int result2 = arg2.ToIntOrZero();
            Console.WriteLine(result2);
            // => 0
        }

        private void ToIntOrDefaultSample()
        {
            string arg1 = "1";
            int result1 = arg1.ToIntOrDefault(10);
            Console.WriteLine(result1);
            // => 1

            string arg2 = "test";
            int result2 = arg2.ToIntOrDefault(10);
            Console.WriteLine(result2);
            // => 10
        }

        private void ToIntOrNullSample()
        {
            string arg1 = "1";
            int? result1 = arg1.ToIntOrNull();
            Console.WriteLine(result1);
            // => 1

            string arg2 = "test";
            int? result2 = arg2.ToIntOrNull();
            Console.WriteLine(result2);
            // => null
        }

        private void ToBoolSample()
        {
            string arg1 = "1";
            bool result1 = arg1.ToBool("1");
            Console.WriteLine(result1);
            // => true

            string arg2 = "0";
            bool result2 = arg2.ToBool("1");
            Console.WriteLine(result2);
            // => false
        }

        private void ToBoolOrDefaultSample()
        {
            string arg1 = "true";
            bool result1 = arg1.ToBoolOrDefault(false);
            Console.WriteLine(result1);
            // => true

            string arg2 = null;
            bool result2 = arg2.ToBoolOrDefault(false);
            Console.WriteLine(result2);
            // => false
        }

        private void SplitSample()
        {
            string arg1 = "hoge fuga piyo";
            string[] result1 = arg1.Split(" ");
            Console.WriteLine(result1);
            // => ["hoge", "fuga", "piyo"]

            string arg2 = "Sample1Sample2Sample3";
            string[] result2 = arg2.Split("Sample");
            Console.WriteLine(result2);
            // => ["1", "2", "3"]
        }

        private void SplitWithNullCheckSample()
        {
            string arg1 = "hoge,fuga,piyo";
            List<string> result1 = arg1.SplitWithNullCheck(',');
            Console.WriteLine(result1);
            // => ["hoge", "fuga", "piyo"]

            string arg2 = null;
            List<string> result2 = arg2.SplitWithNullCheck(',');
            Console.WriteLine(result2);
            // => []
            // Not happend Exception.
        }

        private void TrimNullCheckSample()
        {
            string arg1 = " hoge ";
            string result1 = arg1.TrimNullCheck();
            Console.WriteLine(result1);
            // => "hoge"

            string arg2 = null;
            string result2 = arg2.TrimNullCheck();
            Console.WriteLine(result2);
            // => null
            // Not happend Exception.
        }

        private void ReplaceWithNullCheckSample()
        {
            string arg1 = "hoga,fuga,piyio";
            string result1 = arg1.ReplaceWithNullCheck("hoga", "hoge");
            Console.WriteLine(result1);
            // => ["hoge", "fuga", "piyo"]

            string arg2 = null;
            string result2 = arg2.ReplaceWithNullCheck("hoga", "hoge");
            Console.WriteLine(result2);
            // => null
            // Not happend Exception.
        }

        private void RegexReplaceSample()
        {
            string arg1 = "090909";
            string result1 = arg1.RegexReplace("\\d", "9");
            Console.WriteLine(result1);
            // => "999999"

            string arg2 = null;
            string result2 = arg2.RegexReplace("\\d", "9");
            Console.WriteLine(result2);
            // => null
            // Not happend Exception.
        }

        private void RemoveRightSample()
        {
            string arg1 = "hogehoge";
            string result1 = arg1.RemoveRight(4);
            Console.WriteLine(result1);
            // => "hoge"

            string arg2 = "fugafuga";
            string result2 = arg2.RemoveRight(10);
            Console.WriteLine(result2);
            // => ""
        }

        private void ToDateTimeSample()
        {
            string arg1 = "2020 10 01";
            DateTime? result1 = arg1.ToDateTime("yyyy MM dd");
            Console.WriteLine(result1);
            // => "10/1/2020 12:00:00 AM"

            string arg2 = null;
            DateTime? result2 = arg2.ToDateTime("yyyy MM dd");
            Console.WriteLine(result2);
            // => null
        }

        private void ToObjectSample()
        {
            string arg1 = "{\"Id\":1,\"Name\":\"fuga\"}";
            SampleModel result1 = arg1.ToObject<SampleModel>();
            Console.WriteLine(result1);
            // => Convert complete.

            string arg2 = null;
            SampleModel result2 = arg2.ToObject<SampleModel>();
            Console.WriteLine(result2);
            // => null
        }

        private void CreateDirectorySample()
        {
            string arg1 = "C:¥/hoge/fuga";
            arg1.CreateDirectory();
            // Can create directory.
        }

        private void CountSample()
        {
            string arg1 = "hogefugapiyo";
            int result1 = arg1.Count("g");
            Console.WriteLine(result1);
            // => 2

            string arg2 = null;
            int result2 = arg2.Count("g");
            Console.WriteLine(result2);
            // => 0
        }

        private void ParseRegexSample()
        {
            string arg1 = "hoge1fugapiyo";
            string result1 = arg1.ParseRegex("(\\d)");
            Console.WriteLine(result1);
            // => "1"

            string arg2 = "";
            string result2 = arg2.ParseRegex("(\\d)");
            Console.WriteLine(result2);
            // => ""
        }

        private void SubstringExtensionSample()
        {
            string arg1 = "hogepiyofuga";
            string result1 = arg1.SubstringExtension(0, 4);
            Console.WriteLine(result1);
            // => "hoge"

            string arg2 = "hogepiyiofuga";
            string result2 = arg2.SubstringExtension(100, 10);
            Console.WriteLine(result2);
            // => ""
            // Not happend Exception.
        }

        private class SampleModel
        {
            public int Id
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }
        }
    }
}

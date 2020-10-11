using System;

namespace BasicExtension.Sample
{
    public class ObjectExtensionSample
    {
        public void Run()
        {
            ToJsonSample();
            TryToJson();
        }

        private void ToJsonSample()
        {
            SampleModel arg1 = new SampleModel();
            arg1.Id = 1;
            arg1.Name = "hoge";

            string result1 = arg1.ToJson();
            Console.WriteLine(result1);
            // => "{"Id":1,"Name":"hoge"}"

            SampleModel arg2 = null;
            string result2 = arg2.ToJson();
            Console.WriteLine(result2);
            // => ""
        }

        private void TryToJson()
        {
            SampleModel arg1 = new SampleModel();
            arg1.Id = 1;
            arg1.Name = "hoge";

            bool isComplete1 = arg1.TryToJson(out string result1);
            Console.WriteLine(isComplete1);
            // => true
            Console.WriteLine(result1);
            // => "{"Id":1,"Name":"hoge"}"

            SampleModel arg2 = null;
            bool isComplete2 = arg2.TryToJson(out string result2);
            Console.WriteLine(isComplete2);
            // => false
            Console.WriteLine(result2);
            // => null
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

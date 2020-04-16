using System;

namespace pattern_strategy
{
    public class BlackWhiteFilter : Filter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
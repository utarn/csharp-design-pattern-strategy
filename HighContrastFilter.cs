using System;

namespace pattern_strategy
{
    public class HighContrastFilter : Filter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine("Applying high contrast filter");
        }
    }
}
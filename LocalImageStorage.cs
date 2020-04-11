using System;

namespace pattern_strategy
{
    public class LocalImageStorage
    {
        private string _compressor;
        private string _filter;

        public void Store(string fileName)
        {
            Console.WriteLine($"Storing image {fileName}");
        }
    }
}
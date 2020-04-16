using System;

namespace pattern_strategy
{
    public class PngCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing PNG format");
        }
    }
}
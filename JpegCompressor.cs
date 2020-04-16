using System;

namespace pattern_strategy
{
    public class JpegCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing JPEG format");
        }
    }
}
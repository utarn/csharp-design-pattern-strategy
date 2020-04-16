using System;

namespace pattern_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageStorage imgStorage = new CloudImageStorage(new JpegCompressor(), new BlackWhiteFilter());
            imgStorage.Store("abc");
        }
    }
}

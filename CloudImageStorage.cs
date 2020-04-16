using System;

namespace pattern_strategy
{
    public class CloudImageStorage : ImageStorage
    {
        public CloudImageStorage(Compressor compressor, Filter filter)
            : base(compressor, filter)
        {
        }

        public override void Store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Filter(fileName);
            Console.WriteLine($"Storing image {fileName} to cloud.");
        }
    }
}
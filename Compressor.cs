namespace pattern_strategy
{
    public interface Compressor
    {
        // byte[] Compress(byte[] image);
        void Compress(string fileName);
    }
}
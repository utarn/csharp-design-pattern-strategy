using System;

namespace pattern_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var imgStorage = new LocalImageStorage();
            imgStorage.Store("abc");
        }
    }
}

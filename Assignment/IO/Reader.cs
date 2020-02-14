namespace Assignment.IO
{
    using System;

    public class Reader : IReader
    {
        public int Read()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

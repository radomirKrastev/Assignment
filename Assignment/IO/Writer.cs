namespace Assignment.IO
{
    using System;

    public class Writer : IWriter
    {
        public void Write(string output)
        {
            Console.Write(output);
        }
    }
}

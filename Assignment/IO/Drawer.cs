namespace Assignment.IO
{
    using System;

    public class Drawer : IDrawer
    {
        public void Draw(string output)
        {
            Console.Write(output);
        }
    }
}

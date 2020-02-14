namespace Assignment
{
    using IO;

    public class Program
    {
        public static void Main()
        {
            var reader = new Reader();
            var drawer = new Drawer();
            var engine = new Engine(reader, drawer);

            engine.Run();
        }
    }
}

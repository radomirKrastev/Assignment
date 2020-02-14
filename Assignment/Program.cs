namespace Assignment
{
    using IO;

    public class Program
    {
        public static void Main()
        {
            var reader = new Reader();
            var drawer = new Writer();
            var engine = new Engine(reader, drawer);

            engine.Run();
        }
    }
}

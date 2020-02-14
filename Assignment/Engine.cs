namespace Assignment
{
    using IO;
    using System;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            try
            {
                this.writer.Write("N = ");
                var logoSize = this.reader.Read();
                var logo = new Logo(logoSize);
                this.writer.Write(logo.ToString());
            }
            catch (ArgumentException ae)
            {
                this.writer.Write(ae.Message);
                this.writer.Write(Environment.NewLine);
                this.Run();
            }
        }
    }
}

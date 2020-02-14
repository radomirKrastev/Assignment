namespace Assignment
{
    using IO;

    public class Engine : IEngine
    {
        private IReader reader;
        private IDrawer drawer;

        public Engine(IReader reader, IDrawer drawer)
        {
            this.reader = reader;
            this.drawer = drawer;
        }

        public void Run()
        {
            this.drawer.Draw("N = ");
            var logoSize = this.reader.Read();
            var logo = new Logo(logoSize);
            this.drawer.Draw(logo.ToString());
        }
    }
}

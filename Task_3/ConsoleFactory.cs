namespace Task_3
{
    public class ConsoleFactory : IAbstractFactory
    {
        public IScreen CreateScreen()
        {
            return new ConsoleScreen();
        }

        public IProcessor CreateProcessor()
        {
            return new AMDProcessor();
        }

        public ICamera CreateCamera()
        {
            return new SonyCamera();
        }
    }
}
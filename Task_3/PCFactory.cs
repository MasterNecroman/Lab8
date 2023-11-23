namespace Task_3
{
    public class PCFactory : IAbstractFactory
    {
        public IScreen CreateScreen()
        {
            return new DesktopScreen();
        }

        public IProcessor CreateProcessor()
        {
            return new IntelProcessor();
        }

        public ICamera CreateCamera()
        {
            return new SonyCamera();
        }
    }
}
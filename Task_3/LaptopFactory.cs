namespace Task_3
{
    public class LaptopFactory : IAbstractFactory
    {
        public IScreen CreateScreen()
        {
            return new LaptopScreen();
        }

        public IProcessor CreateProcessor()
        {
            return new IntelProcessor();
        }

        public ICamera CreateCamera()
        {
            return new CanonCamera();
        }
    }
}
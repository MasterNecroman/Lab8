namespace Task_3
{
    public interface IAbstractFactory
    {
        IScreen CreateScreen();
        IProcessor CreateProcessor();
        ICamera CreateCamera();
    }
}
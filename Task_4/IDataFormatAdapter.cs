namespace Task_4
{
    public interface IDataFormatAdapter
    {
        void ConvertData(IDataTemplate sourceTemplate, IDataTemplate targetTemplate);
    }
}
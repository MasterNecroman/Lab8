namespace Task_1
{
    public class DisplayHelper
    {
        public void DisplayHeading(string heading)
        {
            Console.WriteLine(heading);
        }

        public void DisplayMessage(string message, bool newLine = true)
        {
            Console.Write(message);
            if (newLine)
            {
                Console.WriteLine();
            }
        }

        public void DisplayEmptyLine()
        {
            Console.WriteLine();
        }
    }
}
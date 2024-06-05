namespace Boundaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // doesn't check if the values given are integers --> further improve with a while loop
            Console.WriteLine("Choose one integer:");
            int firstBoundary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose another integer:");
            int secondBoundary = Convert.ToInt32(Console.ReadLine());

            // determine the min and max from the two integers given
            int max;
            int min;

            if (firstBoundary > secondBoundary)
            {
                max = firstBoundary;
                min = secondBoundary;
            }
            else
            {
                max = secondBoundary;
                min = firstBoundary;
            }

            Console.WriteLine("Choose a final integer:");
            int FinalNumber = Convert.ToInt32(Console.ReadLine());

            if (FinalNumber <= max && FinalNumber >= min)
            {
                Console.WriteLine($"{Environment.NewLine}Your final number {FinalNumber} is in the boundaries min {min} et max {max} that you've set.");
            }
            else if (FinalNumber > max)
            {
                Console.WriteLine($"{Environment.NewLine}Limit1 (minimum): {min}{Environment.NewLine}Limit2 (maximum): {max}{Environment.NewLine}Your final number: {FinalNumber}{Environment.NewLine}You have entered {FinalNumber} which is greater than {max}, which is the maximum.{Environment.NewLine}Resulting integer: {max}");
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Limit1 (minimum): {min}{Environment.NewLine}Limit2 (maximum): {max}{Environment.NewLine}Your final number: {FinalNumber}{Environment.NewLine}You have entered {FinalNumber} which is lower than {min}, which is the minimum.{Environment.NewLine}Resulting integer: {min}");
            }
        }
    }
}

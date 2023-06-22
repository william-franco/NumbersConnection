using NumbersConnection;

namespace NumbersConnection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IValidator validator = new ValidatorImpl();

            Console.WriteLine("Enter the value of the number of connections:");
            int numberOfConnections = validator.ValidateInput(Console.ReadLine()!);

            Network network = new Network(numberOfConnections);

            Console.WriteLine("\nEnter the number of times you want to connect the numbers:");
            int numberOfTimes = validator.ValidateInput(Console.ReadLine()!);

            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine($"\nEnter value first value of {i + 1} connection:");
                int firstValue = validator.ValidateInput(Console.ReadLine()!);

                Console.WriteLine($"Enter value second value of {i + 1} connection:");
                int secondValue = validator.ValidateInput(Console.ReadLine()!);

                network.Connect(firstValue, secondValue);
            }

            Console.WriteLine("\nEnter the value of the first number to check if it is connected:");
            int firstNumberToCheck = validator.ValidateInput(Console.ReadLine()!);

            Console.WriteLine("Enter the value of the second number to check if it is connected:");
            int secondNumberToCheck = validator.ValidateInput(Console.ReadLine()!);

            bool isConnected = network.Query(firstNumberToCheck, secondNumberToCheck);

            Console.WriteLine($"\nElements are connected? {isConnected}");
        }
    }
}

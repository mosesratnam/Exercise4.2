namespace Exercise4._2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to Exercise 4.2 - Times Table");
        Console.WriteLine("=================================");
        Console.WriteLine("");

        Console.Write("Please type a number greater than 1: ");
        int userInput;
        int result;
        if(int.TryParse(Console.ReadLine(), out userInput)){
            int[] numbers = new int[userInput];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach (int number in numbers)
            {
                if(number > 1){
                    Console.WriteLine("");
                    Console.WriteLine("{0} times-table", number);
                    for (int i = 1;i <= 12; i++) 
                    {
                        result = i * number;
                        Console.WriteLine("{0} * {1} = {2}", i, number, result);
                    } 
                }                 
            }
        }
    }
}

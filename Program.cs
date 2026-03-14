// See https://aka.ms/new-console-template for more information
// An app for APBD course

using apbd_cw1_git_s32529.features;

    Console.WriteLine("Simple calculator! Select mode:");
    Console.WriteLine("1 - Standard calculator");
    Console.WriteLine("2 - Advanced calculator");
    char wybor = char.Parse(Console.ReadLine());
    if (wybor == '2')
    {
        Console.WriteLine("Enter integers (each on a new line). Enter ‘END’ to finish.");
        List<int> numbers = new List<int>();
    
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToUpper() == "END") break;
        
            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("This is not a valid integer. Please try again.");
            }
        }

        int[] values = numbers.ToArray();
        while (true)
        {
            Console.WriteLine("Select operation: a - Average, b - Max, c - Min");
            char advChoice = char.Parse(Console.ReadLine());
        
            if (advChoice == 'a') { 
                Console.WriteLine("The average is: " + Statistics.CalculateAverage(values)); 
                break; 
            }
            else if (advChoice == 'b') { 
                Console.WriteLine("The maximum value is: " + Statistics.CalculateMax(values)); 
                break; 
            }
            else if (advChoice == 'c') { 
                Console.WriteLine("The minimum value is: " + Statistics.CalculateMin(values)); 
                break; 
            }
            else { 
                Console.WriteLine("Invalid choice. Please try again."); 
            }
        }
    }
    else if (wybor == '1')
    {
        Console.WriteLine("Please enter your input in the following format:");
        Console.WriteLine("[number_1]");
        Console.WriteLine("[operation ('+', '-', '*', '/', '^', '%')]");
        Console.WriteLine("[number_2]");

        decimal arg1 = decimal.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());
        decimal arg2 = decimal.Parse(Console.ReadLine());

        Calculator calc = new Calculator(arg1, arg2, operation);

        Console.WriteLine("Twój wynik to: " + calc.Result());
}
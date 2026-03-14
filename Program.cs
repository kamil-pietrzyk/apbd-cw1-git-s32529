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
        Console.WriteLine("The average is: " + Statistics.CalculateAverage(values));
        Console.WriteLine("The maximum value is: " + Statistics.CalculateMax(values));
        Console.WriteLine("The minimum value is: " + Statistics.CalculateMax(values));
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
// See https://aka.ms/new-console-template for more information

using apbd_cw1_git_s32529.features;

Console.WriteLine("Simple calculator!");
Console.WriteLine("Please enter your input in the following format:");
Console.WriteLine("[number_1]");
Console.WriteLine("[operation ('+', '-', '*', '/')]");
Console.WriteLine("[number_2]");

decimal arg1 = decimal.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());
decimal arg2 = decimal.Parse(Console.ReadLine());

Calculator calc = new Calculator(arg1, arg2, operation);

Console.WriteLine("Twój wynik to: " + calc.Result());
using static System.Console;
WriteLine("------------------------------");
SectionTitile("Console Calculator");
WriteLine("------------------------------");
WriteLine("Ready to use!");
do
{
double FNum = 0;
double SNum = 0;
Write("Enter the first number: ");
FNum= Convert.ToDouble(Console.ReadLine());

Write("Enter the second number: ");
SNum = Convert.ToDouble(Console.ReadLine());

Write("Choose an operation -> (+  -  * /): ");
string? Oper = ReadLine();

    switch (Oper)
    {
        case "+":
            ResultTitle($"The result is: {FNum} + {SNum} = {FNum + SNum}");
            break;
        case "-":
            ResultTitle($"The result is: {FNum} - {SNum} = {FNum - SNum}");
            break;
        case "*":
            ResultTitle($"The result is: {FNum} * {SNum} = {FNum * SNum}");
            break;
        case "/":
            ResultTitle($"The result is: {FNum} / {SNum} = {FNum / SNum}");
            break;

    }
    WriteLine();
    Write("Do you want to Continue? Y/N: ");
} while (ReadLine()?.ToUpper() == "Y");
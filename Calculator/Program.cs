Console.WriteLine("Hello!");

int firstNumber, secondNumber;
string operation;

Console.WriteLine("Input the first number:");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string selectedOption = Console.ReadLine().ToUpper();


string result = formatOperation(selectedOption);
Console.WriteLine(result);
Console.WriteLine("Press any key to continue");
Console.ReadLine();



string formatOperation(string selectedOption)
{
    if(selectedOption == "A")
    {
        return firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + sum();
    }
    if(selectedOption == "S")
    {
        return firstNumber.ToString() + " - " + secondNumber.ToString() + " = " + sub();
    }
    if (selectedOption == "M")
    {
        return firstNumber.ToString() + " * " + secondNumber.ToString() + " = " + multiply();
    }
    else
    {
        return "Invalid option";
    }
}

int sum()
{
    return firstNumber + secondNumber;
}

int sub()
{
    return firstNumber - secondNumber;
}

int multiply()
{
    return firstNumber * secondNumber;
}


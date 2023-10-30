internal class Program
{
    static string[] options = { "S", "A", "R", "E" };
    static List<string> allTodos = new List<string>();
    static string userInput = "";
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        PrintOptions();

    }

    private static void ShowAllTodos()
    {
        for (int i = 0; i < allTodos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {allTodos[i]}");
        }
        Console.WriteLine();
    }

    private static void GetAllTodos(List<string> allTodos)
    {
        if (allTodos.Count == 0)
        {
            Console.WriteLine("No TODO's added yet");
        }
        Console.WriteLine();
        ShowAllTodos();
        PrintOptions();
    }

    private static void AddTodo()
    {
        bool isDescriptionValid;
        string description;
        do
        {
            isDescriptionValid = true;
            Console.WriteLine("Enter the TODO description");
            description = Console.ReadLine();
            if (description == "")
            {
                Console.WriteLine("The description cannot be empty");
                isDescriptionValid = false;
            }
            if (allTodos.Contains(description)){
                Console.WriteLine("The description must be unique");
                isDescriptionValid = false;
            }

        } while (!isDescriptionValid);

        allTodos.Add(description);
        Console.WriteLine($"TODO successfully added: {description}\n");
        PrintOptions();

    }

    private static void RemoveTodo()
    {
        bool validInput = false;
        string input;
        do
        {
            if (allTodos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet");
                PrintOptions();
                continue;
            }
            validInput = true;

            Console.WriteLine("Select the index of the Todo you want to remove:");
            Console.WriteLine("(Write 0 if you want to exit)");
            ShowAllTodos();
            input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Selected index cannot be empty");
                validInput = false;
            }

            if(int.Parse(input) == 0)
            {
                PrintOptions();
            }

            if (int.Parse(input) > allTodos.Count || int.Parse(input) < 0)
            {
                Console.WriteLine("The given index is not valid");
                validInput = false;
            }

            if (validInput)
            {
                int index = int.Parse(input);
                Console.WriteLine($"Todo removed: {allTodos[index - 1]}");
                allTodos.Remove(allTodos.ElementAt(index - 1));
                PrintOptions();
            }
            

        } while (!validInput);
    }
    private static void PrintOptions()
    {
        bool isUserInputNotValid = true;

        do
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit\n");
            userInput = Console.ReadLine().ToUpper();
            isUserInputNotValid = !(options.Contains(userInput));
            if (isUserInputNotValid)
            {
                Console.WriteLine("Incorrect input");
            }

        } while (isUserInputNotValid);

        switch (userInput)
        {
            case "S":
                GetAllTodos(allTodos);
                break;
            case "A":
                AddTodo();
                break;
            case "R":
                RemoveTodo();
                break;
            case "E":
                Environment.Exit(0);
                break;
        }

        Console.ReadKey();

    }
}
bool runProgram = true;
int input = 0;
while (runProgram)
{
    while (true)
    {
        Console.WriteLine("Please enter an integer.");

        try
        {
            input = int.Parse(Console.ReadLine());
            if(input <= 0)
            {
                Console.WriteLine("Use only whole numbers that are positive and greater than 0.");
            }
            else
            {
                break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Only use whole numbers that are positive with no letters or symbols.");
        }
    }
    Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} |", "Number", "Square", "Cube"));
    Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} |", "------", "------", "----"));
    for (int i=1; i<=input; i++)
    {
        Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} |", i, i*i, i*i*i));
    }
    while(true)
    {
        Console.WriteLine("Continue? (y/n)");
        string response = Console.ReadLine();
        if(response== "y")
        {
            break;
        }else if(response== "n")
        {
            Console.WriteLine("Have a good day.");
            runProgram= false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input only use y or n.");
        }
    }
    
}
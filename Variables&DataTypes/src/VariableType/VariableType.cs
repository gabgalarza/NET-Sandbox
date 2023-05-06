class VariableType
{
    static string firstName { get; set; } = string.Empty;
    static char userOption;
    static int gameScore;
    static decimal particlesPerMillion;
    static bool processedCustomer;

    public void OutputVariables()
    {
        firstName = "Bob";
        userOption = 'b';
        gameScore = 80;
        particlesPerMillion = 23.32m;
        processedCustomer = true;

        Console.WriteLine(firstName);
        Console.WriteLine(userOption);
        Console.WriteLine(gameScore);
        Console.WriteLine(particlesPerMillion);
        Console.WriteLine(processedCustomer);

        // Using string interpolation expressions
        string name = "Bob";
        int number = 3;
        decimal decimalNum = 34.4m;

        Console.WriteLine(
            $"Hello, {name}! You have {number} in your inbox. The temperature is {decimalNum} celsius."
        );
    }
}

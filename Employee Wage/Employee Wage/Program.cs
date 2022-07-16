// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Problem");
{
    int IS_FULL_TIME = 1;

    Random random = new Random();
    int empcheck = random.Next(0, 2);
    if (empcheck == IS_FULL_TIME)
    {
        Console.WriteLine("Employee is Present");
    }
    else
    {
        Console.WriteLine("Employee is Absent");

    }
}
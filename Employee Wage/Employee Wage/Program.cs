// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Problem");
{
    int IS_FULL_TIME = 1;
    int EMP_RATE_PER_HOUR = 20;

    int emphours = 0;
    int empwage = 0;

    Random random = new Random();
    int empcheck = random.Next(0, 2);
    if (empcheck == IS_FULL_TIME)
    {
        emphours = 8;
    }
    else
    {
        emphours = 0;

    }
    empwage = emphours * EMP_RATE_PER_HOUR;
    Console.WriteLine("Employee wage is : " + empwage);
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Problem");
{
    int IS_PART_TIME = 1;
    int IS_FULL_TIME = 2;
    int EMP_RATE_PER_HOUR = 20;

    int emphours = 0;
    int empwage = 0;

    Random random = new Random();
    int empcheck = random.Next(0, 3);
    if (empcheck == IS_PART_TIME)
    {
        emphours = 4;
    }
    else if (empcheck == IS_FULL_TIME)
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

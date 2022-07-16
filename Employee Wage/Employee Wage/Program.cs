class program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;

    static void Main(string[] args)
    {

        int emphours = 0;
        int empwage = 0;

        Random random = new Random();
        int empcheck = random.Next(0, 3);
        switch (empcheck)
        {
            case IS_PART_TIME:
                emphours = 4;
                break;
            case IS_FULL_TIME:
                emphours = 8;
                break;
            default:
                emphours = 0;
                break;

        }

        empwage = emphours * EMP_RATE_PER_HOUR;
        Console.WriteLine("Employee wage is : " + empwage);
    }
}
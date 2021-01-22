using System;
class EmployeeWage
{
    public static int IS_PRESENT = 1;
    public static int FULL_TIME = 1;
    public static int total_hour = 0;
    public static int WAGE_PER_HOUR = 20;
    public static void Check_Attandance()
    {
        Random random = new Random();
        int check_Attandance = random.Next(0, 2);
        if (IS_PRESENT == check_Attandance)
            Console.WriteLine("Employee is Present !");
        else
            Console.WriteLine("Employee is not Present!");
    }
    public static void Daily_Wage()
    {
        Random random = new Random();
        int check_Attandance = random.Next(0, 2);
        int check_hour = random.Next(0, 2);
        if (IS_PRESENT == check_Attandance)
        {
            Console.WriteLine("Employee is Present !");
            if (FULL_TIME == check_hour)
                total_hour = 8;
            else
                total_hour = 4;
        }
        else
        {
            Console.WriteLine("Employee is not Present!");
        }
        Console.WriteLine("Employee Daily Wage" + " " + total_hour * WAGE_PER_HOUR);

    }
    public static void Monthly_Wage()
    {
        for (int day = 0; day < 30; day++)
        {
            Random random = new Random();
            int check_Attandance = random.Next(0, 2);
            int check_hour = random.Next(0, 2);
            switch (check_Attandance)
            {
                case 0:
                    Console.WriteLine("Employee is not Present!");
                    break;
                case 1:
                    Console.WriteLine("Employee Present!");
                    switch (check_hour)
                    {
                        case 0:
                            Console.WriteLine("Employee Present Half Time");
                            total_hour += 4;
                            break;
                        case 1:
                            Console.WriteLine("Employee Present Full Time");
                            total_hour += 8;
                            break;

                    }
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("Employee Monthly Wage" + " " + total_hour * WAGE_PER_HOUR);
    }
    static void Main(string[] args)
    {
        Check_Attandance();
        Daily_Wage();
        Monthly_Wage();
    }
}



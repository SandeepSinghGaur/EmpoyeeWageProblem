using System;
class EmployeeWage
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate Daily Employee Wage");
        int IS_PRESENT = 1;
        int IS_FULL_TIME = 1;
        int WAGE_PER_HOUR = 20;
        int total_hour = 0;
        Random random = new Random();
        int check_Attandance = random.Next(0, 2);
        int calculate_hour = random.Next(0, 2);
        if (check_Attandance ==IS_PRESENT)
        {
            if (calculate_hour ==IS_FULL_TIME)
                total_hour = 8;
            else
                total_hour = 4;
        }
        else
        {
            Console.WriteLine("NO ! Employess is Not Present");
        }
        int Wage = total_hour * WAGE_PER_HOUR;
        Console.WriteLine("Employee Daily Wage" + " " + Wage);
    }
}

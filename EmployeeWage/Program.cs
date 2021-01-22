using System;
class EmployeeWage
{
    public static void Monthly_Wage(string company_name,int WAGE_PER_HOUR)
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
        Console.WriteLine("Employee is Working "+" "+company_name+"in this Company);
        Console.WriteLine("Employee Monthly Wage" + " " + total_hour * WAGE_PER_HOUR);
    }
    static void Main(string[] args)
    {
        string company_name = Console.ReadLine();
        int WAGE_PER_HOUR = Convert.ToInt32(ReadLine());
        Monthly_Wage(company_name,WAGE_PER_HOUR);
    }
}



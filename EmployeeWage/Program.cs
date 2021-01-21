using System;
class EmployeeWage
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate Daily Employee Wage");
        int WAGE_PER__HOUR = 20;
        int total_hour = 0;
        for (int day = 0; day < 30; day++)
        {
            Random random = new Random();
            int check_Attandance = random.Next(0, 2);
            int calculate_hour = random.Next(0, 2);
            switch (check_Attandance)
            {
                case 0:
                    Console.WriteLine("NO ! Employess is Not Present");
                    break;
                case 1:
                    switch (calculate_hour)
                    {
                        case 0:
                            Console.WriteLine("Today Employee Works half time");
                            total_hour += 4;
                            break;
                        case 1:
                            Console.WriteLine("Today Employee Works Full time");
                            total_hour+= 8;
                            break;
                        default:
                            break;

                    }

                    break;
                default:
                    break;
            }
            int Wage = total_hour * WAGE_PER__HOUR;
            Console.WriteLine("Employee Daily Wage" + " " + Wage);

        }
    }

}


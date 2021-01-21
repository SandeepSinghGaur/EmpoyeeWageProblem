using System;
class EmployeeWage
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check Employee Present or not");
        int IS_PRESENT = 1;
        Random random = new Random();
        int check_Attandance = random.Next(0, 2);
        if (check_Attandance == IS_PRESENT)
            Console.WriteLine("Yes ! Employee is Present");
        else
            Console.WriteLine("NO ! Employess is Not Present");
    }
}

using EmployeeWage;
using System;
using System.Collections.Generic;

public class EmpWageBuilder : IComputeEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

    public EmpWageBuilder()
    {
        this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }
    public void AddCompanyWage(string company, int empRatePerHour, int noOfWorkingDay, int maxHourPerMonth)
    {
        CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, noOfWorkingDay, maxHourPerMonth);
        this.companyEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(company, companyEmpWage);
    }

    public  void ComputeEmpWage()
    {
        foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
        {
            companyEmpWage.SetTotalEmpWage(ComputeEmpWage(companyEmpWage));
        }
    }
    private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
    {
        int emphours = 0, totalEmpHour = 0, totalWorkingDay = 0;
        while(totalEmpHour<=companyEmpWage.maxHourPerMonth && totalWorkingDay < companyEmpWage.noOfWorkingDays)
        {
            totalWorkingDay++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
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
            totalEmpHour += emphours;
            Console.WriteLine("Days:"+" "+ totalWorkingDay +" "+ "Emp Hours : " + emphours);
            }
        return totalEmpHour * companyEmpWage.empRatePerHour;

        }


    
    public int getTotalWage(string company)
    {
        return this.companyToEmpWageMap[company].totalWages;
    }
}
class AddMultipleCompaniesInList
{
    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
    public AddMultipleCompaniesInList()
    {
        this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }

}

class Program
{
    static void Main(string[] args)
    {

        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        for (int number = 0; number < 5; number++)
        {
            string company = Console.ReadLine();
            int empRatePerHours = Convert.ToInt32(Console.ReadLine());
            int noOfWorkingDays = Convert.ToInt32(Console.ReadLine());
            int maxHourPerMonths = Convert.ToInt32(Console.ReadLine());
            empWageBuilder.AddCompanyWage(company, empRatePerHours, noOfWorkingDays, maxHourPerMonths);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total Wage for  Company: " + empWageBuilder.getTotalWage(company));
        }

    }

}


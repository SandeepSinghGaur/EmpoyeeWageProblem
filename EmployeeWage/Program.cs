using EmployeeWage;
using System;
using System.Collections.Generic;

public class EmpWageBuilder : IComputeEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    private LinkedList<CompanyEmpWage> companyEmpWageList;
    private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
    private LinkedList<CompanyEmpWage> DailyEmpWageList;

    public EmpWageBuilder()
    {
        this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        this.DailyEmpWageList = new LinkedList<CompanyEmpWage>();
    }
    public void AddCompanyWage(string company, int empRatePerHour, int noOfWorkingDay, int maxHourPerMonth)
    {
        CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, noOfWorkingDay, maxHourPerMonth);
        this.companyEmpWageList.AddLast(companyEmpWage);
        this.companyToEmpWageMap.Add(company, companyEmpWage);
        this.DailyEmpWageList.AddLast(companyEmpWage);
    }

    public  void ComputeEmpWage()
    {
        foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
        {
            companyEmpWage.SetTotalEmpWage(ComputeEmpWage(companyEmpWage));
        }
        foreach(CompanyEmpWage companyEmpWage1 in this.DailyEmpWageList)
        {
            companyEmpWage1.DailyEmpWage(ComputeEmpWage(companyEmpWage1));
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
            Console.WriteLine("Daily Wages" + " " + emphours * 20);
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
        empWageBuilder.AddCompanyWage("Dmart", 20, 2, 10);
        empWageBuilder.AddCompanyWage("Nokia", 15, 2, 10);
        empWageBuilder.ComputeEmpWage();
        Console.WriteLine("Total Wage for Dmart Company: " + empWageBuilder.getTotalWage("Dmart"));
        Console.WriteLine("Total Wage for Nokia Company: " + empWageBuilder.getTotalWage("Nokia"));
    }

    }




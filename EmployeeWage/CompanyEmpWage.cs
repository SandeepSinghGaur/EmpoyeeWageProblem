using System;
using System.Collections.Generic;
using System.Text;

public interface IComputeEmpWage
{
    public void AddCompanyWage(string company, int empRatePerHour, int noOfWworkingDays, int maxHourPerMonth);
    public void ComputeEmpWage();
    public int getTotalWage(string company);

}
namespace EmployeeWage
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int noOfWorkingDays;
        public int maxHourPerMonth;
        public int totalWages;
        public int dailyWages;
        public CompanyEmpWage(string company,int empRatePerHour,int noOfWorkingDays,int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;
            this.totalWages = 0;

        }
        public void SetTotalEmpWage(int totalWages)
        {
            this.totalWages = totalWages;
        }
        public void DailyEmpWage(int dailyWages)
        {
            this.dailyWages = dailyWages;
        }
        public string toString()
        {
            return "Total Emp Wage for Company: " + this.company + "is: " + this.totalWages;
        }

    }
}

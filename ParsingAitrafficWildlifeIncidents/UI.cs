public class UserInterface
{
    public void introMessage()
    {
       Console.WriteLine("Welcome, we are going to go through some airtraffic/wildlife statistics"); 
    }

    public void sumMessage(int incidentCount)
    {
        Console.WriteLine($"The total count of airtraffic/wildlife incidents in the time period 1990-2016 was {incidentCount}");
    }

    public void groupByYearMessage(int selectedYear, int yearCount)
    {
        Console.WriteLine($"The amount of incidents in {selectedYear} was {yearCount}");
    }

    public void groupByMonthMessage(int selectedYear, int selectedMonth, int monthCount)
    {
        Console.WriteLine($"The amount of incidents in {selectedMonth} of {selectedYear} was {monthCount}");
    }

    public void groupByDayMessage(int selectedYear, int selectedMonth, int selectedDay, int dayCount)
    {
        Console.WriteLine($"The amount of incidents on {selectedDay}/{selectedMonth}/{selectedYear} was {dayCount}");
    }

    public void groupByOperatorMessage(string operatorCompany, int operatorCount)
    {
        Console.WriteLine($"There were {operatorCount} incidents involving {operatorCompany}");
    }

    public void groupByModelMessage(string aircraftModel, int modelCount)
    {
        Console.WriteLine($"There were {modelCount} incidents involving a {aircraftModel}");
    }

    public void errorMessage()
    {
        
    }
}
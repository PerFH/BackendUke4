using System.Xml.Serialization;

public class UserInterface
{
    public void welcomeMessage()
    {
       Console.WriteLine("Welcome! We are going to go through some airtraffic/wildlife statistics");
       
    }
    public int mainMenu(int incidentCount)
    {
       Console.WriteLine($"The total count of airtraffic/wildlife incidents in the time period 1990-2016 was {incidentCount}\n"
        + "I can sort these for you:\n"
        + "1. Sort incidents by year.\n"
        + "2. Sort incidents by Aircraft operator(airline/company).\n"
        + "3. Sort incidents by Aircraft Model.\n"
        + "0. Exit program."
        );
        return menuChoice();
    }

    public int selectYear()
    {
        Console.WriteLine("Please select a year(1990-2016)");
        return menuChoice();
    }
    public int selectMonth()
    {
        Console.WriteLine("Select a month (1-12) to continue");
        Console.WriteLine("Select 0 to go back to main menu");
        return menuChoice();
    }
    public int selectDay()
    {
        Console.WriteLine("Please select a day(1-31)");
        return menuChoice();
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

    public int menuChoice()
    {
        int selection;
        while  (!int.TryParse(Console.ReadLine(), out selection))
        {
            errorMessage();
        }
        return selection;
    }
    public void goodbye()
    {
        Console.WriteLine("Shutting down...");
    }
    public void errorMessage()
    {
        Console.WriteLine("Invalid option, select a valid option");
    }
    public char Continue()
    {
        Console.WriteLine("Do you want to see the full list? (y/n)");
        char choice;
        while (!char.TryParse(Console.ReadLine(), out choice) || 
        (choice != 'y' && choice != 'n' && choice != 'Y' && choice != 'N'))
        {
            errorMessage();
        }
        
        return char.ToLower(choice);
    }
}
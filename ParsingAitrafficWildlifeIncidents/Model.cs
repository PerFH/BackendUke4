using System.Security.Cryptography.X509Certificates;

class Model
{
    UserInterface userInterface;
    Database database;

    public Model(Database database, UserInterface userInterface)
    {
        this.database = database;
        this.userInterface = userInterface;
    }
    public int sum()
    {
        int incidentCount = database.Incidents.Count;
        userInterface.sumMessage(incidentCount);
        return incidentCount;
    }

    public int groupByYear(int incidentYear)
    {
        int yearCount = database.Incidents.Count(i => i.incidentYear == incidentYear);
        userInterface.groupByYearMessage(incidentYear, yearCount);
        return yearCount;
    }

    public int groupByMonth(int incidentYear, int incidentMonth)
    {
        int monthCount = database.Incidents.Count(i => i.incidentYear == incidentYear
                                                 && i.incidentMonth == incidentMonth);
        userInterface.groupByMonthMessage(incidentYear, incidentMonth, monthCount);
        return monthCount;
    }
    public int groupByDay(int incidentYear, int incidentMonth, int incidentDay)
    {
        int dayCount = database.Incidents.Count(i => i.incidentYear == incidentYear
                                                && i.incidentMonth == incidentMonth
                                                && i.incidentDay == incidentDay);
        userInterface.groupByDayMessage(incidentYear, incidentMonth, incidentDay, dayCount);
        return dayCount;
    }

    public List<string?> getOperatorCompanies()
    {
        return database.Incidents.Select(
            i => i.operatorCompany).Distinct().OrderBy(i => i).ToList();
    }

    public void groupByOperator()
    {
        foreach (string? operatorCompany in getOperatorCompanies())
        {
            
        int operatorCount = database.Incidents.Count(i => i.operatorCompany == operatorCompany);
        userInterface.groupByOperatorMessage(operatorCompany, operatorCount);
        }
    }

    public List<string?> getAircraftModels()
    {
        return database.Incidents.Select(
            i => i.aircraftModel).Distinct().OrderBy(i => i).ToList();
    }

    public void groupByModel()
    {
        foreach (string? aircraftModel in getAircraftModels())
        {
            
        int modelCount = database.Incidents.Count(i => i.aircraftModel == aircraftModel);
        userInterface.groupByModelMessage(aircraftModel, modelCount);
        }
    }
}
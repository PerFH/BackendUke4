class Model
{
    Database database;

    public Model(Database database)
    {
        this.database = database;
    }


    public int sum()
    {
        int incidentCount = database.Incidents.Count;
        //userInterface.sumMessage(incidentCount);
        return incidentCount;
    }


    public int groupByYear(int incidentYear)
    {
        int yearCount = database.Incidents.Count(i => i.incidentYear == incidentYear);
        //ui.groupbymonthmessage(incidentYear, yearCount)
        return yearCount;
    }


    public int groupByMonth(int incidentYear, int incidentMonth)
    {
        int monthCount = database.Incidents.Count(i => i.incidentYear == incidentYear
                                                 && i.incidentMonth == incidentMonth);
        //userInterface.groupByMonthMessage(incidentYear, incidentMonth, monthCount);
        return monthCount;
    }
    public int groupByDay(int incidentYear, int incidentMonth, int incidentDay)
    {
        int dayCount = database.Incidents.Count(i => i.incidentYear == incidentYear
                                                && i.incidentMonth == incidentMonth
                                                && i.incidentDay == incidentDay);
        //userInterface.groupByDayMessage(incidentYear, incidentMonth, incidentDay, dayCount);
        return dayCount;
    }

    public List<string?> getOperatorCompanies()
    {
        return database.Incidents.Select(
            i => i.operatorCompany).Distinct().OrderBy(i => i).ToList();
    }

    public List<(string? operatorCompany, int operatorCount)> groupByOperator()
    {
        List<(string? operatorCompany, int operatorCount)> results = new();
        foreach (string? operatorCompany in getOperatorCompanies())
        {

            int operatorCount = database.Incidents.Count(i => i.operatorCompany == operatorCompany);
            results.Add((operatorCompany, operatorCount));
            // userInterface.groupByOperatorMessage(operatorCompany, operatorCount);
        }
        return results;
    }

    public List<(string? operatorCompany, int operatorCount)> top10Operators()
    {
        List<string?> operatorCompanies = getOperatorCompanies();

        operatorCompanies = operatorCompanies
            .OrderByDescending(i => database.Incidents.Count(
                j => j.operatorCompany == i)).Take(10).ToList();

        List<(string? operatorCompany, int operatorCount)> results = new();

        foreach (string? operatorCompany in operatorCompanies)
        {
            int operatorCount = database.Incidents.Count(
                i => i.operatorCompany == operatorCompany);

            results.Add((operatorCompany, operatorCount));
            // userInterface.groupByOperatorMessage(operatorCompany, operatorCount);
        }
        return results;
    }


    public List<string?> getAircraftModels()
    {
        return database.Incidents.Select(
            i => i.aircraftModel).Distinct().OrderBy(i => i).ToList();
    }


    public List<(string? aircraftModel, int modelCount)> groupByModel()
    {
        List<(string? aircraftModel, int modelCount)> results = new();
        foreach (string? aircraftModel in getAircraftModels())
        {
            int modelCount = database.Incidents.Count(i => i.aircraftModel == aircraftModel);
            results.Add((aircraftModel, modelCount));
            //userInterface.groupByModelMessage(aircraftModel, modelCount);
        }
        return results;
    }


    public List<(string? aircraftModel, int modelCount)> top10Models()

    {
        List<string?> aircraftModels = getAircraftModels();

        aircraftModels = aircraftModels
            .OrderByDescending(i => database.Incidents.Count(
                j => j.aircraftModel == i)).Take(10).ToList();

        List<(string? aircraftmodel, int modelCount)> results = new();

        foreach (string? aircraftModel in aircraftModels)
        {
            int modelCount = database.Incidents.Count(
                i => i.aircraftModel == aircraftModel);
            results.Add((aircraftModel, modelCount));
            //userInterface.groupByModelMessage(aircraftModel, modelCount);
        }
        return results;
    }
}
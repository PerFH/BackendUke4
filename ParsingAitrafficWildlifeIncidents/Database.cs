class Database
{
    private List<Incident> incidents = new List<Incident>();
    public IReadOnlyList<Incident> Incidents { get; private set; }

    public bool fileExists
    {
        get
        {
            return File.Exists(getFile());
        }
    }
    private string getFile()
    {
        return "database.csv";

    }
    public void populateList()
    {
        foreach (string line in File.ReadLines(getFile()).Skip(1))
        {
            string[] data = line.Split(',');
            Incident incident = new Incident();
            incident.incidentYear = int.Parse(data[1]);
            incident.incidentMonth = int.Parse(data[2]);
            incident.incidentDay = int.Parse(data[3]);
            incident.operatorCompany = data[5];
            incident.aircraftModel = data[6];
            incidents.Add(incident);
            Console.WriteLine($"Incident date: {incident.incidentDay}/{incident.incidentMonth}/{incident.incidentYear} Operator: {incident.operatorCompany} Plane model: {incident.aircraftModel}");
        }
    }

}
    public class Incident
{
public int incidentYear { get; set; }
public int incidentMonth { get; set ;}
public int incidentDay { get; set; }
public string? operatorCompany { get; set;}
public string? aircraftModel { get; set; }
}


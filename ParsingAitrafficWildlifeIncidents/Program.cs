using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
Console.WriteLine("Hello, World!");
Database dataBase = new Database();
UserInterface userInterface = new UserInterface();
Model model = new Model(dataBase, userInterface);

dataBase.populateList();
model.sum();
int incidentYear = 2010;
int incidentMonth = 3;
int incidentDay = 4;
string operatorCompany = "UNKNOWN";
string aircraftModel = "DC-9";
model.groupByYear(incidentYear);
model.groupByMonth(incidentYear, incidentMonth);
model.groupByDay(incidentYear, incidentMonth, incidentDay);
model.groupByOperator(operatorCompany);
model.groupByModel(aircraftModel);
    }
}
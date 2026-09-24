using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
Console.WriteLine("Hello, World!");
Database dataBase = new Database();
Model model = new Model(dataBase);

dataBase.populateList();
model.sum();
int incidentYear = 2010;
int incidentMonth = 3;
int incidentDay = 4;
//var operatorCompanies = model.getOperatorCompanies();
model.groupByYear(incidentYear);
model.groupByMonth(incidentYear, incidentMonth);
model.groupByDay(incidentYear, incidentMonth, incidentDay);
model.top10Operators();
model.top10Models();
    }
}
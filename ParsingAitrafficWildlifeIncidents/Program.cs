using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

Database database = new Database();
database.populateList();

Model model = new Model(database);
UserInterface userInterface = new UserInterface();
Controller controller = new Controller(model, userInterface);

controller.programStart();



model.sum();
//int incidentYear = 2010;
//int incidentMonth = 3;
//int incidentDay = 4;
//var operatorCompanies = model.getOperatorCompanies();
//model.groupByYear(incidentYear);
//model.groupByMonth(incidentYear, incidentMonth);
//model.groupByDay(incidentYear, incidentMonth, incidentDay);
//model.top10Operators();
//model.top10Models();
    }
}
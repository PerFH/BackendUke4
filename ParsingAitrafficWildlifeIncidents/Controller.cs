using System.Net;
using System.Xml.Serialization;

class Controller
{
    Model model;
    UserInterface userInterface;
    public Controller(Model model, UserInterface userInterface)
    {
        this.model = model;
        this.userInterface = userInterface;
    }
    public void programStart()
    {
        Console.WriteLine("Starting up...");
        int sum = model.sum();
        Console.WriteLine("Database populated!");
        Console.Clear();
        userInterface.welcomeMessage();
        int choice = userInterface.mainMenu(sum);
        mainMenu(choice);
        void mainMenu(int choice)
        {
            switch (choice)
            {
                case 3:
                    List<(string? aircraftModel, int modelCount)> topModels = model.top10Models();
                    foreach (var result in topModels)
                    {
                        userInterface.groupByModelMessage(result.aircraftModel, result.modelCount);

                    }
                    char seeFullModels = userInterface.Continue();
                    switch (seeFullModels)
                    {
                        case 'y':
                            List<(string? aircraftModel, int modelCount)> totalModelIncidents = model.groupByModel();
                            foreach (var model in totalModelIncidents)
                            {
                                userInterface.groupByModelMessage(model.aircraftModel, model.modelCount);
                            }

                            break;
                        case 'n':
                            mainMenu(userInterface.mainMenu(sum));
                            break;
                    }
                    break;
                case 2:
                    List<(string? operatorCompany, int operatorCount)> topOperators = model.top10Operators();
                    foreach (var result in topOperators)
                    {
                        userInterface.groupByOperatorMessage(result.operatorCompany, result.operatorCount);
                    }
                    char seeFullOperators = userInterface.Continue();
                    switch (seeFullOperators)
                    {
                        case 'y': List<(string? operatorCompany, int operatorCount)> totalOperatorIncidents = model.groupByOperator();
                        foreach (var operatorInc in totalOperatorIncidents)
                            {
                                userInterface.groupByOperatorMessage(operatorInc.operatorCompany, operatorInc.operatorCount);
                            }
                        break;
                        case 'n':
                            mainMenu(userInterface.mainMenu(sum));
                            break;
                    }
                    break;
                case 1:
                    int selectedYear = userInterface.selectYear();
                    while (selectedYear < 1990 || selectedYear > 2016)
                    {
                        userInterface.errorMessage();
                        selectedYear = userInterface.selectYear();
                    }
                    int yearCount = model.groupByYear(selectedYear);
                    userInterface.groupByYearMessage(selectedYear, yearCount);
                    int selectedMonth = userInterface.selectMonth();
                    switch (selectedMonth)
                    {
                        case 0: mainMenu(userInterface.mainMenu(sum));
                        break;
                        default: 
                        while (selectedMonth < 1 || selectedMonth > 12)
                            {
                                userInterface.errorMessage();
                                selectedMonth = userInterface.selectMonth();
                            }
                        int monthCount = model.groupByMonth(selectedYear, selectedMonth);
                        userInterface.groupByMonthMessage(selectedYear, selectedMonth, monthCount);
                        break;
                    }
                    int selectedDay = userInterface.selectDay();
                    while (selectedDay < 1 || selectedDay > 31)
                    {
                        userInterface.errorMessage();
                        selectedDay = userInterface.selectDay();
                    }
                    int dayCount = model.groupByDay(selectedYear, selectedMonth, selectedDay);
                    userInterface.groupByDayMessage(selectedYear, selectedMonth, selectedDay, dayCount);
                    break;

                case 0:
                    userInterface.goodbye();
                    break;
                default:
                    userInterface.errorMessage();
                    mainMenu(userInterface.mainMenu(0));
                    break;


            }
        }
    }
}
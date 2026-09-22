### Parsing av Aircraft Wildlife strikes statistikk
## Program flow
    - Bruker får en intro
    - Bruker blir spurt om hva for info de vil ha ut (numererte alternativer)
    - alternativer:
        -Totalt antall
        -Del etter årstall
            -spør vidre om bruker vil sjekke måneder i et spesielt årstall
                - spør vidre om bruker vil sjekke dagene i måneden
        - Del inn etter operator(flyselskap)
        - Del inn etter flymodell

## Pseudokode

# Program.cs
    programStart()
    - controller.start
# UI
    void introMessage()

    void sumMessage()

    void groupByYearMessage()

    void groupByMonthMessage()

    void groupByDayMessage()

    void groupByOperatorMessage()

    void groupByModelMessage()

    void errorMessage()
    
    
    
# Controller
    start(){
        if datasource.file.exists 
            introMessage()
        else 
            errormessage()


    mainMenu()    
    switch mainMenuChoice
        case 1: model.sum()
                ui.sumMessage()
        case 2: model.groupByYear()
                ui.groupByYearMessage()
        case 3: model.groupByOperator()
                ui.groupByOperatorMessage()
        case 4: model.groupByModel
                ui.groupByModelMessage()
    }

    if model.groupbyyear
        ui.groupbymonthmessage
        console.readline
        model.groupbymonth
    
    if model.groupbymonth
        ui.groupbydaymessage
        console.readline
        model.groupbyday




# Model
    sum()
    {
        how many times has it happened total
    }
    
    groupByYear()
    {
        how many times has it happened each year
    }

    groupByMonth()
    {
        how many times has it happened each month in a given year
    }
    groupByDay()
    {
        how many times has it happened each day in a given month
    }

    groupByOperator()
    {
        how many times has it happened under each operator
    }

    groupByModel()
    {
        how many times has it happened to each plane model
    }
    Class Incident
        Year
        Month
        Operator
        AircraftModel
    
# Datasource
    public bool fileexists
        return File.Exists(getFile)

    private string getFile()
        reutrn database.csv
    


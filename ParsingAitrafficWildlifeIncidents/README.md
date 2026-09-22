### Parsing av Aircraft Wildlife strikes statistikk

## Program flow
    - Bruker får en intro
    - Bruker blir spurt om hva for info de vil ha ut (numererte alternativer)
    - alternativer:
        -Totalt antall
        -Del etter årstall
            -spør om bruker vil sjekke måneder i et spesielt årstall, eller tilbake til MM
                - spør vidre om bruker vil sjekke dagene i måneden, eller tilbake til MM
        - Del inn etter operator(flyselskap)
        - Del inn etter flymodell
    - Spør bruker om den ønsker å undersøke statistikken fra et annet aspekt

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
    start()
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



# Database

    public IReadOnlyList <incident> incidents

    public bool fileexists
        return File.Exists getFile

    private string getFile
        reutrn database.csv

    foreach line in file getFile
        put linje inn i array
        new incident
        gi relevant info til Incident objektene via array
        sett objektet inn i liste

    
    Class Incident
        Year
        Month
        Day
        Operator
        AircraftModel

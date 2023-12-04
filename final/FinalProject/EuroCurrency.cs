// Class representing the Euro currency, extending the base Currency class.
public class EuroCurrency : Currency
{
    // Additional property to store the Eurozone information.
    private string _mo_euroZone;
   
    // Constructor initializes the EuroCurrency with the currency code and name,
    // and sets the Eurozone information.
    public EuroCurrency() : base("EUR", "Euro")
    {
        _mo_euroZone = "Eurozone"; 
    }
    //   A string representing the Eurozone information.
     public string getEuroZone(){
        return _mo_euroZone;
     }
}
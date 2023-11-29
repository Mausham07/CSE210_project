public class EuroCurrency : Currency
{
    private string _mo_euroZone;
   

    public EuroCurrency() : base("EUR", "Euro")
    {
        _mo_euroZone = "Eurozone"; 
    }
     public string getEuroZone(){
        return _mo_euroZone;
     }
}
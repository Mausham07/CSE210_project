public class Nepalese : Currency
{
    // Additional property to store the Nepalese Ruppee information.
    private string _mo_nepal;
   
    // Constructor initializes the Nepalese Ruppee with the currency code and name,
    // and sets the Nepalese Ruppee information.
    public Nepalese() : base("NPR", "Nepalese")
    {
        _mo_nepal = "Dinar"; 
    }
    //   A string representing the Nepalese Ruppee information.
     public string getNepal(){
        return _mo_nepal;
     }
}
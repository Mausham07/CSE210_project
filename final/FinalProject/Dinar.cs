public class Dinar : Currency
{
    // Additional property to store the Dinar information.
    private string _mo_dinar;
   
    // Constructor initializes the Dinar with the currency code and name,
    // and sets the Dinar information.
    public Dinar() : base("DNR", "Dinar")
    {
        _mo_dinar = "Dinar"; 
    }
    //   A string representing the Dinar information.
     public string getDinar(){
        return _mo_dinar;
     }
}
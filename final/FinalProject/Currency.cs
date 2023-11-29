public class Currency
{
    private string _mo_code;
    private string _mo_name;

    public Currency(string code, string name)
    {
        _mo_code = code;
        _mo_name = name;
    }
    public string getCode(){
        return _mo_code;
    }
    public string Name()
    {
        return _mo_name; 
    }
}
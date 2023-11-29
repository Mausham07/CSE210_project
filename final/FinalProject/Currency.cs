public class Currency
{
    private string _mo_code;
    private string _mo_name;

    public string Code
    {
        get { return _mo_code; }
        set { _mo_code = value; }
    }

    public string Name
    {
        get { return _mo_name; }
        set { _mo_name = value; }
    }

    public Currency(string code, string name)
    {
        _mo_code = code;
        _mo_name = name;
    }
}
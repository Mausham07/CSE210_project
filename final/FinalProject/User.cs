public class User
{
    private string _mo_username;
    private string _mo_password;

    

    public User(string username, string password)
    {
        _mo_username = username;
        _mo_password = password;
    }
    public string getUsername()
    {
        return _mo_username;
    }

    public string getPassword()
    {
        return _mo_password;
    }
}
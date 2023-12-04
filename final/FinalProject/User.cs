// Class representing a user in the MO Currency Converter Bank system.
public class User
{
    // Private fields to store user details
    private string _mo_username;
    private string _mo_password;

    // Constructor to initialize a new user with the provided username and password.
    public User(string username, string password)
    {
        _mo_username = username;
        _mo_password = password;
    }

    
    //   The username of the user.
    public string getUsername()
    {
        return _mo_username;
    }
    
    //   The password of the user.
    public string getPassword()
    {
        return _mo_password;
    }
}

public class User
{
    protected int userId;
    protected string username;
    protected string password;

    public User(int userId, string username, string password)
    {
        this.userId = userId;
        this.username = username;
        this.password = password;
    }
    public void GetUserInfo(){
        System.Console.WriteLine($"UserID: {userId}");
        System.Console.WriteLine($"Username: {username}");
        System.Console.WriteLine($"Password: {password}");
    }
}
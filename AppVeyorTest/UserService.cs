namespace AppVeyorTest
{
    public class UserService
    {
        public bool IsCredentialsValid(string username, string password)
        {
            return username == "admin" && password == "admin";
        }
    }
}
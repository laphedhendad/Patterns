public interface IAuthHandler
{
    public void SetNext(IAuthHandler handler);
    public void Handle(Credentials credentials);
}

public struct Credentials
{
    public string login;
    public string password;
}
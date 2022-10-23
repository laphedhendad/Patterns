using Unity.VisualScripting;

public abstract class AuthHandler : IAuthHandler
{
    protected IAuthHandler next;

    public AuthHandler() => next = null;
    
    public void SetNext(IAuthHandler handler)
    {
        next = handler;
    }

    public virtual void Handle(Credentials credentials)
    {
        next?.Handle(credentials);
    }
}

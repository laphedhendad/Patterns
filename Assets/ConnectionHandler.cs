using UnityEditor;

public class ConnectionHandler : AuthHandler
{
    public override void Handle(Credentials credentials)
    {
        if(CheckConnection()) base.Handle(credentials);
    }

    private bool CheckConnection()
    {
        //checking connection
        return true;
    }
}

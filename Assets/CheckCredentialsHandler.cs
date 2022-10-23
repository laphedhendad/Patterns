public class CheckCredentialsHandler : AuthHandler
{
    public override void Handle(Credentials credentials)
    {
        if(CheckCredentials(credentials)) base.Handle(credentials);
    }

    private bool CheckCredentials(Credentials credentials)
    {
        //check
        return true;
    }
}

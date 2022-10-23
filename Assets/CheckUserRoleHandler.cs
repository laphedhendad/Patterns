public class CheckUserRoleHandler : AuthHandler
{
    public override void Handle(Credentials credentials)
    {
        CheckUserRole(credentials);
        
        base.Handle(credentials);
    }

    private void CheckUserRole(Credentials credentials)
    {
        //setup user role
    }
}

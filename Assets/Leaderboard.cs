public class Leaderboard
{
    protected IDatabaseProvider _databaseProvider;
    protected LeaderboardWindow _leaderboardWindow;

    public Leaderboard(IDatabaseProvider db, LeaderboardWindow ui)
    {
        _databaseProvider = db;
        _leaderboardWindow = ui;
        
        InitializeLeaderList();
    }
    
    public virtual void OpenWindow()
    {
        
    }

    public virtual void InitializeLeaderList()
    {
        
    }

    public virtual void UpdateUI()
    {
        
    }
}

public class LeaderboardWindow
{
    
}

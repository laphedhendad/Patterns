public class WhiteStats : IStatsProvider
{
    public PlayerStats GetStats()
    {
        return new PlayerStats();
    }
}

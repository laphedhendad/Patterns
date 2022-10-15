public class RaceStatsDecorator : StatsDecorator
{
    private Player.Race _race;
    
    public RaceStatsDecorator(IStatsProvider wrappee, Player.Race race) : base(wrappee)
    {
        _race = race;
    }

    protected override PlayerStats GetStatsExtra()
    {
        return _wrappee.GetStats() + GetRaceStats();
    }

    private PlayerStats GetRaceStats()
    {
        return new PlayerStats();
    }
}

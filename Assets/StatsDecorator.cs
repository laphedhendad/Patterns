public abstract class StatsDecorator : IStatsProvider
{
    protected IStatsProvider _wrappee;

    public StatsDecorator(IStatsProvider wrappee)
    {
        this._wrappee = wrappee;
    }

    public PlayerStats GetStats()
    {
        return GetStatsExtra();
    }

    protected abstract PlayerStats GetStatsExtra();
}

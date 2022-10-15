public class Player
{
    private IStatsProvider _provider;
    
    Player()
    {
        _provider = new WhiteStats();
        _provider = new RaceStatsDecorator(_provider, Race.Human);
        _provider = new SpecializationStatsDecorator(_provider, Specialization.Mage);
    }
    public enum Race
    {
        Human,
        Elf,
        Orc,
        Dwarf
    }

    public enum Specialization
    {
        Warrior,
        Mage,
        Thief,
        Alchemist
    }
}
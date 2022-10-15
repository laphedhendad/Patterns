public class PlayerStats
{
    public float Strength { get; set; }
    public float Agility { get; set; }
    public float Intelligence { get; set; }
    
    public static PlayerStats operator +(PlayerStats a, PlayerStats b)
    {
        return new PlayerStats()
        {
            Strength = a.Strength + b.Strength,
            Agility = a.Agility + b.Agility,
            Intelligence = a.Intelligence + b.Intelligence
        };
    }
}
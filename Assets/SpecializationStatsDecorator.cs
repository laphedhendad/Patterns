using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecializationStatsDecorator : StatsDecorator
{
    private Player.Specialization _specialization;
    
    public SpecializationStatsDecorator(IStatsProvider wrappee, Player.Specialization specialization) : base(wrappee)
    {
        _specialization = specialization;
    }

    protected override PlayerStats GetStatsExtra()
    {
        return _wrappee.GetStats() + GetSpecStats();
    }

    private PlayerStats GetSpecStats()
    {
        return new PlayerStats();
    }
}

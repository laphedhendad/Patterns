using UnityEngine;

public class Spawner : MonoBehaviour
{
    private IMonsterFactory _monsterFactory;

    public void SetMonsterFactory(IMonsterFactory factory)
    {
        _monsterFactory = factory;
    }

    public void SpawnSkeleton()
    {
        _monsterFactory.CreateSkeleton();
    }

    public void SpawnDragon()
    {
        _monsterFactory.CreateDragon();
    }
}

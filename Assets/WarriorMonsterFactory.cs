public class WarriorMonsterFactory:IMonsterFactory
{
    public Skeleton CreateSkeleton()
    {
        return new SkeletonWarrior();
    }

    public Dragon CreateDragon()
    {
        return new DragonWarrior();
    }
}

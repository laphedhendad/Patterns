public class MageMonsterFactory : IMonsterFactory
{
    public Skeleton CreateSkeleton()
    {
        return new SkeletonMage();
    }

    public Dragon CreateDragon()
    {
        return new DragonMage();
    }
}

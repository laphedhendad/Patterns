public class GoldDropFactory : DropFactory
{
    public override IDroppable CreateDrop()
    {
        return new GoldDrop();
    }
}

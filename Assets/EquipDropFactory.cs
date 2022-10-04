public class EquipDropFactory: DropFactory
{
    public override IDroppable CreateDrop()
    {
        return new EquipDrop();
    }
}
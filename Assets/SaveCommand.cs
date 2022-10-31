public class SaveCommand : ICommand
{
    private string _save;

    public SaveCommand(string save) => _save = save;
    
    public void Execute()
    {
        //save data
    }
}

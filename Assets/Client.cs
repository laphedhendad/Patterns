public class Client
{
    public void CreateButtons()
    {
        Button loadButton = new Button(new LoadCommand());
        Button saveButton = new Button(new SaveCommand("data"));
    }
}

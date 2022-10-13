public class DialogLine : IDialogLine
{
    private string _text;

    public DialogLine(string text) => _text = text;

    public void PrintLine()
    {
        //Print line in UI
    }
}

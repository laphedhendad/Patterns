using System.Collections.Generic;

public class CompoundDialogLine : IDialogLine
{
    private List<IDialogLine> _children;
    private List<string> _cases;
    private string _text;
    
    public void PrintLine()
    {
        //Print text and cases in UI
    }

    public string[] GetCases()
    {
        return _cases.ToArray();
    }

    public IDialogLine ChoseCase(int index)
    {
        return _children[index];
    }

    public void AddChild(string dialogCase, IDialogLine child)
    {
        _children.Add(child);
        _cases.Add(dialogCase);
    }

    public void RemoveChild(IDialogLine child)
    {
        int index = _children.IndexOf(child);
        
        _children.Remove(child);
        _cases.RemoveAt(index);
    }
}

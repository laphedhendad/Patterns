using UnityEngine;

public class Button : MonoBehaviour
{
    private ICommand _command;

    public Button(ICommand command) => _command = command;
}

using System.Collections.Generic;

public class CommandManager : MonoSingleton<CommandManager>
{
    private List<ICommand> commandList = new();

    private int currentCommandIndex = 0;

    public void AddCommand(ICommand command)
    {
        //if a new command was added and we started already reversing through the list
        //then remove all the commands after the new command before adding the new command.
        //this effectively overwrites any redo commands if a new command is added.
        //just like unity's undo/redo system.
        if (currentCommandIndex < commandList.Count)
            commandList.RemoveRange(currentCommandIndex, commandList.Count - currentCommandIndex);

        //add new command
        commandList.Add(command);

        //execute newest command
        command.Execute();

        //increment index if there is more than 1 command in the list. The first command doesn't need to increment the index
        //because the index is defaulted to 0
        if (commandList.Count > 1)
            currentCommandIndex++;
    }

    public void UndoCommand()
    {
        //return if there isn't at least 1 command or the index is somehow less than 0
        if (commandList.Count <= 0 || currentCommandIndex < 0)
            return;

        //undo current command
        commandList[currentCommandIndex].Undo();

        //decrement index
        currentCommandIndex--;
    }

    public void RedoCommand()
    {
        //return if there isn't at least 1 command or the index is somehow greater than the list length
        if (commandList.Count <= 0 || currentCommandIndex > commandList.Count - 1)
            return;

        //increment index
        currentCommandIndex++;

        //execute current command
        commandList[currentCommandIndex].Execute();
    }

    public void ClearCommands()
    {
        //reset list
        commandList.Clear();

        //reset index
        currentCommandIndex = 0;
    }
}
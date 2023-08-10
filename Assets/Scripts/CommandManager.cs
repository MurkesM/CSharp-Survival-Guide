using System.Collections.Generic;

public class CommandManager : MonoSingleton<CommandManager>
{
    private Stack<ICommand> undoStack = new();
    private Stack<ICommand> redoStack = new();

    public void AddCommand(ICommand command)
    {
        //if a new command was added and we started already reversing through the undo stack
        //then remove all the redo commands after the new command before adding the new command to the undo stack.
        //this effectively overwrites any redo commands if a new command is added while already reversing through the undo commands.
        //this can be thought of as starting a new line of commands.
        //the result is just like the unity editors undo/redo system.
        if (redoStack.Count > 0)
            redoStack.Clear();

        //add to undo stack
        undoStack.Push(command);

        //execute newest command
        command.Execute();
    }

    public void UndoCommand()
    {
        //return if there isn't at least 1 command
        if (undoStack.Count <= 0)
            return;

        //add the command being undone to the redo stack
        redoStack.Push(undoStack.Peek());

        //undo current command and remove from the undo stack
        undoStack.Pop().Undo();
    }

    public void RedoCommand()
    {
        //return if there isn't at least 1 command
        if (redoStack.Count <= 0)
            return;

        //add the command being redone to the undo stack
        undoStack.Push(redoStack.Peek());

        //redo current command and remove from the redo stack
        redoStack.Pop().Execute();
    }

    public void ClearCommands()
    {
        undoStack.Clear();
        redoStack.Clear();
    }
}
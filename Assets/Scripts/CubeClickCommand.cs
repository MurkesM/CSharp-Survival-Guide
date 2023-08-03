using UnityEngine;

public class CubeClickCommand : ICommand
{
    private GameObject cube;
    private MeshRenderer renderer;

    private Color newColor;
    private Color previousColor;

    public CubeClickCommand(GameObject cube, Color newColor)
    {
        this.cube = cube;

        renderer = cube.GetComponent<MeshRenderer>();

        previousColor = renderer.material.color;
        this.newColor = newColor;

        CommandManager.Instance.AddCommand(this);
    }

    public void Execute()
    {
        renderer.material.color = newColor;
    }

    public void Undo()
    {
        renderer.material.color = previousColor;
    }
}
using UnityEngine;

public class Test : MonoBehaviour
{
    ExampleClass exampleClass = new ExampleClass(5, "default");

    ExampleStruct exampleStruct;

    void Start()
    {
        exampleStruct.testInt = 5;
        exampleStruct.testString = "default";

        Debug.Log($"Struct testString before change = {exampleStruct.testString}");

        ChangeValue(exampleStruct);

        Debug.Log($"Struct testString after change = {exampleStruct.testString}");
    }
    void ChangeValue(ExampleStruct exampleStruct) //value type
    {
        exampleStruct.testString = "updated";
        Debug.Log(exampleStruct.testString);
    }

    void ChangeValue(ExampleClass exampleClass) //reference type
    {
        exampleClass.testString = "updated";
    }
}
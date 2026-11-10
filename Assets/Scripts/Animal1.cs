using UnityEngine;

public class Animal1 : Animal
{
    public override string GetName()
    {
        return "Horse";
    }

    public override string GetData()
    {
        return "hay";
    }

    public override void DisplayText()
    {
        //base.DisplayText();
        Debug.Log("This is Animal1, Horse");
    }
}

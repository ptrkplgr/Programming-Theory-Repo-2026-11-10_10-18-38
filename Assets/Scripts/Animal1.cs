using UnityEngine;

public class Animal1 : Animal
{
    public override string GetName()
    {
        return "Animal1";
    }

    public override string GetData()
    {
        return "Food1";
    }

    public override void DisplayText()
    {
        //base.DisplayText();
        Debug.Log("This is Animal1");
    }
}

using UnityEngine;

// INHERITANCE
public class Animal3 : Animal
{
    //POLYMORPHISM
    public override string GetName()
    {
        return "Cow";
    }

    public override string GetData()
    {
        return "grass";
    }

    public override void DisplayText()
    {
        //base.DisplayText();
        Debug.Log("This is Animal3, Cow");
    }
}

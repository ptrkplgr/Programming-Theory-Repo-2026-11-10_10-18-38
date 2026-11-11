using UnityEngine;

// INHERITANCE
public class Animal2 : Animal
{
    //POLYMORPHISM
    public override string GetName()
    {
        return "Rooster";
    }

    public override string GetData()
    {
        return "corn";
    }

    public override void DisplayText()
    {
        //base.DisplayText();
        Debug.Log("This is Animal2, Rooster");
    }
}

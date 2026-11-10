using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public virtual string GetName()
    {
        return gameObject.name;
    }

public virtual string GetData()
    {
        return "";
    }

//if clicked on
public virtual void DisplayText()
    {
        Debug.Log("This is an animal");

    }
}

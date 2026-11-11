using System.Linq;
using NUnit.Framework.Constraints;
using UnityEngine;
using System;

// INHERITANCE
public class Animal1 : Animal
{
    private string m_animalName = "Horse";
    
    // ENCAPSULATION
    public string animalName
    {
        get{ return m_animalName; }
        set
        {
            //if(!value.StartsWith(value.ToUpper()))
            if(string.IsNullOrEmpty(value) || !char.IsUpper(value[0]))
            {
                Debug.Log("Name must start with upper case");
            }
            else
            {
                m_animalName = value;
            }
        }
    }
      void Start()
    {
        //animalName = "horse";  // TEST: lowercase
        //Debug.Log("Animal name: " + animalName);
    }
    //POLYMORPHISM  
    public override string GetName()
    {
        return animalName;
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

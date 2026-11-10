using UnityEngine;

public class MainUIHandler : MonoBehaviour
{
    public static MainUIHandler Instance { get; private set; }
    public InfoPopup InfoPopup;

    //protected IUIInfoContent m_CurrentContent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*     public void SetNewInfoContent(IUIInfoContent content)
    {
        if (content == null)
        {
            InfoPopup.gameObject.SetActive(false);
        }
        else
        {
            InfoPopup.gameObject.SetActive(true);
            m_CurrentContent = content;
            InfoPopup.animalName.text = content.GetName();
            InfoPopup.animalInfo.text = content.GetData();
        }
    } */
}

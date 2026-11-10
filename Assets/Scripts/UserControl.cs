using UnityEngine;
using UnityEngine.InputSystem;

public class UserControl : MonoBehaviour
{
    public Camera GameCamera;
    private InputAction leftClickAction;
    private Animal selected = null;

    public void HandleSelection()
    {
        var ray = GameCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //the collider could be children of the unit, so we make sure to check in the parent
                var animal = hit.collider.GetComponentInParent<Animal>();
                selected = animal;
                
                
                //check if the hit object have a IUIInfoContent to display in the UI
                //if there is none, this will be null, so this will hid the panel if it was displayed
                
                //var uiInfo = hit.collider.GetComponentInParent<MainUIHandler.IUIInfoContent>();
                //MainUIHandler.Instance.SetNewInfoContent(uiInfo);
            }
    }
}

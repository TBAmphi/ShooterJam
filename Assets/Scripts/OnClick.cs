using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class OnClick : MonoBehaviour
{
    Vector2 mousePos;
    //public GameObject prefab;
    public int clickableLayer;
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            mousePos = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            //Instantiate(prefab);

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                if(clickedObject.layer == clickableLayer)
                {
                    Debug.Log("Touche");
                    ClickableID clickedObjID = clickedObject.GetComponent<ClickableID>();

                    switch(clickedObjID.id)
                    {
                        case 0:
                            Debug.Log("Body");
                            break;
                        case 1:
                            Debug.Log("Layer 1");
                            break;
                        case 2:
                            Debug.Log("Layer 2");
                            break;
                        case 3:
                            Debug.Log("Layer 3");
                            break;
                        case 4:
                            Debug.Log("Layer 4");
                            break;
                        case 5:
                            Debug.Log("Layer 5");
                            break;
                        case 6:
                            Debug.Log("Layer 6");
                            break;
                        case 7:
                            Debug.Log("Layer 7");
                            break;
                        case 8:
                            Debug.Log("Layer 8");
                            break;
                        case 9:
                            Debug.Log("Layer 9");
                            break;
                        case 10:
                            Debug.Log("Layer 10");
                            break;
                    }                    
                }
            }
        }
    }
}

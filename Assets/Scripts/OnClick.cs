using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class OnClick : MonoBehaviour
{
    public GameManager gameManager = GameManager.instance;
    Vector2 mousePos;
    //public GameObject prefab;
    public int clickableLayer;
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame && !gameManager.cooldown)
        {
            mousePos = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            
            gameManager.cooldown = true;

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
                            gameManager.totalScore += gameManager.pointsValue * -5;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 1:
                            Debug.Log("Layer 1");
                            gameManager.totalScore += gameManager.pointsValue * 10;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 2:
                            Debug.Log("Layer 2");
                            gameManager.totalScore += gameManager.pointsValue * 9;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 3:
                            Debug.Log("Layer 3");
                            gameManager.totalScore += gameManager.pointsValue * 8;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 4:
                            Debug.Log("Layer 4");
                            gameManager.totalScore += gameManager.pointsValue * 7;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 5:
                            Debug.Log("Layer 5");
                            gameManager.totalScore += gameManager.pointsValue * 6;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 6:
                            Debug.Log("Layer 6");
                            gameManager.totalScore += gameManager.pointsValue * 5;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 7:
                            Debug.Log("Layer 7");
                            gameManager.totalScore += gameManager.pointsValue * 4;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 8:
                            Debug.Log("Layer 8");
                            gameManager.totalScore += gameManager.pointsValue * 3;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 9:
                            Debug.Log("Layer 9");
                            gameManager.totalScore += gameManager.pointsValue * 2;
                            Debug.Log(gameManager.totalScore);
                            break;
                        case 10:
                            Debug.Log("Layer 10");
                            gameManager.totalScore += gameManager.pointsValue * 1;
                            Debug.Log(gameManager.totalScore);
                            break;
                    }                    
                }
            }
        }
    }
}

using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.89f;
    [SerializeField] float moveSpeed = 0.2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Pressing the W Key");
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            Debug.Log("Pressing the S Key");
        }
        if(Keyboard.current.aKey.isPressed)
        {
            Debug.Log("Pressing the A Key");
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            Debug.Log("Pressing the D Key");
        }


        transform.Rotate(0,0,steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}

using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1.5f;
    [SerializeField] float moveSpeed = 0.05f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float steer = 0f;
        float move = 0f;

        if(Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }


        transform.Rotate(0,0,steer * steerSpeed);
        transform.Translate(0, move * moveSpeed, 0);
    }
}

using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,0.5f);
        transform.Translate(0, .05f, 0);
    }
}

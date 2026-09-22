using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float currentSpeed = 10f;
    [SerializeField] float boostSpeed = 15f;
    [SerializeField] float baseSpeed = 10f;

    [SerializeField] AudioClip boostSound;
    [SerializeField] AudioClip bumpSound;
    [SerializeField] AudioSource audioSource;


    [SerializeField] TMP_Text boostText;

    void Start()
    {
        boostText.gameObject.SetActive(false);   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Booster"))
        {
            currentSpeed = boostSpeed;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(boostSound);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("WorldColliders"))
        {
            currentSpeed = baseSpeed;
            boostText.gameObject.SetActive(false);   
            audioSource.PlayOneShot(bumpSound);

        }
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

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Rotate(0,0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}

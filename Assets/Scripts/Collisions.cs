using UnityEngine;

public class Collisions : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision has occurred against the " + collision.gameObject.name + "!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("BANG, BANG, BANG! Pull my Devil TRIGGER!");
    }
}

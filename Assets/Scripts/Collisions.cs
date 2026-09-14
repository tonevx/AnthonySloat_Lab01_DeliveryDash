using UnityEngine;

public class Collisions : MonoBehaviour
{
    float coinCounter = 1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision has occurred against the " + collision.gameObject.name + "!");
        if (collision.collider.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            Debug.Log($"You collected a test Coin! It's... honestly kind of worthless. You now have {coinCounter} coins!");
            coinCounter += 1;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("BANG, BANG, BANG! Pull my Devil TRIGGER!");
    }
}

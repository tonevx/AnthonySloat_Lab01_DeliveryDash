using NUnit.Framework;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    float coinCounter = 1;
    bool hasPackage = false;
    [SerializeField] float delay = 1f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            Debug.Log($"You collected a test Coin! It's... honestly kind of worthless. You now have {coinCounter} coins!");
            coinCounter += 1;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            if (hasPackage)
            {
                Debug.Log("You already have a package!!");
                return;
            }
            hasPackage = true;
            Debug.Log("Obtained Package!");
            Destroy(collision.gameObject, delay);
        }
        if (collision.CompareTag("Customer") && hasPackage)
        {
            if (hasPackage == false)
            {
                Debug.Log("You don't have a package!");
            }
            hasPackage = false;
            Destroy(collision.gameObject);
            Debug.Log("Package delivered!");
        }
    }
}

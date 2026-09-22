using NUnit.Framework;
using UnityEngine;
using TMPro;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    int packagesDelivered = 0;
    [SerializeField] float delay = 1f;
    [SerializeField] TMP_Text scoreText;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip pickupSound;
    [SerializeField] AudioClip deliverySound;
    [SerializeField] int packagesToWin = 4;

    void Start()
    {
        UpdateScoreDisplay();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Obtained Package!");
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
            audioSource.PlayOneShot(pickupSound);

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
            GetComponent<ParticleSystem>().Stop();
            packagesDelivered += 1;
            UpdateScoreDisplay();
            audioSource.PlayOneShot(deliverySound);
        }
    }
        void UpdateScoreDisplay()
    {
        scoreText.text = $"Packages Delivered: {packagesDelivered}";
    }
}

using UnityEngine;
using System.Collections;

public class ShipCollision : MonoBehaviour
{
    public GameObject explosionPrefab; // colanim
    public AudioClip collisionSound;   // Sound effect on impact

    private SpriteRenderer spriteRenderer;
    private Collider2D shipCollider;
    private AudioSource audioSource;

    private bool isInvincible = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        shipCollider = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>(); // Assumes AudioSource is attached
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Asteroid") && !isInvincible)
        {
            // 1. Play explosion animation
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // 2. Play sound effect
            if (collisionSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }

            // 3. Destroy the asteroid
            Destroy(collision.gameObject);

            // 4. Lose a life
            GameManager.Instance.LoseLife();

            // 5. Check lives
            if (GameManager.Instance.lives > 0)
            {
                StartCoroutine(Respawn());
            }
            else
            {
                Destroy(gameObject); // Ship destroyed
            }
        }
    }

    private IEnumerator Respawn()
    {
        spriteRenderer.enabled = false;
        shipCollider.enabled = false;

        yield return new WaitForSeconds(1f);

        transform.position = Vector3.zero;

        spriteRenderer.enabled = true;
        shipCollider.enabled = true;
        StartCoroutine(BlinkingInvincibility());
    }

    private IEnumerator BlinkingInvincibility()
    {
        isInvincible = true;
        float blinkTime = 2f;
        float elapsed = 0f;

        while (elapsed < blinkTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.2f);
            elapsed += 0.2f;
        }

        spriteRenderer.enabled = true;
        isInvincible = false;
    }
}

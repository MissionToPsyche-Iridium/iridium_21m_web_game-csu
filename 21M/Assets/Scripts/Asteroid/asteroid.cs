using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public float leftLimit  = -7f ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(leftLimit, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x)
        {
            Destroy(this.gameObject);
        }
    }
}

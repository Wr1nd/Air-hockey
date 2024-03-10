using UnityEngine;

public class Puk : MonoBehaviour
{
    Camera mainCamera;
    Rigidbody2D rb;

    AudioSource audioData;
    public AudioClip colSound;

    private void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var viewportPos = mainCamera.WorldToViewportPoint(transform.position);

        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            transform.position = new Vector3();
            rb.velocity = new Vector2();

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        audioData.PlayOneShot(colSound);
        Debug.LogWarning("done");
    }
}

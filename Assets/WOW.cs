using UnityEngine;

public class WOW : MonoBehaviour
{
    public int direction = 1;
    public float move = 0.5f;
    public float min = 0.5f;
    public float max = 2.5f;
    private Rigidbody2D roblox;
    void Start()
    {
        roblox = GetComponent<Rigidbody2D>();
        move = Random.Range(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 1)
        {
            if (transform.position.x < -12)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            if (transform.position.x > 12)
            {
                Destroy(gameObject);
            }
        }
    }
    void FixedUpdate()
    {
        if (direction > 0)
        {
            direction = 1;
        }
        else if (direction < 0)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }
        roblox.linearVelocityX = -direction * move;
    }
}

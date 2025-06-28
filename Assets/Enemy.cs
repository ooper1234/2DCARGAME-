using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int direction = 1;
    public float move = 0.5f;
    private Rigidbody2D roblox;
    void Start()
    {
        roblox = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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

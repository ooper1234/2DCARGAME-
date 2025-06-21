using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 startPosition;
    public float stepPerMove = 1f;
    void Start()
    {
        startPosition = transform.position; // Store the initial position of the object
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(
                transform.position.x - stepPerMove,
                transform.position.y,
                transform.position.z
            );

        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(
                transform.position.x + stepPerMove,
                transform.position.y,
                transform.position.z
            );

        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + stepPerMove,
                transform.position.z
            );

        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y - stepPerMove,
                transform.position.z
            );

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("TouchCAR"))
        {
            Debug.Log("Collision with EvilLeafy detected!");
            transform.position = startPosition; // Reset position on collision

        }
        if (collision.transform.CompareTag("Goal"))
        {
            transform.position = startPosition;
            Debug.Log("You win! YAY");
        }
    }
}

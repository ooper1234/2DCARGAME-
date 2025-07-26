using UnityEngine;
using TMPro;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 startPosition;
    public float stepPerMove = 1f;
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public GameObject WOWLeafy;

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
            score -= 50;
            // score = (int)transform.position.z;
            scoreText.text = "Score: " + score.ToString();
            transform.position = startPosition; // Reset position on collision

        }
        if (collision.transform.CompareTag("Goal"))
        {
            transform.position = startPosition;
            score += 50;
            Destroy(gameObject); // Destroy the goal object
            // score = (int)transform.position.z;
            scoreText.text = "Score: " + score.ToString();

            Debug.Log("You win! YAY");
        }
        if (collision.transform.CompareTag("WOWLeafy"))
        {

            score += 200;
            // score = (int)transform.position.z;
            scoreText.text = "Score: " + score.ToString();
            
            Debug.Log("WOW A BONUS");
        }
    }
}

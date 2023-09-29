using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bball;
    [SerializeField] private Transform location;
    [SerializeField] private GameObject bal;
    [SerializeField] private Transform Board;
    [SerializeField] private float bounceOffset = 5f;
    [SerializeField] private float ballSpeed;
    private bool ballmove = false;
    [SerializeField] private resetgame obj;
    //public AudioSource breakenemy;
    // Start is called before the first frame update
    void Start()
    {
        bball.GetComponent<Rigidbody2D>();
        /*if (Input.GetKey(KeyCode.Space))
        {
            bball.AddForce(Vector2.down * sp);
        }*/
        //gameoversound = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (ballmove == false)
        {
            bball.velocity = Vector2.zero;
            bal.transform.position = location.transform.position;
            if (Input.GetKey(KeyCode.Space))
            {
                bball.AddForce(Vector2.up * ballSpeed);
                ballmove = true;
            }
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bottomend" && lifescript.lifecard > 0)
        {
            lifescript.lifecard -= 1;
            //bal.transform.position = location.transform.position;
            ballmove = false;
            obj.ballnotactive = true;
            bal.SetActive(false);
            //bal.transform.position = location.transform.position;
        }
        if (other.gameObject.tag == "bottomend" && lifescript.lifecard < 1)
        {
            //gameoversound.Play(0);
            lifescript.lifecard = 3;
            SceneManager.LoadScene("Gameover");
            //print("Ball Destroyed.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("sidewall"))
        {
            // Calculate a random offset angle within a small range
            float randomOffset = Random.Range(-bounceOffset, bounceOffset);

            // Adjust the ball's direction by the random offset angle
            Vector2 newDirection = Quaternion.Euler(0, 0, randomOffset) * bball.velocity * 1;

            // Apply the new direction to the ball's velocity
            bball.velocity = newDirection;
        }
    }
}

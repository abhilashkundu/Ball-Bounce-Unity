using UnityEngine;

public class coinscript : MonoBehaviour
{

    public Rigidbody2D rr;
    public int score = 0;

    void Start()
    {
        rr = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rr.AddForce(Vector2.down * 500);
        }
        if (other.gameObject.tag == "board")
        {
            //print("Hiiiiiiiiiii");
            score += 10;
            Destroy(gameObject);
        }

    }
    public void OnCollisionEnter(Collision other)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

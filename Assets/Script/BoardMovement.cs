using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    public float speed;
    public float leftwall;
    public float rightwall;

    /*void Start()
    {
        board = GetComponent<Rigidbody2D>();
    }*/

    void Update()
    {
        transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);

        if (transform.position.x < leftwall)
        {
            transform.position = new Vector2(leftwall, transform.position.y);
        }
        if (transform.position.x > rightwall)
        {
            transform.position = new Vector2(rightwall, transform.position.y);
        }
        // if(transform.position.y > bottomlayer)
        // {
        //     transform.position = new Vector2 (bottomlayer, transform.position.x);
        // }
        // if(Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     board.AddForce(transform.up * jump);
        // }
    }
}

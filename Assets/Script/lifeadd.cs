using UnityEngine;

public class lifeadd : MonoBehaviour
{
    //public int lifeofbrickss;
    public Rigidbody2D rbb;
    //public ball ball;
    /*void Start()
    {
        {
            rbb = GetComponent<Rigidbody2D>();
        }
    }*/

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rbb.AddForce(Vector2.down * 500);
        }
        if (other.gameObject.tag == "board")
        {
            lifescript.lifecard += 1;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "bottomend")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

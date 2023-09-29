using UnityEngine;

public class brick2 : MonoBehaviour
{
    private int lifeofbricks = 2;
    public AudioSource breakenemy;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            breakenemy.Play();
            scorescript.scorecard += 5;
            lifeofbricks -= 1;
        }
        if (lifeofbricks == 0)
        {
            breakenemy.Play();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

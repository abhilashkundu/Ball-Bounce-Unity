using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audioo;
    // Start is called before the first frame update
    void Start()
    {
        audioo = GetComponent<AudioSource>();
        if (lifescript.lifecard == 0)
        {
            audioo.Play();
        }
    }

}

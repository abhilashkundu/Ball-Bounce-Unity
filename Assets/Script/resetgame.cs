using UnityEngine;
using UnityEngine.SceneManagement;

public class resetgame : MonoBehaviour
{

    public bool ballnotactive = false;
    public GameObject ball;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D gola)
    {
        if (gola.gameObject.tag == "Player" && lifescript.lifecard == 0)
        {
            SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ballnotactive == true)
        {
            ball.SetActive(true);
        }
    }
}

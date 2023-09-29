using UnityEngine;
using UnityEngine.SceneManagement;

public class subscript : MonoBehaviour
{
    public static int scenenumber = 1;
    public GameObject paus;
    public bool ispause = false;
    // Start is called before the first frame update
    void Start()
    {
        if (scenenumber == 6)
        {
            scenenumber = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            ispause = true;
            paus.SetActive(true);
        }
        if (GameObject.FindWithTag("enemy") == null || Input.GetKey("p"))
        {
            // || Input.GetKey("p")
            scenenumber += 1;
            SceneManager.LoadScene(scenenumber);
        }
    }
}

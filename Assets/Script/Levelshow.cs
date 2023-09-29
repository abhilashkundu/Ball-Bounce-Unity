using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelshow : MonoBehaviour
{
    //public static int leveldom = 0;

    public TextMeshProUGUI lev;

    // Start is called before the first frame update
    /*void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }*/

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            lev.text = "Level : 1";
        }
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            lev.text = "Level : 2";
        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            lev.text = "Level : 3";
        }
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            lev.text = "Level : 4";
        }
        if (SceneManager.GetActiveScene().name == "Level5")
        {
            lev.text = "Level : 5";
        }
    }
}

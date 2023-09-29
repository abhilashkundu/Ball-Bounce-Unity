using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    void Start()
    {
        subscript.scenenumber = 0;
    }
    public void tomenu()
    {
        scorescript.scorecard = 0;
        SceneManager.LoadScene(0);
    }
}

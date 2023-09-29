using TMPro;
using UnityEngine;
public class lifescript : MonoBehaviour
{
    public static int lifecard = 3;

    public TextMeshProUGUI life;

    // Start is called before the first frame update
    /*void Start()
    {
        score = GetComponent<TextMeshProUGUI>();

    }*/

    // Update is called once per frame
    void Update()
    {
        life.text = "Life : " + lifecard;
    }
}

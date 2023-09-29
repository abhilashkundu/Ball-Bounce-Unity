using TMPro;
using UnityEngine;

public class scorescript : MonoBehaviour
{
    public static int scorecard;

    public TextMeshProUGUI score;

    // Start is called before the first frame update
    /*void Start()
    {
        score = GetComponent<TextMeshProUGUI>();

    }*/

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + scorecard;
    }
}

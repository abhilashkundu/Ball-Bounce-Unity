using TMPro;
using UnityEngine;

public class exitscore : MonoBehaviour
{
    public TextMeshProUGUI exitscored;

    void Start()
    {

    }

    void Update()
    {
        exitscored.text = "Your Score : " + scorescript.scorecard;
    }
}

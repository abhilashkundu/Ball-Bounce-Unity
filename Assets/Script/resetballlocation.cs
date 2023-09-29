using UnityEngine;

public class resetballlocation : MonoBehaviour
{

    [SerializeField] private Transform locationOfBallReset;
    [SerializeField] private Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void OnClickToResetBallLocation()
    {
        ball.transform.position = locationOfBallReset.transform.position;
    }
}

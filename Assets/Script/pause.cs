using UnityEngine;

public class pause : MonoBehaviour
{
    [SerializeField] private GameObject pausecanva;
    public subscript script;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && script.ispause == true)
        {
            Time.timeScale = 1;
            script.ispause = false;
            pausecanva.SetActive(false);
        }
    }

    // Update is called once per frame
    public void Unpause()
    {
        Time.timeScale = 1;
        pausecanva.SetActive(false);
    }
}

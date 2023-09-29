using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class BoardPowerupController : MonoBehaviour
{
    public int PowerUPMultiplier;
    public GameObject board;
    private Vector3 boardScale;

    private void Start()
    {
        boardScale = board.GetComponent<Transform>().localScale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * 500);
        }
        if(collision.gameObject.CompareTag("board"))
        {
            SpriteRenderer sprite = GetComponent<SpriteRenderer>();
            sprite.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            //Board scale change
            Vector3 newScale = board.GetComponent<Transform>().localScale;
            newScale.x = 0.6f;
            board.GetComponent<Transform>().localScale = newScale;
            StartCoroutine(WaitForSomeSeconds());
        }
    }

    IEnumerator WaitForSomeSeconds()
    {
        yield return new WaitForSeconds(10);
        board.GetComponent<Transform>().localScale = boardScale;
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody2D rb;
    public static int score = 0;
    private GameObject scoreObj;
    private Text scoreText;
    public static bool destr = false;
    // Start is called before the first frame update
    void Start()
    {
   
        scoreObj = GameObject.FindGameObjectWithTag("Score");
        scoreText = scoreObj.GetComponent<Text>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    private void Update()
    {
       // Debug.Log(score);
        scoreText.text = "Score: " + score;
        Destroy(gameObject, 500f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            score++;
            Debug.Log(score);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            destr = true;
        }
    }
}

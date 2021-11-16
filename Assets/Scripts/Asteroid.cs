using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Sprite[] sprites;
    private float speed = 1f;
    float randX, randY;

    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[Random.Range(0,7)];
        randX = Random.Range(-360, 360);
        randY = Random.Range(-360, 360);

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        gameObject.transform.Translate(new Vector2(randX, randY) * speed * Time.deltaTime / 1000);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloner : MonoBehaviour
{
    private float xPos;
    private float yPos;

    void Update()
    {
        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.y;
        if (xPos > Border.bottomRight.x + 0.6f)
        {
            gameObject.transform.position = new Vector2(Border.bottomLeft.x, gameObject.transform.position.y);
        }
        else if (xPos < Border.bottomLeft.x - 0.6f)
        {
            gameObject.transform.position = new Vector2(Border.bottomRight.x, gameObject.transform.position.y);
        }
        else if (yPos > Border.topLeft.y + 0.6f)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, Border.bottomLeft.y);
        }
        else if (yPos < Border.bottomLeft.y - 0.6f)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, Border.topLeft.y);
        }
    }
}

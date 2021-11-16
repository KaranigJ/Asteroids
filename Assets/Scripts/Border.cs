using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private Camera camera;
    public static Vector2 bottomLeft, bottomRight, topLeft, topRight;
    // Start is called before the first frame update
    private void Awake()
    {
        camera = GetComponent<Camera>();

        float width = camera.pixelWidth;
        float height = camera.pixelHeight;

        bottomLeft = camera.ScreenToWorldPoint(new Vector2(0, 0));
        bottomRight = camera.ScreenToWorldPoint(new Vector2(width, 0));
        topLeft = camera.ScreenToWorldPoint(new Vector2(0, height));
        topRight = camera.ScreenToWorldPoint(new Vector2(width, height));
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int count = 10;
    public GameObject[] asteroids;
    
    void Start()
    {
        spawn(count);
        Bullet.score = 0;
    }

    private void Update()
    {
        if(Bullet.destr == true)
        {
            spawn(1);
            Bullet.destr = false;
        }
    }
    public void spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(asteroids[Random.Range(0, 2)], new Vector2(Random.Range(Border.bottomLeft.x, Border.topRight.x), Random.Range(Border.bottomLeft.y, Border.topRight.y)), Quaternion.Euler(0, 0, Random.Range(1f, 360f)));
        }
    }
}

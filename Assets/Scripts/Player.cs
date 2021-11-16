using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float speed = 2f;
    private int health = 3;
    [SerializeField]
    private GameObject bullet;
    public GameObject[] HP;

    
    void Update()
    {
      
        float xPos = Input.GetAxis("Horizontal");
        float yPos = Input.GetAxis("Vertical");

       gameObject.transform.Translate(new Vector2(xPos, yPos)*speed * Time.deltaTime);

        Vector2 mousePos = Input.mousePosition;
        
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        angle -= 90;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        switch (health)
        {
            case 2:
                HP[2].SetActive(false);
                break;
            case 1:
                HP[1].SetActive(false);
                break;
            default:
                break;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Debug.Log("hit");
            health--;
            Destroy(collision.gameObject);
        }
    }

}

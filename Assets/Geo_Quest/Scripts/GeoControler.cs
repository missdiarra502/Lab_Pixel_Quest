using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoControler : MonoBehaviour
{ 
    Rigidbody2D rb;
    public float speed = 3;
    public string NextLevel  = "level_2";
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Run killer");
        switch (collision.tag)
        {
            case "Death":
                {
                   string thisLevel=SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(NextLevel); 
                    break;               }
        }
    }
}

using System.Collections;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Geocontroller : MonoBehaviour
{
    int variableOne = 0;
    int variableTwo = 5;
    int variableThree = 3;
    Rigidbody2D Diarra;
    public int speed = 5;
    public string nextLevel = "Scene_2";

    string muslimgirl = "hello";
    // Start is called before the first frame update
    void Start()
    {
        Diarra = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
        string muslimboy = "world";
        Debug.Log(muslimgirl + muslimboy);
        variableOne = variableOne + variableTwo; print(variableOne);
        variableOne += variableTwo; print(variableOne);
        variableOne -= variableTwo; print(variableOne);
        variableOne *= variableTwo; print(variableOne);
        variableOne /= variableTwo; print(variableOne);
        // A lot of times you will want to increase/decrease a number by
        variableOne = variableOne + 1; print(variableOne);
        // For that the ++ or -- is shorthand for increase/decrease by
        variableOne++; print(variableOne);
        variableOne--; print(variableOne);
        Debug.Log(transform.position);

        // Update is called once per frame
        {
            float xInput = Input.GetAxis("Horizontal");
            Diarra.velocity = new Vector2(xInput * speed, Diarra.velocity.y);
        }

    }
       

    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        { transform.position += new Vector3(0, -1, 0); }
        if (Input.GetKeyDown(KeyCode.D))
        { transform.position += new Vector3(1, 0, 0); }
        if (Input.GetKeyDown(KeyCode.E))
                    { transform.position += new Vector3(-1, 0, 0);
    }
    */
        //Diarra.velocity = new Vector2(-1, Diarra.velocity.y);
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            Diarra.velocity = new Vector2(-1, Diarra.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Diarra.velocity = new Vector2(1, Diarra.velocity.y);
        }\
        */
        float xInput = Input.GetAxis("Horizontal");
        //Diarra.velocity = new Vector2(xInput, Diarra.velocity.y);
        Diarra.velocity = new Vector2(xInput * speed, Diarra.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      Debug.Log("Hit"); 
        switch (collision.tag)
        {
            case "Death":
                {
                    Debug.Log("player Has Died");
                    string thiscaLvel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thiscaLvel);
                    break;  

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
       
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //Components References
    public LogicManager logic;
    public Rigidbody2D rigidBody;
   
    
    //Variables 
    public float flapStrength = 10;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Angry Andy";
        /*
        Find the gameObject during runtime by tag "Logic"
        Link the LogicManager script to the @logic
        */
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

    void Fly()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            rigidBody.velocity = Vector2.up * flapStrength;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
    
}

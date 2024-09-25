using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeTrigger : MonoBehaviour
{
    //Components References
    public LogicManager logic;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        Find the gameObject during runtime by tag "Logic"
        Link the LogicManager script to the @logic
        */
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if was the Bird activate the trigger
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
        }
    }
}
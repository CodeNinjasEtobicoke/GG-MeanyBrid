using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour { 
//Game manager object
[Header("Game Controller Object for controlling the game")]
public GameController gameController;
[Header("default Velocity")]
public float velocity = 5;
//Phycics for the bird
private Rigidbody rb;
//Height for bird
private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {   
        //Game controller component
        //gameController
    }

    // Update is called once per frame
    void Update()
    {

    }
}

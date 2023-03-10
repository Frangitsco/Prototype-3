using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour{

    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 25;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update(){
        // If an object goes outside the plane, remove that object
        if (transform.position.z > topBound){
            Destroy(gameObject);
        // If an object goes past the player, remove that object and update the number of lives 
        } else if (transform.position.z < lowerBound){
            gameManager.AddLives(-1);
            Destroy(gameObject);
        } else if(transform.position.x > sideBound){
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}

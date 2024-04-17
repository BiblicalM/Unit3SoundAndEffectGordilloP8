using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerContrrollerScript;
    private float leftBound;

    // Start is called before the first frame update
    void Start()
    {
        playerContrrollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerContrrollerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

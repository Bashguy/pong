using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D body;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
        bool isRight = UnityEngine.Random.value >= 0.5;

        float velocityX = -1f;

        float velocityY;

        if (isRight ==  true) {

            velocityX = 1f;

          }

        do {

            velocityY = UnityEngine.Random.Range(-1f,1f);

        } while (Mathf.Approximately(velocityY, 0f));

        body.velocity = new Vector2(velocityX * speed, velocityY * speed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

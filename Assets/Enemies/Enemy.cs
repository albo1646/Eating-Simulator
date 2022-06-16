using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyDirection = "left";
    
    public float enemyHP = 100f;

    public float enemySpeed = 0.03f;

    public bool stuck = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (!stuck)
        {
            if (transform.position.y > -3)
            {
                transform.position += new Vector3(0, -1, 0) * enemySpeed;
            }


            if (transform.position.x < -3)
            {
                enemyDirection = "left";
            }

            if (transform.position.x > 3)
            {
                enemyDirection = "right";
            }

            if (enemyDirection == "left")
            {
                transform.position += new Vector3(1, 0, 0) * enemySpeed;
            }

            if (enemyDirection == "right")
            {
                transform.position += new Vector3(-1, 0, 0) * enemySpeed;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }

        transform.SetParent(collision.transform);
        stuck = true;
    }

}


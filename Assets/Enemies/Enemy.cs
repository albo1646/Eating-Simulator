using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyDirection = "left";
    public float enemyHP = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -3)
        {
            transform.position += new Vector3(0, -0.01f, 0);
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
            transform.position += new Vector3(0.001f,0,0);
        }

        if (enemyDirection == "right")
        {
            transform.position += new Vector3(-0.001f, 0, 0);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyHP -= 20f;

        if (enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }

}


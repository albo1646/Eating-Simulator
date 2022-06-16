using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumerLeft : MonoBehaviour
{
    public string ConsumerLeftDirection = "left";
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider2D collision)
    {
        ConsumerLeftDirection = "right";
    }

    // Update is called once per frame
    void Update()
    {
        if (ConsumerLeftDirection == "right")
        {
            transform.position += new Vector3(-0.05f, 0, 0);
        }

        if (ConsumerLeftDirection == "left")
        {
            transform.position += new Vector3(0.05f, 0, 0);
        }

    }
}

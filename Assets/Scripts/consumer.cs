using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consumer : MonoBehaviour

{

   
    public float playerSpeed = 0.025f;
    public string consumerDirection = "right";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       


        if (consumerDirection == "left")
        {
            transform.position += new Vector3(0.05f, 0, 0);
        }

        if (consumerDirection == "right")
        {
            transform.position += new Vector3(-0.05f, 0, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(gameObject);
        consumerDirection = "left";

    }
}

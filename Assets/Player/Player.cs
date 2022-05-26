using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 0.001f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0) * playerSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0) * playerSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * playerSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * playerSpeed;
        }

        float PlayerX = Mathf.Clamp(transform.position.x, -50, 50);
        transform.position = new Vector3(PlayerX, transform.position.y, transform.position.z);
    }
}

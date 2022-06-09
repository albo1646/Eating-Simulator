using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerDirection = "right";
    public float playerSpeed = 0.001f;
    public GameObject consumerPrefab;
    public GameObject consumerleft;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Application.LoadLevel("Lose");
    }


    // Update is called once per frame
    void Update()
    {

       
        
        if (Input.GetKey(KeyCode.A))
        {
            playerDirection = "left";
            transform.position += new Vector3(-1, 0, 0) * playerSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerDirection = "right";
            transform.position += new Vector3(1, 0, 0) * playerSpeed;
        }

        float PlayerX = Mathf.Clamp(transform.position.x, -50, 50);
        transform.position = new Vector3(PlayerX, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerDirection == "right")
            {
                Instantiate(consumerleft, transform.position, Quaternion.identity);
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }

            if (playerDirection == "left")
            {
                Instantiate(consumerPrefab, transform.position, Quaternion.identity);
                transform.rotation = new Quaternion(0, -180, 0,0);
            }
        }

    }

}

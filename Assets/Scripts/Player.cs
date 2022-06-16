using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerDirection = "right";
    public float playerSpeed = 0.001f;
    public GameObject consumerPrefab;
    public GameObject consumerleft;
    public static int timer = 0;
    public int jumpTimer = 0;
    public int timeSinceLastJump = 2000;
    public bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer++;
        if (timer == 12000)
        {
            Application.LoadLevel("Win");
        }

        if (Input.GetKey(KeyCode.Q) && timeSinceLastJump > 2000)
        {
            jump = true;

        }

        else jump = false;

        if (jump )
        {
            jumpTimer++;

            if (jumpTimer == 2000)
            {
                jump = false;
                timeSinceLastJump = 0;
                jumpTimer = 0;
            }
            transform.position = new Vector3(transform.position.x, -0.6f, 0);
        }


        if (!jump)
        {
            transform.position = new Vector3(transform.position.x, -3, 0);

            timeSinceLastJump++;
            Debug.Log("time since last jump:" + timeSinceLastJump);

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
                Debug.Log("Jump");
                if (playerDirection == "right")
                {
                    Instantiate(consumerleft, transform.position, Quaternion.identity);
                    transform.rotation = new Quaternion(0, 180, 0, 0);
                }

                if (playerDirection == "left")
                {
                    Instantiate(consumerPrefab, transform.position, Quaternion.identity);
                    transform.rotation = new Quaternion(0, -180, 0, 0);
                }
            }
        }

       

    }

}

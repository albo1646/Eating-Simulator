using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public float playerScore = 0f;

    [SerializeField] private Text scoreText;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerScore = playerScore + 100f;
           // scoreText.text = "Score: " + playerScore +" Time" + Player.timer;
        }

        if (playerScore >= 2100)
        {
            Application.LoadLevel("Win");
        }
    }
}

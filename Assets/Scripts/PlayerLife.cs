using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public float playerHealth = 100f;

    [SerializeField] private Text healthText;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth = playerHealth - 10f;
           // healthText.text = "Player Health: " + playerHealth;
        }

        if (playerHealth <= 0)
        {
            playerHealth--;
            Application.LoadLevel("Lose");
        }
    }
}

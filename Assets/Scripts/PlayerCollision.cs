using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Obstacle"))
        {
            GetComponent<PlayerMovement>().enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

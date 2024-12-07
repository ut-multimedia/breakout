using System;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            //GAME OVER
            Debug.Log("Game Over");
        }
    }
}

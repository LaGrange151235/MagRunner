using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPlatform : MonoBehaviour
{
    public GameObject winUI; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WinTheGame();
        }
    }

    private void WinTheGame()
    {
        if (winUI != null)
        {
            winUI.SetActive(true);
        }
    }
}

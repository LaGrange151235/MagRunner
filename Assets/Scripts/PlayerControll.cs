using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPoleControll : MonoBehaviour
{
    public float deathYPosition;
    public GameObject deathUI;

    void Update()
    {
        CheckForDeath();
        UpdatePole();
    }

    void UpdatePole()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Magetism magetism = GetComponent<Magetism>();
            if (magetism != null)
            {
                if (magetism.currentPole == MagneticPole.North)
                {
                    magetism.currentPole = MagneticPole.South;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Magetism magetism = GetComponent<Magetism>();
            if (magetism != null)
            {
                if (magetism.currentPole == MagneticPole.South)
                {
                    magetism.currentPole = MagneticPole.North;
                }
            }
        }
    }

    void CheckForDeath()
    {
        if (transform.position.y < deathYPosition)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player Died!");
        if (deathUI != null)
        {
            deathUI.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void ContinueGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}

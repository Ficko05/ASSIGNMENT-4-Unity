using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagerr : MonoBehaviour
{
    

    healthCounter healthCounter;

    public GameObject gameoverUI;

    void Start()
    {
        

        healthCounter = healthCounter.instance;
    }

    void Update()
    {
        if (healthCounter.count == 0)
        {
            endGame();
        }
        if (Input.GetKeyDown("e"))
        {
            endGame();
        }

    }
    void endGame()
    {
        gameoverUI.SetActive(true);
    }

    void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

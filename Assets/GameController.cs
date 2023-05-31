using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour { 
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    

    void Start()
    {
  
    }


    private void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(0);
    }

    public void BirdDied()
    {
        //gameOverText.SetActive(false);
        gameOver = true;
    }



}

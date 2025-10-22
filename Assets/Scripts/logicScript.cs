using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class logicScript : MonoBehaviour
{
    int score;
    [SerializeField]private GameObject gmS;
    [SerializeField]private TMP_Text scoreText,endScore; 
    private bool gameover = false;

    void Update()
    {
        if (!gameover)
        {
            score++;
            scoreText.text = score.ToString();
        }
        
        
    }

    public void gameOver()
    {
        Time.timeScale = 0f;
        gameover = true;
        endScore.text = "Score: "+ score;
        gmS.SetActive(true);
    }
    public void Restart()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);

    }
    public void exitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void playGame()
    {
        SceneManager.LoadScene(1);

    }
    public void quitGame()
    {
        Application.Quit();
    }
    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class mlogic : MonoBehaviour
{
    // Start is called before the first frame update
 
    

    // Update is called once per frame
    public void playGame()
    {
        SceneManager.LoadScene(1);
        

    }
    public void quitGame()
    {
        Application.Quit();
    }


}

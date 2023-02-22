using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2 : MonoBehaviour
{
    private bool gameEnded;
    public string nextLevelName;

    public void WinLevel()
    {
        if (!gameEnded)
        {
            Debug.Log("You Win!");
            if (nextLevelName != "")
            {
                SceneManager.LoadScene(nextLevelName);
            }
            
            gameEnded = true;
        }
    }
        
    public void LooseLevel()
    {
        if(!gameEnded)
        {
            Debug.Log("You Loose!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gameEnded = true;
        }
    }

}

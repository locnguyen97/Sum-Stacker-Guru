using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    private int startIndex = 0;

    public int currentIndex;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        currentIndex = startIndex;
    }
    
    
    
    public void CheckLevelUp()
    {
        currentIndex += 1;
            StartCoroutine(LevelUp());
    }
    
    IEnumerator LevelUp()
    {
        yield return new WaitForSeconds(1);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (currentIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            currentIndex = 0;
        }
        else
        {
            FindObjectOfType<Level>().StartGame();
        }
    }
}
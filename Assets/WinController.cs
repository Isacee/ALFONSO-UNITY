using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance; 
    private int enemyCount;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void RegisterEnemy()
    {
        enemyCount++;
    }


    public void UnregisterEnemy()
    {
        enemyCount--;

        if (enemyCount <= 0)
        {
            TriggerWin();
        }
    }

   
    void TriggerWin()
    {

        SceneManager.LoadScene(3);
    }
}



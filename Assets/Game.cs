using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOverController : MonoBehaviour
{
    public PLayerController player; 
    
    void Update()
    {
        if (player.health <= 0)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        SceneManager.LoadScene(2);
    }
}

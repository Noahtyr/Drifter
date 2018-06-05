using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void GameOver()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", restartDelay);
            GameObject.FindGameObjectWithTag("AudioManager").SendMessage("PlayGameOverSound");
        }
        
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

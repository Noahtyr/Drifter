using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditToMain : MonoBehaviour {

	public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

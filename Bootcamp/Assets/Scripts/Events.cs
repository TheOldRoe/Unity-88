using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
   
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

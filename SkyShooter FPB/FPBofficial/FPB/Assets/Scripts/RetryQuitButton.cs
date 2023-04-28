using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryQuitButton : MonoBehaviour
{
    private bool ismuted = false;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.M) && ismuted == false)
        {
            ismuted = true;
            AudioListener.volume = 0;
        }
        else if (Input.GetKeyDown(KeyCode.M) && ismuted == true)
        {
            ismuted = false;
            AudioListener.volume = 1;
        }

    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishScript3 : MonoBehaviour
{
    public GameObject panel;
    public PlayerMovement player;
    public Text scoreText;
    public Text highScoreText;
    public Text highScoreTextEnd;
    private float scoreAmount;

    void Start()
    {
        scoreAmount = 0f;
        highScoreText.text = "RECORD: " + PlayerPrefs.GetFloat("highscore", 100f).ToString("F2") + "s";
    }

    private void Update()
    {
        scoreAmount += Time.deltaTime;
        scoreText.text = scoreAmount.ToString("F2") + "s";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (scoreAmount < PlayerPrefs.GetFloat("highscore", 100))
        {
            PlayerPrefs.SetFloat("highscore", scoreAmount);
            highScoreText.text = "RECORD: " + scoreAmount.ToString("F2") + "s";
        }
        highScoreTextEnd.text = "RECORD: " + PlayerPrefs.GetFloat("highscore").ToString("F2") + "s";
        panel.SetActive(true);
        Destroy(player);
        StartCoroutine(scene());
    }

    IEnumerator scene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

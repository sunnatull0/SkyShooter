using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TheEnd : MonoBehaviour
{
    public GameObject panel;
    public PlayerMovement player;
    public Text highScoreTextEnd;
    public Text scoreText;
    public Text highScoreText;
    private float scoreAmount;

    void Start()
    {
        scoreAmount = 0f;
        highScoreText.text = "RECORD: " + PlayerPrefs.GetFloat("highscore4", 100f).ToString("F2") + "s";
    }

    private void Update()
    {
        scoreAmount += Time.deltaTime;
        scoreText.text = scoreAmount.ToString("F2") + "s";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (scoreAmount < PlayerPrefs.GetFloat("highscore4", 100))
        {
            PlayerPrefs.SetFloat("highscore4", scoreAmount);
            highScoreText.text = "RECORD: " + scoreAmount.ToString("F2") + "s";
        }
        highScoreTextEnd.text = "RECORD: " + PlayerPrefs.GetFloat("highscore4").ToString("F2") + "s";
        panel.SetActive(true);
        Destroy(player);
        StartCoroutine(scene());
    }

    IEnumerator scene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }

}

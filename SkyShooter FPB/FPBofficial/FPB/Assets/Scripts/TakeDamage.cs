using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamage : MonoBehaviour
{
    public float health = 2f;
    //private int dead = 0;

    private void Start()
    {
        //dead = PlayerPrefs.GetInt("Deaths");
    }

    private void OnTriggerEnter(Collider other)
    {
        /*if(PlayerPrefs.GetInt("Deaths", dead) == 5)
        {
            PlayerPrefs.SetInt("Deaths", dead = 0);
            ShowAd();
        }
        dead++;*/
        //PlayerPrefs.SetInt("Deaths", dead);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Healthh(float amount)
    {
        health -= amount;
        
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    /*public void ShowAd()
    {
        Application.ExternalCall("ShowAd");
    }*/

}

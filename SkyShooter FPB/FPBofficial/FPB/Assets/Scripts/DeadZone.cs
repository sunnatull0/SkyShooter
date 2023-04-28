using System.Collections;
using UnityEngine;
public class DeadZone : MonoBehaviour
{

    public GameObject deathobject;
    public AudioSource diesound;
    
    void OnTriggerEnter(Collider other)
    {
        deathobject.SetActive(true);
        diesound.Play();
        StartCoroutine(Freeze());
    }

    IEnumerator Freeze()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
    }

}

using UnityEngine;

public class Footstep : MonoBehaviour
{
    AudioSource footsteps;
    void Start()
    {
        footsteps = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            footsteps.enabled = true;
        }
        else
        {
            footsteps.enabled = false;
        }
    }
}

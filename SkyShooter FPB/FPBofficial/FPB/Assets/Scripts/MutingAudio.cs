using UnityEngine;

public class MutingAudio : MonoBehaviour
{
    bool ismuted = false;

    void Update()
    {
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

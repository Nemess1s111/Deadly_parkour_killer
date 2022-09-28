using UnityEngine;

public class SoundRun : MonoBehaviour
{
    public AudioSource moveSound;

    void Update()
    {
        if (GetComponent<Rigidbody2D>().velocity.magnitude > 0.1f)
        {
            if (!moveSound.isPlaying)
            {
                moveSound.Play();
            }
        }
        else
        {
            moveSound.Stop();
        }
    }
}
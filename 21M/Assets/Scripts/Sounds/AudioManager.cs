using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource typeMusic;
    public AudioClip typeSound;

    public void PlayTypeSound()
    {
        if (!typeMusic.isPlaying && typeSound != null)
        {
            typeMusic.clip = typeSound;
            typeMusic.loop = true;
            typeMusic.Play();
        }
    }

    public void StopTypeSound()
    {
        if (typeMusic.isPlaying)
        {
            typeMusic.Stop();
        }
    }
}

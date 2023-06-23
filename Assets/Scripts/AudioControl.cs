using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioClip musicClip; // Çalınacak şarkının AudioClip'i
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Şarkıyı başlatma
        PlayMusic();
    }

    void PlayMusic()
    {
        audioSource.clip = musicClip;
        audioSource.Play();
    }
}
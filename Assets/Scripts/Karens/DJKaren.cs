using UnityEngine;

public class DJKaren : MonoBehaviour
{
    public static DJKaren Instance { get; private set; }
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
            audioSource = GetComponent<AudioSource>(); // Assuming an AudioSource is attached to the same GameObject
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }

    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}

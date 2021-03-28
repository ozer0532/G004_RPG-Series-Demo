using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpawnAudioClip2 : SkillSpawnBase2
{
    public AudioClip clip;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnSkillUse()
    {
        audioSource.PlayOneShot(clip);
    }
}

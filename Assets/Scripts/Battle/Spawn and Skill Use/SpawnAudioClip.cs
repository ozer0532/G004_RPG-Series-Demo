using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpawnAudioClip : MonoBehaviour
{
    public AudioClip audioClip;
    
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnSkillUse()
    {
        audioSource.PlayOneShot(audioClip);
    }
}

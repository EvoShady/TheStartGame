using UnityEngine;

public class VoiceOverTextPreLevel1Cutscene : MonoBehaviour
{

    [SerializeField] AudioSource voiceOverTextAudioSource;
    [SerializeField] AudioClip[] voiceOverTextAudioClips;

    public void TriggerTextVoice0()
    {
        voiceOverTextAudioSource.PlayOneShot(voiceOverTextAudioClips[0]);
    }

    public void TriggerTextVoice1()
    {
        voiceOverTextAudioSource.PlayOneShot(voiceOverTextAudioClips[1]);
    }
    
    public void TriggerTextVoice2()
    {
        voiceOverTextAudioSource.PlayOneShot(voiceOverTextAudioClips[2]);
    }
    
    public void TriggerTextVoice3()
    {
        voiceOverTextAudioSource.PlayOneShot(voiceOverTextAudioClips[3]);
    }
}

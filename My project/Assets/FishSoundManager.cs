using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSoundManager : MonoBehaviour
{
    private AudioSource AudioSrce;
    public int song = -1;
    [SerializeField]public List<AudioClip> soundEffects = new List<AudioClip>();
    [SerializeField]public List<AudioClip> backgroundMusic = new List<AudioClip>();
    // Start is called before the first frame update
    void Start()
    {
        AudioSrce = this.GetComponent<AudioSource>();
        AudioSrce.loop = true;
        AudioClip stage0 = Resources.Load<AudioClip>("Audio/BackgroundMusic/stage0");
        backgroundMusic.Add(stage0);
        AudioClip stage1 = Resources.Load<AudioClip>("Audio/BackgroundMusic/stage1");
        backgroundMusic.Add(stage1);
        AudioClip stage2 = Resources.Load<AudioClip>("Audio/BackgroundMusic/stage2");
        backgroundMusic.Add(stage2);
        AudioClip catchEffect = Resources.Load<AudioClip>("Audio/SoundEffects/catch");
        soundEffects.Add(catchEffect);
    }

    public void playMusic(AudioClip music, int songnum){
        if(song!=songnum){
        song = songnum;
        AudioSrce.clip = music;
        AudioSrce.Play();
        }
    }
    public void playOnce(AudioClip sound){
        AudioSrce.PlayOneShot(sound);
    }
}

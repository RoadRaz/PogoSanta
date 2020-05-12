using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip jumpTone;
    public static AudioClip pickUpTone;
    public static AudioClip santafellTone;
    static AudioSource audsrc;

    // Start is called before the first frame update
    void Start()
    {
        jumpTone = Resources.Load<AudioClip>("jump");
        pickUpTone = Resources.Load<AudioClip>("pickUp");
        santafellTone = Resources.Load<AudioClip>("santaFell");
        audsrc = GetComponent<AudioSource>();
    }

    public static void playTune(string tune)
    { 
        switch(tune)
        {
            case "jump":
                audsrc.PlayOneShot(jumpTone);
                break;
            case "pickUp":
                audsrc.PlayOneShot(pickUpTone);
                break;
            case "santaFell":
                audsrc.PlayOneShot(santafellTone);
                break;
        }
    }

}

using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static AudioClip jumpSound;
    static AudioSource audioSrc;

    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("Jump");
        audioSrc = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
            audioSrc.PlayOneShot(jumpSound);
            break;
        }
    }
}
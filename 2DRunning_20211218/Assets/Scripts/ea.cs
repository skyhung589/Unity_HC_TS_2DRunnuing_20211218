
using UnityEngine;

public class player : MonoBehaviour

{
    [Header("����")]
    public AudioClip soundJump;
    public AudioClip soundlide;

    private AudioSource aud;


    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    private void    Jump()
    {
        aud.PlayOneShot(soundJump);
    }
    private void    Sile()
    {
        if(Input.GetKey(keySlide))
        {

        }
    }
}

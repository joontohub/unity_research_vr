using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    AudioSource audioSource;
    
    public static MusicController _instance;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    public void PlayAudio()
    {
        audioSource.Play();
    }
    // Update is called once per frame
    public void OffAudio()
    {
        audioSource.Stop();
    }
  
}

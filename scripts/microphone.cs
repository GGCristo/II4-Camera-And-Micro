using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microphone : MonoBehaviour
{
    private AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            print("Grabando audio");
            audio.clip = Microphone.Start("Micrófono (3- Logitech G430 Gaming Headset)", false, 3, 44100);
        } else if(Input.GetKey(KeyCode.P)) {
            print("Reproduciendo audio");
            audio.Play();
        }
    }
}
